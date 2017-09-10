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
    public partial class FacesForm : Form
    {
        public MainForm mainform;
        public PersonalInfoForm personal;
        public FacesForm()
        {
            InitializeComponent();
        }

        private void FacesForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ilFaces.Images.Count; i++)
            {
                lvFaces.Items.Add(i.ToString());
                lvFaces.Items[i].ImageIndex = i;
            }  
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lvFaces.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一个头像！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int faceId = lvFaces.SelectedItems[0].ImageIndex;  // 获得当前选中的头像的索引
                MyQQDBDataContext linq = new MyQQDBDataContext();
                var Result = from sqlData in linq.Users
                                 where sqlData.Id == UserHelper.loginId
                                 select sqlData;
                foreach (Users user in Result)
                {
                    user.FaceId= faceId;
                }

                
                try
                {
                    linq.SubmitChanges();
                    mainform.ShowFace(faceId);
                    personal.ShowFace(faceId);
                    this.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("服务器出现以外错误！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
    }
}
