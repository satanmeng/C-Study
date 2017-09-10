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
    public partial class UserControl3 : UserControl
    {
        public UserControl3 usercontrol3;
        public UserControl4 usercontrol4;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usercontrol3 = new UserControl3();
            usercontrol4 = new UserControl4();
            usercontrol4.Show();
            this.treeView1.Controls.Add(usercontrol4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usercontrol3 = new UserControl3();
            usercontrol3.treeView1.Show();
            this.treeView1.Controls.Clear();
        }
    }
}
