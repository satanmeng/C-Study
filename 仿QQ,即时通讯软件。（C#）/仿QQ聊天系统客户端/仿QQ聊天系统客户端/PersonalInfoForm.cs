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
    public partial class PersonalInfoForm : Form
    {
        public PersonalInfoForm()
        {
            InitializeComponent();
        }

        public bool edit = false;

        //信息是否更改
        public bool change = false;

        public MainForm mainform;

        private void btnChangeFace_Click(object sender, EventArgs e)
        {
            FacesForm faceform = new FacesForm();
            faceform.personal = this;
            faceform.mainform = mainform;
            faceform.Show();
        }

        public void ShowFace(int currentFaceId)
        {
            picFace.Image = ilFaces.Images[currentFaceId];
            picFace.Tag = currentFaceId;
        }

        private void PersonalInfoForm_Load(object sender, EventArgs e)
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

                var Result = from sqlData in linq.Users
                             where sqlData.Id == UserHelper.loginId
                             select sqlData;

                foreach (Users user in Result)
                {
                    picFace.Image = ilFaces.Images[user.FaceId];
                    picFace.Tag = user.FaceId;
                    leNickName.setText(user.NickName);
                    leName.setText(user.Name);
                    leSex.setText(user.Sex);
                    leAge.setText(user.Age.ToString());
                    cboStar.SelectedIndex = (int)user.StarId - 1;
                    cboBloodType.SelectedIndex = (int)user.BloodTypeId - 1;
                }
                
            }
            catch (Exception a)
            {
                MessageBox.Show("服务器出现以外错误！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 验证用户的输入
        private bool ValidateInput()
        {
            string MaleSex = "男";
            string FemaleSex = "女";
            if (leNickName.getText() == "")
            {
                MessageBox.Show("请输入昵称！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leNickName.Focus();
                return false;
            }
            if (leAge.getText() == "")
            {
                MessageBox.Show("请输入年龄！" + leAge.getText(), "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leAge.Focus();
                return false;
            }
            
            if (leSex.getText().Trim() != MaleSex && leSex.getText().Trim() != FemaleSex)
            {
                MessageBox.Show("请输入性别！" + leSex.getText(), "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            change = true;
            leName.textbox(edit);
            leSex.textbox(edit);
            leNickName.textbox(edit);
            leAge.textbox(edit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            edit = false;
            if (ValidateInput()&&change==true)
            {
                int StarId = cboStar.SelectedIndex+1;
                int BloodTypeId = cboBloodType.SelectedIndex+1;
                MyQQDBDataContext linq = new MyQQDBDataContext();
                var Result = from sqlData in linq.Users
                             where sqlData.Id == UserHelper.loginId
                             select sqlData;
                foreach (Users user in Result)
                {
                    user.NickName = leNickName.getText();
                    user.Name = leName.getText();
                    user.Sex = leSex.getText();
                    user.Age = int.Parse(leAge.getText());
                    user.StarId = StarId;
                    user.BloodTypeId = BloodTypeId;
                }
                try
                {
                    linq.SubmitChanges();
                    MessageBox.Show("更改成功", "消息", MessageBoxButtons.OK);
                }
                catch (Exception b)
                {
                    MessageBox.Show("服务器出现以外错误！", "抱歉", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
