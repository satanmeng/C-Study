namespace 仿QQ聊天系统客户端
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.清空会话列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.头像显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名称显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.显示黑名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.ilFace = new System.Windows.Forms.ImageList(this.components);
            this.signLabel1 = new 仿QQ聊天系统客户端.SignLabel();
            this.nickname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(0, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(702, 573);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 0);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 68);
            this.panel1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(702, 50);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空会话列表ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 30);
            this.toolStripDropDownButton1.Text = "会话";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // 清空会话列表ToolStripMenuItem
            // 
            this.清空会话列表ToolStripMenuItem.Name = "清空会话列表ToolStripMenuItem";
            this.清空会话列表ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.清空会话列表ToolStripMenuItem.Text = "清空会话列表";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.AutoSize = false;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.头像显示ToolStripMenuItem,
            this.名称显示ToolStripMenuItem,
            this.列表显示ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.显示黑名单ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(70, 30);
            this.toolStripSplitButton1.Text = "联系人";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // 头像显示ToolStripMenuItem
            // 
            this.头像显示ToolStripMenuItem.Name = "头像显示ToolStripMenuItem";
            this.头像显示ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.头像显示ToolStripMenuItem.Text = "头像显示";
            // 
            // 名称显示ToolStripMenuItem
            // 
            this.名称显示ToolStripMenuItem.Name = "名称显示ToolStripMenuItem";
            this.名称显示ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.名称显示ToolStripMenuItem.Text = "名称显示";
            // 
            // 列表显示ToolStripMenuItem
            // 
            this.列表显示ToolStripMenuItem.Name = "列表显示ToolStripMenuItem";
            this.列表显示ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.列表显示ToolStripMenuItem.Text = "列表显示";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // 显示黑名单ToolStripMenuItem
            // 
            this.显示黑名单ToolStripMenuItem.Name = "显示黑名单ToolStripMenuItem";
            this.显示黑名单ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.显示黑名单ToolStripMenuItem.Text = "显示黑名单";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.AutoSize = false;
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(70, 30);
            this.toolStripSplitButton2.Text = "群聊";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 766);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(699, 28);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 25);
            this.toolStripButton1.Text = "主页";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(100, 25);
            this.toolStripButton2.Text = "QQ游戏";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 25);
            this.toolStripButton3.Text = "QQ空间";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(100, 25);
            this.toolStripButton4.Text = "QQ音乐";
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(13, 14);
            this.picFace.Margin = new System.Windows.Forms.Padding(4);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(82, 58);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFace.TabIndex = 10;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // ilFace
            // 
            this.ilFace.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFace.ImageStream")));
            this.ilFace.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFace.Images.SetKeyName(0, "1.bmp");
            this.ilFace.Images.SetKeyName(1, "2.bmp");
            this.ilFace.Images.SetKeyName(2, "3.bmp");
            this.ilFace.Images.SetKeyName(3, "4.bmp");
            this.ilFace.Images.SetKeyName(4, "5.bmp");
            this.ilFace.Images.SetKeyName(5, "6.bmp");
            this.ilFace.Images.SetKeyName(6, "7.bmp");
            this.ilFace.Images.SetKeyName(7, "8.bmp");
            this.ilFace.Images.SetKeyName(8, "9.bmp");
            this.ilFace.Images.SetKeyName(9, "10.bmp");
            this.ilFace.Images.SetKeyName(10, "11.bmp");
            this.ilFace.Images.SetKeyName(11, "12.bmp");
            this.ilFace.Images.SetKeyName(12, "13.bmp");
            this.ilFace.Images.SetKeyName(13, "14.bmp");
            this.ilFace.Images.SetKeyName(14, "15.bmp");
            this.ilFace.Images.SetKeyName(15, "16.bmp");
            this.ilFace.Images.SetKeyName(16, "17.bmp");
            this.ilFace.Images.SetKeyName(17, "18.bmp");
            this.ilFace.Images.SetKeyName(18, "19.bmp");
            this.ilFace.Images.SetKeyName(19, "20.bmp");
            this.ilFace.Images.SetKeyName(20, "21.bmp");
            this.ilFace.Images.SetKeyName(21, "22.bmp");
            this.ilFace.Images.SetKeyName(22, "23.bmp");
            this.ilFace.Images.SetKeyName(23, "24.bmp");
            this.ilFace.Images.SetKeyName(24, "25.bmp");
            this.ilFace.Images.SetKeyName(25, "26.bmp");
            this.ilFace.Images.SetKeyName(26, "27.bmp");
            this.ilFace.Images.SetKeyName(27, "28.bmp");
            this.ilFace.Images.SetKeyName(28, "29.bmp");
            this.ilFace.Images.SetKeyName(29, "30.bmp");
            this.ilFace.Images.SetKeyName(30, "31.bmp");
            this.ilFace.Images.SetKeyName(31, "32.bmp");
            this.ilFace.Images.SetKeyName(32, "33.bmp");
            this.ilFace.Images.SetKeyName(33, "34.bmp");
            this.ilFace.Images.SetKeyName(34, "35.bmp");
            this.ilFace.Images.SetKeyName(35, "36.bmp");
            this.ilFace.Images.SetKeyName(36, "37.bmp");
            this.ilFace.Images.SetKeyName(37, "38.bmp");
            this.ilFace.Images.SetKeyName(38, "39.bmp");
            this.ilFace.Images.SetKeyName(39, "40.bmp");
            this.ilFace.Images.SetKeyName(40, "41.bmp");
            this.ilFace.Images.SetKeyName(41, "42.bmp");
            this.ilFace.Images.SetKeyName(42, "43.bmp");
            this.ilFace.Images.SetKeyName(43, "44.bmp");
            this.ilFace.Images.SetKeyName(44, "45.bmp");
            this.ilFace.Images.SetKeyName(45, "46.bmp");
            this.ilFace.Images.SetKeyName(46, "47.bmp");
            this.ilFace.Images.SetKeyName(47, "48.bmp");
            this.ilFace.Images.SetKeyName(48, "49.bmp");
            this.ilFace.Images.SetKeyName(49, "50.bmp");
            this.ilFace.Images.SetKeyName(50, "51.bmp");
            this.ilFace.Images.SetKeyName(51, "52.bmp");
            this.ilFace.Images.SetKeyName(52, "53.bmp");
            this.ilFace.Images.SetKeyName(53, "54.bmp");
            this.ilFace.Images.SetKeyName(54, "55.bmp");
            this.ilFace.Images.SetKeyName(55, "56.bmp");
            this.ilFace.Images.SetKeyName(56, "57.bmp");
            this.ilFace.Images.SetKeyName(57, "58.bmp");
            this.ilFace.Images.SetKeyName(58, "59.bmp");
            this.ilFace.Images.SetKeyName(59, "60.bmp");
            this.ilFace.Images.SetKeyName(60, "61.bmp");
            this.ilFace.Images.SetKeyName(61, "62.bmp");
            this.ilFace.Images.SetKeyName(62, "63.bmp");
            this.ilFace.Images.SetKeyName(63, "64.bmp");
            this.ilFace.Images.SetKeyName(64, "65.bmp");
            this.ilFace.Images.SetKeyName(65, "66.bmp");
            this.ilFace.Images.SetKeyName(66, "67.bmp");
            this.ilFace.Images.SetKeyName(67, "68.bmp");
            this.ilFace.Images.SetKeyName(68, "69.bmp");
            this.ilFace.Images.SetKeyName(69, "70.bmp");
            this.ilFace.Images.SetKeyName(70, "71.bmp");
            this.ilFace.Images.SetKeyName(71, "72.bmp");
            this.ilFace.Images.SetKeyName(72, "73.bmp");
            this.ilFace.Images.SetKeyName(73, "74.bmp");
            this.ilFace.Images.SetKeyName(74, "75.bmp");
            this.ilFace.Images.SetKeyName(75, "76.bmp");
            this.ilFace.Images.SetKeyName(76, "77.bmp");
            this.ilFace.Images.SetKeyName(77, "78.bmp");
            this.ilFace.Images.SetKeyName(78, "79.bmp");
            this.ilFace.Images.SetKeyName(79, "80.bmp");
            this.ilFace.Images.SetKeyName(80, "81.bmp");
            this.ilFace.Images.SetKeyName(81, "82.bmp");
            this.ilFace.Images.SetKeyName(82, "83.bmp");
            this.ilFace.Images.SetKeyName(83, "84.bmp");
            this.ilFace.Images.SetKeyName(84, "85.bmp");
            this.ilFace.Images.SetKeyName(85, "86.bmp");
            this.ilFace.Images.SetKeyName(86, "87.bmp");
            this.ilFace.Images.SetKeyName(87, "88.bmp");
            this.ilFace.Images.SetKeyName(88, "89.bmp");
            this.ilFace.Images.SetKeyName(89, "90.bmp");
            this.ilFace.Images.SetKeyName(90, "91.bmp");
            this.ilFace.Images.SetKeyName(91, "92.bmp");
            this.ilFace.Images.SetKeyName(92, "93.bmp");
            this.ilFace.Images.SetKeyName(93, "94.bmp");
            this.ilFace.Images.SetKeyName(94, "95.bmp");
            this.ilFace.Images.SetKeyName(95, "96.bmp");
            this.ilFace.Images.SetKeyName(96, "97.bmp");
            this.ilFace.Images.SetKeyName(97, "98.bmp");
            this.ilFace.Images.SetKeyName(98, "99.bmp");
            this.ilFace.Images.SetKeyName(99, "100.bmp");
            // 
            // signLabel1
            // 
            this.signLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.signLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.signLabel1.Location = new System.Drawing.Point(158, 45);
            this.signLabel1.Name = "signLabel1";
            this.signLabel1.Size = new System.Drawing.Size(243, 27);
            this.signLabel1.TabIndex = 11;
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Location = new System.Drawing.Point(155, 14);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(0, 18);
            this.nickname.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(699, 794);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.signLabel1);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 清空会话列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 头像显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名称显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 显示黑名单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.ImageList ilFace;
        private SignLabel signLabel1;
        private System.Windows.Forms.Label nickname;
    }
}