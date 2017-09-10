using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using _CUSTOM_CONTROLS._ChatListBox;

namespace 仿QQ聊天系统客户端
{
    public partial class Friendbox : UserControl
    {
        public int friendId;
        public int i = 0;
        public string nickname;
        public int faceId;
        public string personalmsg;
        //public string frnickname;
        

        public Friendbox()
        {
            InitializeComponent();
        }

        private void Friendbox_Load(object sender, EventArgs e)
        {
            NetSet.frb = this;
            chatListBox1.Items.Clear();
            ChatListItem item = new ChatListItem("我的好友");

            MyQQDBDataContext linq = new MyQQDBDataContext();
            var Result = from sqlData in linq.Friends
                         where sqlData.HostId == UserHelper.loginId
                         select sqlData;

            foreach (Friends fr in Result)
            {
                friendId = fr.FriendId;

                var Friend = from sqlData in linq.Users
                             where sqlData.Id == friendId
                             select sqlData;
                foreach (Users user in Friend)
                {
                    nickname = user.NickName;
                    faceId = user.FaceId;
                    personalmsg = user.personalmsg;
                }

                int RealFaceId = faceId + 1;
                ChatListSubItem subItem = new ChatListSubItem(friendId,nickname,personalmsg);
                subItem.HeadImage = Image.FromFile("H:/c#/images/"+RealFaceId+".bmp");
                subItem.Status = ChatListSubItem.UserStatus.Online;
                //subItem.Status = ChatListSubItem.UserStatus.OffLine;
                item.SubItems.AddAccordingToStatus(subItem);
            }

            item.SubItems.Sort();
            chatListBox1.Items.Add(item);
        }

        //鼠标双击好友列表的事件
        private void chatListBox1_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            if (e.SelectSubItem.Status == ChatListSubItem.UserStatus.Online)
            {
                ChatForm chatform = new ChatForm();
                chatform.frnm = e.SelectSubItem.NicName;
                chatform.frId = e.SelectSubItem.ID;
                chatform.Show();
            }
            else
            {
                MessageBox.Show("此好友处于离线状态，无法发送消息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void offlineUser(int offId)
        {
            ChatListSubItem[] a;
            a = chatListBox1.GetSubItemsById(offId);
            a[0].Status = ChatListSubItem.UserStatus.OffLine;
        }

        public void onlineUser(int onlineId)
        {
            ChatListSubItem[] b;
            b = chatListBox1.GetSubItemsById(onlineId);
            b[0].Status = ChatListSubItem.UserStatus.Online;
        }

        public bool isOnline(int userid)
        {
            ChatListSubItem[] c;
            c = chatListBox1.GetSubItemsById(userid);
            if (c[0].Status == ChatListSubItem.UserStatus.Online)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void chatListBox1_Click(object sender, EventArgs e)
        {/*
            if (NetSet.IsFirstLogin == true)
            {
                for (int i = 0; i < chatListBox1.Items[0].SubItems.Count; i++)
                {
                    chatListBox1.Items[0].SubItems[0].Status = ChatListSubItem.UserStatus.OffLine;
                }
                NetSet.IsFirstLogin = false;
            }

            NetSet.IsReady = true;*/

        }

        private void chatListBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
