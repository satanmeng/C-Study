using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using System.Reflection;



namespace 仿QQ聊天系统客户端
{
    public partial class MainForm : Form
    {
        public UserControl1 usercontorl1;
        public UserControl2 usercontorl2;
        public UserControl3 usercontorl3;
        public Friendbox friendbox;
        public int i = 0;
        public int[] friendnum;
        public string sign;
        Net net = new Net();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            /*  Panel parent = new Panel();
              //parent.ID = "ParentPanel";
              for (int i = 0; i < 5; i++)
              {
                  Panel p = new Panel();
              //    p.ID = "Panel" + i.ToString();
                 this.Controls.Add(p);//或者是parent.ChildControls.Add(p);
              }
             // XXX.Controls.Add(parent);//或者XXX.ChildControls.Add(parent);
             
            Form3 form3 = new Form3();
            form3.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框（去除最小花，最大化，关闭等按钮）
            form3.TopLevel = false; //指示子窗体非顶级窗体
            this.panel1.Controls.Add(form3);//将子窗体载入panel
            Form2 form = new Form2();
            form.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框（去除最小花，最大化，关闭等按钮）
            form.TopLevel = false; //指示子窗体非顶级窗体
            this.panel1.Controls.Add(form);//将子窗体载入panel
            switch (i)
                      form.Hide();
            {
                case 1:form3.Show();
                       break;
                case 2:form.Show();
                       form3.Hide();
                       break;
            }*/

            //net.StartReceive();
            usercontorl1 = new UserControl1();
            friendbox = new Friendbox();
            //usercontorl2 = new UserControl2();
            usercontorl3 = new UserControl3();
            //usercontrol4 = new UserControl4();

            MyQQDBDataContext linq = new MyQQDBDataContext();
            var Result = from sqlData in linq.Users
                         where sqlData.Id == UserHelper.loginId
                         select sqlData;
            foreach (Users user in Result)
            {
                picFace.Image = ilFace.Images[user.FaceId];
                picFace.Tag = user.FaceId;
                signLabel1.setText(user.personalmsg);
                nickname.Text = user.NickName;
            }

            /*var FriendResult = from sqlData in linq.Friends
                               where sqlData.HostId == UserHelper.loginId
                               select sqlData;
            foreach (Friends f in FriendResult)
            {
                friendnum[i] = f.FriendId;
                i++;
            }*/

        }

   

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            usercontorl1.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(usercontorl1);
            
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            /*usercontorl2.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(usercontorl2);*/
            friendbox.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(friendbox);

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

            usercontorl3.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(usercontorl3);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(picFace.ClientRectangle);

            Region region = new Region(gp);

            picFace.Region = region;

            gp.Dispose();

            region.Dispose();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Net net = new Net();
            net.close();
        }

        private void BtnChangeFace_Click(object sender, EventArgs e)
        {
            FacesForm faceform = new FacesForm();
            faceform.mainform = this;
            faceform.Show();
        }

        
        public void ShowFace(int currentFaceId)
        {
            picFace.Image = ilFace.Images[currentFaceId];
            picFace.Tag = currentFaceId;
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalform = new PersonalInfoForm();
            personalform.mainform = this;
            personalform.Show();
        }
    
    }
}
