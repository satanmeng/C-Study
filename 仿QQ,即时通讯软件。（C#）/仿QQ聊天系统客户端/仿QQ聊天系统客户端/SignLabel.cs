using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿QQ聊天系统客户端
{
    public partial class SignLabel : UserControl
    {
        private Label _lbl;
        private TextBox _txt;


        public SignLabel()
        {
            _lbl = new Label();
            _lbl.Dock = DockStyle.Fill;
            _lbl.Click += LableClick;
            _lbl.Visible = true;

            _txt = new TextBox();
            _txt.Dock = DockStyle.Fill;
            _txt.KeyUp += TextboxKeyUp;
            _txt.Visible = false;
            _txt.BorderStyle = BorderStyle.None;

            this.Controls.Add(_lbl);
            this.Controls.Add(_txt);
        }

        //显示文本框
        public void textbox(bool edit)
        {
            if (edit == true)
            {
                _lbl.Visible = false;
                _txt.Visible = true;
                _txt.Text = _lbl.Text;
                _txt.Focus();
            }
        }

        //显示标签
        public void label(bool save)
        {
            if (save == true)
            {
                _lbl.Visible = true;
                _txt.Visible = false;
                _lbl.Text = _txt.Text;
            }
        }

        public void setText(String text)
        {
            _lbl.Text = text;
        }

        public string getText()
        {
            return _txt.Text.Trim();
        }
        private void LableClick(object sender, EventArgs e)
        {
            _lbl.Visible = false;
            _txt.Visible = true;
            _txt.Text = _lbl.Text;
            _txt.Focus();
        }
 
        private void TextboxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _lbl.Visible = true;
                _txt.Visible = false;
                _lbl.Text = _txt.Text;
                MyQQDBDataContext linq = new MyQQDBDataContext();
                var Result = from sqlData in linq.Users
                             where sqlData.Id == UserHelper.loginId
                             select sqlData;

                foreach (Users user in Result)
                {
                    user.personalmsg = _lbl.Text;
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
