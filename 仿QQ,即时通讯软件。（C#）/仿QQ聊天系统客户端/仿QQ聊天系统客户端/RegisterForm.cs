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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 窗体加载时，添加星座和血型组合框中的项
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 添加星座组合框中的项 
                MyQQDBDataContext linq = new MyQQDBDataContext();
                var StarResult = from sqlData in linq.Star
                                 select new
                                 {
                                     sqlData.Id,
                                     sqlData.Star1
                                 };
                cboStar.DisplayMember = "Star1";
                cboStar.ValueMember = "Id";
                cboStar.DataSource = StarResult;

                // 添加血型组合框中的项
                var BloodTypeResult = from sqlData in linq.BloodType
                                      select new
                                      {
                                          sqlData.Id,
                                          sqlData.BloodType1
                                      };
                cboBloodType.DisplayMember = "BloodType1";
                cboBloodType.ValueMember = "Id";
                cboBloodType.DataSource = BloodTypeResult;
            }
            catch (Exception a)
            {
                MessageBox.Show("服务器出现以外错误！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 验证用户的输入
        private bool ValidateInput()
        {
            if (txtNickName.Text.Trim() == "")
            {
                MessageBox.Show("请输入昵称！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return false;
            }
            if (txtAge.Text.Trim() == "")
            {
                MessageBox.Show("请输入年龄！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("请选择性别！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSex.Focus();
                return false;
            }
            if (txtLoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwd.Focus();
                return false;
            }
            if (txtLoginPwdAgain.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwdAgain.Focus();
                return false;
            }
            if (txtLoginPwd.Text.Trim() != txtLoginPwdAgain.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一样！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwdAgain.Focus();
                return false;
            }
            return true;
        }

        // 点击注册，向数据库添加记录
        private void btnRegist_Click(object sender, EventArgs e)
        {
            // 输入验证通过，就插入记录到数据库
            if (ValidateInput())
            {
                int StarId = cboStar.SelectedIndex+1;
                int BloodTypeId = cboBloodType.SelectedIndex+1;
                MyQQDBDataContext linq = new MyQQDBDataContext();
                Users users = new Users();
                users.NickName = txtNickName.Text.Trim();
                users.Age = int.Parse(txtAge.Text.Trim());
                users.Sex = rdoMale.Checked ? rdoMale.Text : rdoFemale.Text;
                users.LoginPwd = txtLoginPwd.Text.Trim();
                users.Name = txtName.Text.Trim();
                users.StarId = StarId;
                users.BloodTypeId = BloodTypeId;
                users.FaceId = 0;
                users.FriendshipPolicyId = 1;
                users.Id = 10000;
                try
                {
                    linq.Users.InsertOnSubmit(users);
                    linq.SubmitChanges();
                    int id = users.Id;
                    MessageBox.Show("注册成功！你的MyQQ号码是"+id, "消息", MessageBoxButtons.OK);
                }
                catch (Exception b)
                {
                    MessageBox.Show("注册失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        
    }
}
