using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿QQ聊天系统客户端
{
    public partial class ChatForm : Form
    {
        public string frnm;
        public int frId;
        public string data;

        Net net = new Net();

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.Text = frnm;
            NetSet.chatform = this.FriendRtb;
            NetSet.isOpenChatform = true;
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            data = System.DateTime.Now.ToString();
            net.AsyncSendMessage("Talk," + frId + "," + myselfRtb.Text + "," + data + "," + frnm + "\r\n");
            FriendRtb.AppendText(System.DateTime.Now.ToString() + "\r\n");
            FriendRtb.AppendText(UserHelper.loginName + "\r\n");
            FriendRtb.AppendText(myselfRtb.Text + "\r\n");
            myselfRtb.Clear();
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetSet.isOpenChatform = false;
        }
        
    }
}
