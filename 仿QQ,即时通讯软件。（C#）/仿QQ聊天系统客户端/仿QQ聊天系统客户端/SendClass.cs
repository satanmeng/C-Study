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
    class SendClass
    {
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private BinaryReader br;
        private BinaryWriter bw;

        //是否正常退出
        private bool isExit = false;

        /// <summary>
        /// 异步向服务器发送数据
        /// </summary>
        /// <param name="message"></param>
        private void AsyncSendMessage(string message)
        {
            SendMessageDelegate d = new SendMessageDelegate(SendMessage);
            IAsyncResult result = d.BeginInvoke(message, null, null);
            while (!result.IsCompleted)
            {
                if (isExit)
                    return;
                Thread.Sleep(50);
            }
            d.EndInvoke(result);
        }





        delegate void SendMessageDelegate(string message);
        /// <summary>
        /// 向服务端发送数据
        /// </summary>
        /// <param name="message"></param>
        private void SendMessage(string message)
        {
            try
            {
                bw.Write(message);
                bw.Flush();
            }
            catch
            {

            }
        }
    }
}
