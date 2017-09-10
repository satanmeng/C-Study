namespace 仿QQ聊天系统客户端
{
    partial class LoginForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.llblRegist = new System.Windows.Forms.LinkLabel();
            this.llblFogetPwd = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginId
            // 
            this.txtLoginId.ForeColor = System.Drawing.Color.Gray;
            this.txtLoginId.Location = new System.Drawing.Point(105, 97);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(176, 28);
            this.txtLoginId.TabIndex = 0;
            this.txtLoginId.Text = "QQ号码";
            this.txtLoginId.Enter += new System.EventHandler(this.txtLoginId_Enter);
            this.txtLoginId.Leave += new System.EventHandler(this.txtLoginId_Leave);
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtLoginPwd.Location = new System.Drawing.Point(105, 154);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(176, 28);
            this.txtLoginPwd.TabIndex = 1;
            this.txtLoginPwd.Text = "密码";
            this.txtLoginPwd.Enter += new System.EventHandler(this.txtLoginPwd_Enter);
            this.txtLoginPwd.Leave += new System.EventHandler(this.txtLoginPwd_Leave);
            // 
            // llblRegist
            // 
            this.llblRegist.ActiveLinkColor = System.Drawing.Color.LightSteelBlue;
            this.llblRegist.AutoSize = true;
            this.llblRegist.BackColor = System.Drawing.Color.Transparent;
            this.llblRegist.LinkColor = System.Drawing.Color.Blue;
            this.llblRegist.Location = new System.Drawing.Point(310, 106);
            this.llblRegist.Name = "llblRegist";
            this.llblRegist.Size = new System.Drawing.Size(80, 18);
            this.llblRegist.TabIndex = 2;
            this.llblRegist.TabStop = true;
            this.llblRegist.Text = "注册账号";
            this.llblRegist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegist_LinkClicked);
            // 
            // llblFogetPwd
            // 
            this.llblFogetPwd.ActiveLinkColor = System.Drawing.Color.LightSteelBlue;
            this.llblFogetPwd.AutoSize = true;
            this.llblFogetPwd.BackColor = System.Drawing.Color.Transparent;
            this.llblFogetPwd.Location = new System.Drawing.Point(310, 164);
            this.llblFogetPwd.Name = "llblFogetPwd";
            this.llblFogetPwd.Size = new System.Drawing.Size(80, 18);
            this.llblFogetPwd.TabIndex = 3;
            this.llblFogetPwd.TabStop = true;
            this.llblFogetPwd.Text = "忘记密码";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(266, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(363, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.登录背景图片1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llblFogetPwd);
            this.Controls.Add(this.llblRegist);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ登录";
            this.Leave += new System.EventHandler(this.LoginForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.LinkLabel llblRegist;
        private System.Windows.Forms.LinkLabel llblFogetPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

