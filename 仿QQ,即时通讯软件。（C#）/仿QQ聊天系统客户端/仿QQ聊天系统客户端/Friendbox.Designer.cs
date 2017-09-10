namespace 仿QQ聊天系统客户端
{
    partial class Friendbox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chatListBox1 = new _CUSTOM_CONTROLS.ChatListBox();
            this.SuspendLayout();
            // 
            // chatListBox1
            // 
            this.chatListBox1.BackColor = System.Drawing.Color.White;
            this.chatListBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.chatListBox1.Location = new System.Drawing.Point(3, 0);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.Size = new System.Drawing.Size(700, 571);
            this.chatListBox1.TabIndex = 0;
            this.chatListBox1.Text = "chatListBox1";
            this.chatListBox1.DoubleClickSubItem += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.chatListBox1_DoubleClickSubItem);
            this.chatListBox1.Click += new System.EventHandler(this.chatListBox1_Click);
            this.chatListBox1.Enter += new System.EventHandler(this.chatListBox1_Enter);
            // 
            // Friendbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatListBox1);
            this.Name = "Friendbox";
            this.Size = new System.Drawing.Size(700, 571);
            this.Load += new System.EventHandler(this.Friendbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private _CUSTOM_CONTROLS.ChatListBox chatListBox1;

    }
}
