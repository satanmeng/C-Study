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
using _CUSTOM_CONTROLS._ChatListBox;

namespace 仿QQ聊天系统客户端
{
    class NetSet
    {
        public static TcpClient tcpClient;
        public static NetworkStream networkStream;
        public static BinaryReader br;
        public static BinaryWriter bw;
        public static string serverIP = "127.0.0.1";
        //public static ChatForm chatform;
        public static RichTextBox chatform;
        public static bool isOpenChatform = false;

        //是否正常退出
        public static bool isExit = false;

        public static Friendbox frb;

        public static bool IsFirstLogin = true;

        public static bool IsReady = false;

        //public static List<int> onlineId = new List<int>();
        
    }
}
