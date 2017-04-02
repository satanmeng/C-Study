using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Edit
{
    public partial class Form1 : Form
    {
        bool save = false;//记录当前文档是否已经保存

        public Form1()
        {
            InitializeComponent();
        }

        private void 格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查找下一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Owner = this;
            search.Show();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (save == false)
                {
                    DialogResult result = MessageBox.Show("文件已更改。\n\n想保存文件吗？", "记事本",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            this.Text = "未定标题-记事本";
                            richTextBox1.Clear();
                        }
                    }
                    if (result == DialogResult.No)
                    {
                        this.Text = "未定标题-记事本";
                        richTextBox1.Clear();
                    }
                }
                else
                {
                    this.Text = "未定标题-记事本";
                    richTextBox1.Clear();
                }
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                
                try
                {
                    this.Text = Path.GetFileName(file);//更改当前窗口的标题
                    string text = File.ReadAllText(file);
                    richTextBox1.Text = text;      //将找到的文件内容放入当前的窗体中
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save = true;
            string filename1 = openFileDialog1.FileName;
            if (this.Text != "未定标题-记事本")
            {
                richTextBox1.SaveFile(filename1, RichTextBoxStreamType.PlainText);
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename2 = saveFileDialog1.FileName;
                richTextBox1.SaveFile(filename2, RichTextBoxStreamType.PlainText);
                this.Text = Path.GetFileName(filename2);
    
            }
        }


        private void 查看帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aForm = new AboutBox1();
            aForm.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (save == false)
                {
                    DialogResult result = MessageBox.Show("文件已更改。\n\n想保存文件吗？", "记事本",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    if (result == DialogResult.No)
                    {
                    }
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Alignment = ToolStripItemAlignment.Right;
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                this.Text = Path.GetFileName(filename);
            }
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string none_str = richTextBox1.SelectedText;
            if (none_str.Equals(""))
                return;
            Clipboard.Clear();//清除剪切板中的内容
            richTextBox1.Cut();
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.GetFirstCharIndexOfCurrentLine();
            int line = richTextBox1.GetLineFromCharIndex(index) + 1;
            int column = richTextBox1.SelectionStart - index + 1;
            this.toolStripStatusLabel2.Text = string.Format("第{0}行 第{1}列", line.ToString(), column.ToString());

        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Owner = this;
            search.Show();
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Checked)
            {
                自动换行ToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
            else
            {
                自动换行ToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
        }

        private void 页面设计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();        
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string copychar = Clipboard.GetText();
            if (copychar.Equals(""))
                return;
            richTextBox1.SelectedText = copychar;
        }

        private void 时间日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time;
            time = (System.DateTime.Now).ToString();
            richTextBox1.SelectedText = time;
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (状态栏ToolStripMenuItem.Checked)
            {
                状态栏ToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
            else
            {
                状态栏ToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString() + "      ";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.GetFirstCharIndexOfCurrentLine();
            int line = richTextBox1.GetLineFromCharIndex(index) + 1;
            int column = richTextBox1.SelectionStart - index + 1;
            this.toolStripStatusLabel2.Text = string.Format("第{0}行 第{1}列", line.ToString(), column.ToString());
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change change = new change();
            change.Owner = this;
            change.Show();
        }

        private void 转到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhuandao gt = new zhuandao();
            gt.Owner = this;
            gt.Show();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 全选ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 撤销ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                this.richTextBox1.Undo();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void contextMenuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
                
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    剪切TToolStripMenuItem.Enabled = true;
                    复制CToolStripMenuItem.Enabled = true;
                    删除DToolStripMenuItem.Enabled = true;
                }
                else
                {
                    剪切TToolStripMenuItem.Enabled = false;
                    复制CToolStripMenuItem.Enabled = false;
                    删除DToolStripMenuItem.Enabled = false;
                }

                if(richTextBox1.Text!="")
                    全选ToolStripMenuItem1.Enabled = true;
                else
                    全选ToolStripMenuItem1.Enabled = false;

                if (richTextBox1.CanUndo)
                    撤销ToolStripMenuItem1.Enabled = true;
                else
                    撤销ToolStripMenuItem1.Enabled = false;

                if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                    粘贴PToolStripMenuItem.Enabled = true;
                else
                    粘贴PToolStripMenuItem.Enabled = false;
            }       
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                复制ToolStripMenuItem.Enabled = true;
                剪切ToolStripMenuItem.Enabled = true;
                删除ToolStripMenuItem.Enabled = true;
            }
            else
            {
                复制ToolStripMenuItem.Enabled = false;
                剪切ToolStripMenuItem.Enabled = false;
                删除ToolStripMenuItem.Enabled = false;
            }
        }

        private void 编辑ToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == true)
                撤销ToolStripMenuItem.Enabled = true;
            else
                撤销ToolStripMenuItem.Enabled = false;

            if (richTextBox1.Text != "")
            {
                查找ToolStripMenuItem.Enabled = true;
                查找下一个ToolStripMenuItem.Enabled = true;
                全选ToolStripMenuItem1.Enabled = true;
            }
            else
            {
                查找ToolStripMenuItem.Enabled = false;
                查找下一个ToolStripMenuItem.Enabled = false;
                全选ToolStripMenuItem1.Enabled = false;
            }

            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                粘贴ToolStripMenuItem.Enabled = true;
            else
                粘贴ToolStripMenuItem.Enabled = false;

            if (richTextBox1.Lines.Length>1)
                转到ToolStripMenuItem.Enabled = true;
            else
                转到ToolStripMenuItem.Enabled = false;
        }
    }
}
