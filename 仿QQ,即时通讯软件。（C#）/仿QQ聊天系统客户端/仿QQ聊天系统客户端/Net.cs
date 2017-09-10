using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace 仿QQ聊天系统客户端
{
    class Net
    {
        //private string offlineUser;

        /// <summary>
        /// 异步向服务器发送数据
        /// </summary>
        /// <param name="message"></param>
        public  void AsyncSendMessage(string message)
        {
            SendMessageDelegate d = new SendMessageDelegate(SendMessage);
            IAsyncResult result = d.BeginInvoke(message, null, null);
            while (!result.IsCompleted)
            {
                if (NetSet.isExit)
                    return;
                Thread.Sleep(50);
            }
            SendMessageStates states = new SendMessageStates();
            states.d = d;
            states.result = result;
            Thread t = new Thread(FinishAsyncSendMessage);
            t.IsBackground = true;
            t.Start(states);
        }

        /// <summary>
        /// 处理接收的服务端数据
        /// </summary>
        /// <param name="obj"></param>
        public  void FinishAsyncSendMessage(object obj)
        {
            SendMessageStates states = (SendMessageStates)obj;
            states.d.EndInvoke(states.result);
        }

        public  delegate void SendMessageDelegate(string message);
        /// <summary>
        /// 向服务端发送数据
        /// </summary>
        /// <param name="message"></param>
        public  void SendMessage(string message)
        {
            try
            {
                NetSet.bw.Write(message);
                NetSet.bw.Flush();
            }
            catch
            {
                MessageBox.Show("发送失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 发送信息状态的数据结构
        /// </summary>
        public  struct SendMessageStates
        {
            public SendMessageDelegate d;
            public IAsyncResult result;
        }

        public  delegate void ReceiveMessageDelegate(out string receiveMessage);
        /// <summary>
        /// 读取服务器发过来的信息
        /// </summary>
        /// <param name="receiveMessage"></param>
        public  void receiveMessage(out string receiveMessage)
        {
            receiveMessage = null;
            try
            {
                receiveMessage = NetSet.br.ReadString();
                //MessageBox.Show("test" + receiveMessage, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送失败！"+ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void close()
        {
            if (NetSet.tcpClient != null)
            {
                AsyncSendMessage("Logout," + UserHelper.loginId);
                NetSet.isExit = true;
                //NetSet.br.Close();
                //NetSet.bw.Close();
                NetSet.tcpClient.Close();
            }
            if (NetSet.br != null)
            {
                NetSet.br.Close();
            }
            if (NetSet.bw != null)
            {
                NetSet.bw.Close();
            }
        }

        //开始连接
        public void StartConnect()
        {
            Thread threadConnect = new Thread(ConnectoServer);
            threadConnect.Start();
        }

        //发起连接请求
        public void ConnectoServer()
        {
            AsyncCallback requestcallback = new AsyncCallback(RequestCallBack);
            NetSet.tcpClient = new TcpClient(AddressFamily.InterNetwork);
            IAsyncResult result = NetSet.tcpClient.BeginConnect(IPAddress.Parse(NetSet.serverIP), 8889, requestcallback, NetSet.tcpClient);
            while (result.IsCompleted == false)
            {
                Thread.Sleep(30);
            }
        }


        //回调函数，用于向服务进程发起连接请求
        private void RequestCallBack(IAsyncResult iar)
        {
            try
            {
                NetSet.tcpClient = (TcpClient)iar.AsyncState;
                NetSet.tcpClient.EndConnect(iar);

                //间隔延时
                DateTime nowtime = DateTime.Now;

                while (nowtime.AddSeconds(1) > DateTime.Now) { }
                if (NetSet.tcpClient != null)
                {
                    MessageBox.Show("连接成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NetSet.networkStream = NetSet.tcpClient.GetStream();
                    NetSet.br = new BinaryReader(NetSet.networkStream);
                    NetSet.bw = new BinaryWriter(NetSet.networkStream);
                    AsyncSendMessage("Login," + UserHelper.loginId);
                    Thread threadReceive = new Thread(new ThreadStart(ReceiveData));
                    threadReceive.IsBackground = true;
                    threadReceive.Start();
                }
            }
            catch
            {
                MessageBox.Show("服务器连接失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 处理接收的服务器收据
        /// </summary>
        private void ReceiveData()
        {
            string receiveString = null;
            while (!NetSet.isExit)
            {
                ReceiveMessageDelegate d = new ReceiveMessageDelegate(receiveMessage);
                IAsyncResult result = d.BeginInvoke(out receiveString, null, null);
                //使用轮询方式来盘点异步操作是否完成
                while (!result.IsCompleted)
                {
                    if (NetSet.isExit)
                        break;
                    Thread.Sleep(250);
                }
                             
                //获取Begin方法的返回值所有输入/输出参数
                d.EndInvoke(out receiveString, result);
                if (receiveString == null)
                {
                    if (!NetSet.isExit)
                        MessageBox.Show("与服务器失去联系");
                    break;
                }
                string[] splitString = receiveString.Split(',');
                string command = splitString[0].ToLower();
                switch (command)
                {
                    case "login":   //格式： login,用户名
                        int onlineid = int.Parse(splitString[1]);
                        //NetSet.frb.onlineUser(onlineid);
                        break;
                    case "logout":  //格式： logout,用户名
                        int offid = int.Parse(splitString[1]);
                        NetSet.frb.offlineUser(offid);
                        break;
                    case "talk":    //格式： talk,用户名,对话信息
                        AddTalkMessage(splitString[3] + "\r\n");
                        AddTalkMessage(splitString[4]);
                        AddTalkMessage(splitString[2]);
                        break;
                }
            }
            Application.Exit();
        }

        private delegate void AddTalkMessageDelegate(string message);
        /// <summary>
        /// 向 chatForm 中添加聊天记录
        /// </summary>
        /// <param name="message"></param>
        private void AddTalkMessage(string message)
        {
            //MessageBox.Show("测试" + NetSet.isOpenChatform, "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (NetSet.isOpenChatform == true)
            {
                if (NetSet.chatform.InvokeRequired)
                {
                    AddTalkMessageDelegate d = new AddTalkMessageDelegate(AddTalkMessage);
                    NetSet.chatform.Invoke(d, new object[] { message });
                }
                else
                {
                    NetSet.chatform.AppendText(message);
                    NetSet.chatform.ScrollToCaret();
                }
            }
            else
            {

            }
        }
        
        
    }
}
