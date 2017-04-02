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
    public partial class zhuandao : Form
    {
        private RichTextBox rtb = new RichTextBox();
        public zhuandao()
        {
            InitializeComponent();
        }

        private void zhuandao_Load(object sender, EventArgs e)
        {
            Form1 main = (Form1)this.Owner;
            this.rtb = main.richTextBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string i = textBox1.Text.ToString();
            int a = 0;
            if (int.TryParse(i, out a) == false) //判断是否可以转换为整型 

            {
                MessageBox.Show("只能接收数字", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = int.Parse(textBox1.Text);
            int pos = 0;
            string[] str = rtb.Text.Split('\r', '\n');

            if (row < 1 || row > str.Length)
                MessageBox.Show("行数超出范围", "记事本 - 跳行", MessageBoxButtons.OK);
            else
            {
                for (int i = 1; i < row; i++)
                    pos = pos + str[i - 1].Length + 1;
                this.Close();
                rtb.Focus();
                rtb.SelectionStart = pos;
            }
        }
    }
}
