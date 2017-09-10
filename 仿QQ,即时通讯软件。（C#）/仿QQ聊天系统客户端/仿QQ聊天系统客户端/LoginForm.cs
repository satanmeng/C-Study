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
    public partial class LoginForm : Form
    {
        Boolean textboxIdHasText = false; //判断输入框是否有文本
        Boolean textboxPwdHasText = false;

        Net net = new Net();
        


        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void txtLoginId_Enter(object sender, EventArgs e)
        {
            if (textboxIdHasText == false)
                txtLoginId.Text = "";
            txtLoginId.ForeColor = Color.Black;
        }

        private void LoginForm_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtLoginPwd_Leave(object sender, EventArgs e)
        {
           if (txtLoginPwd.Text == "")
            {
                txtLoginPwd.PasswordChar = '\0';
                txtLoginPwd.Text = "密码";
                txtLoginPwd.ForeColor = Color.Gray;
                textboxPwdHasText = false;
            }
            else
                textboxPwdHasText = true;
        }

        private void txtLoginId_Leave(object sender, EventArgs e)
        {
            if (txtLoginId.Text == "")
            {
                txtLoginId.Text = "QQ号";
                txtLoginId.ForeColor = Color.Gray;
                textboxIdHasText = false;
            }
            else
                textboxIdHasText = true;
        }

        private void txtLoginPwd_Enter(object sender, EventArgs e)
        {
            if (textboxPwdHasText == false)
                txtLoginPwd.Text = "";
            txtLoginPwd.ForeColor = Color.Black;
            txtLoginPwd.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 用户输入验证
        private bool ValidateInput()
        {
            // 验证用户输入
            if (txtLoginId.ForeColor==Color.Gray)
            {
                MessageBox.Show("请输入登录的号码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginId.Focus();
                return false;
            }
            else if (txtLoginPwd.Text.Trim() == "密码")
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwd.Focus();
                return false;
            }
            return true;
        }

        public void llblRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {

            // 如果输入验证成功，就验证身份，并转到相应的窗体
            if (ValidateInput())
            {              
                try
                {
                    MyQQDBDataContext linq = new MyQQDBDataContext();
                    var result = from sqlData in linq.Users
                                 where (sqlData.Id == int.Parse(txtLoginId.Text.Trim()) && sqlData.LoginPwd == txtLoginPwd.Text.Trim())
                                 select sqlData;
                    if (result.Count()!=0)  // 验证通过
                    {
                        UserHelper.loginId = int.Parse(txtLoginId.Text.Trim());
                        MainForm mainform = new MainForm();
                        net.StartConnect();
                        mainform.Show();
                        this.Visible = false;  // 当前窗体不可见
                        foreach (Users user in result)
                        {
                            UserHelper.loginName = user.NickName;
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入的用户名或密码有误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }               
            }

        }
    }
}
