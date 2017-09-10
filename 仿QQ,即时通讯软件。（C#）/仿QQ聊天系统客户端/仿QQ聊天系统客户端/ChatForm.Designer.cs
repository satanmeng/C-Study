namespace 仿QQ聊天系统客户端
{
    partial class ChatForm
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
            this.FriendRtb = new System.Windows.Forms.RichTextBox();
            this.myselfRtb = new System.Windows.Forms.RichTextBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FriendRtb
            // 
            this.FriendRtb.Location = new System.Drawing.Point(12, 12);
            this.FriendRtb.Name = "FriendRtb";
            this.FriendRtb.Size = new System.Drawing.Size(601, 233);
            this.FriendRtb.TabIndex = 0;
            this.FriendRtb.Text = "";
            // 
            // myselfRtb
            // 
            this.myselfRtb.Location = new System.Drawing.Point(12, 264);
            this.myselfRtb.Name = "myselfRtb";
            this.myselfRtb.Size = new System.Drawing.Size(601, 163);
            this.myselfRtb.TabIndex = 1;
            this.myselfRtb.Text = "";
            // 
            // Sendbtn
            // 
            this.Sendbtn.BackColor = System.Drawing.Color.Transparent;
            this.Sendbtn.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.Sendbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sendbtn.FlatAppearance.BorderSize = 0;
            this.Sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sendbtn.Location = new System.Drawing.Point(526, 443);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(87, 39);
            this.Sendbtn.TabIndex = 6;
            this.Sendbtn.Text = "发送";
            this.Sendbtn.UseVisualStyleBackColor = false;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.RegistFormBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 494);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.myselfRtb);
            this.Controls.Add(this.FriendRtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FriendRtb;
        private System.Windows.Forms.RichTextBox myselfRtb;
        private System.Windows.Forms.Button Sendbtn;
    }
}