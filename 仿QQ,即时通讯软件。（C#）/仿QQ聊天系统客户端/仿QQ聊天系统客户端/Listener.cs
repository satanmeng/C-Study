using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

namespace 仿QQ聊天系统客户端
{
    class Listener
    {
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private BinaryReader br;
        private BinaryWriter bw;

        //是否正常退出
        private bool isExit = false;

        private void ReceiveData()
        {
            string receiveString = null;
            while (!isExit)
            {
                ReceiveMessageDelegate d = new ReceiveMessageDelegate(receiveMessage);
                IAsyncResult result = d.BeginInvoke(out receiveString, null, null);

                //使用轮询方式来盘点异步操作是否完成
                while (!result.IsCompleted)
                {
                    if (isExit)
                        break;
                    Thread.Sleep(250);
                }
                //获取Begin方法的返回值所有输入/输出参数
                d.EndInvoke(out receiveString, result);              
            }
        }


        private delegate void ReceiveMessageDelegate(out string receiveMessage);
        /// <summary>
        /// 读取服务器发过来的信息
        /// </summary>
        /// <param name="receiveMessage"></param>
        private void receiveMessage(out string receiveMessage)
        {
            receiveMessage = null;
            try
            {
                receiveMessage = br.ReadString();
            }
            catch (Exception)
            {

            }
        }


    }
}
