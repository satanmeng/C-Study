using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edit
{
    public partial class Search : Form
    {
        private RichTextBox rtb = new RichTextBox();
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
           Form1 form1 = (Form1)this.Owner;
            this.rtb = form1.richTextBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = rtb.Text;//文件内容
            string subSearch = textBox1.Text;//查找内容
            string initString = subSearch;
            int pos = rtb.SelectionStart;//光标位置

            if (!checkBox1.Checked)
            {
                str = str.ToLower();
                subSearch = subSearch.ToLower();
            }

            if (radioButton1.Checked)//向上查找
            {
                if (rtb.SelectionLength > 0)
                    pos = pos + rtb.SelectionLength - 1;

                str = str.Substring(0, pos);
                if (subSearch != "" && (pos = str.LastIndexOf(subSearch, pos)) != -1)
                {
                    //输入框得到焦点并选中查找的内容
                    rtb.Focus();
                    rtb.SelectionStart = pos;
                    rtb.SelectionLength = subSearch.Length;
                }
                else
                    MessageBox.Show("找不到\"" + initString + "\"", "记事本",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rtb.SelectionLength > 0)
                    pos = pos + 1;
                if (subSearch != "" && (pos = str.IndexOf(subSearch, pos)) != -1)
                {
                    rtb.Focus();
                    rtb.SelectionStart = pos;
                    rtb.SelectionLength = subSearch.Length;
                }
                else
                    MessageBox.Show("找不到\"" + subSearch + "\"", "记事本",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
