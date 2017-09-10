namespace 仿QQ聊天系统客户端
{
    partial class RegisterForm
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtLoginPwdAgain = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.lblLoginPwdAgain = new System.Windows.Forms.Label();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cboBloodType = new System.Windows.Forms.ComboBox();
            this.cboStar = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpBaseInfo.SuspendLayout();
            this.pnlSex.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::仿QQ聊天系统客户端.Properties.Resources.RegistForm;
            this.picLogo.Location = new System.Drawing.Point(12, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(95, 505);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // grpBaseInfo
            // 
            this.grpBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseInfo.Controls.Add(this.txtLoginPwdAgain);
            this.grpBaseInfo.Controls.Add(this.txtLoginPwd);
            this.grpBaseInfo.Controls.Add(this.txtAge);
            this.grpBaseInfo.Controls.Add(this.txtNickName);
            this.grpBaseInfo.Controls.Add(this.lblLoginPwdAgain);
            this.grpBaseInfo.Controls.Add(this.lblLoginPwd);
            this.grpBaseInfo.Controls.Add(this.pnlSex);
            this.grpBaseInfo.Controls.Add(this.lblSex);
            this.grpBaseInfo.Controls.Add(this.lblAge);
            this.grpBaseInfo.Controls.Add(this.lblNickName);
            this.grpBaseInfo.Location = new System.Drawing.Point(171, 25);
            this.grpBaseInfo.Name = "grpBaseInfo";
            this.grpBaseInfo.Size = new System.Drawing.Size(374, 271);
            this.grpBaseInfo.TabIndex = 1;
            this.grpBaseInfo.TabStop = false;
            this.grpBaseInfo.Text = "注册基本资料";
            // 
            // txtLoginPwdAgain
            // 
            this.txtLoginPwdAgain.Location = new System.Drawing.Point(123, 214);
            this.txtLoginPwdAgain.Name = "txtLoginPwdAgain";
            this.txtLoginPwdAgain.PasswordChar = '*';
            this.txtLoginPwdAgain.Size = new System.Drawing.Size(211, 28);
            this.txtLoginPwdAgain.TabIndex = 9;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(123, 172);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(211, 28);
            this.txtLoginPwd.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(123, 84);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(61, 28);
            this.txtAge.TabIndex = 7;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(123, 39);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(211, 28);
            this.txtNickName.TabIndex = 6;
            // 
            // lblLoginPwdAgain
            // 
            this.lblLoginPwdAgain.AutoSize = true;
            this.lblLoginPwdAgain.Location = new System.Drawing.Point(34, 220);
            this.lblLoginPwdAgain.Name = "lblLoginPwdAgain";
            this.lblLoginPwdAgain.Size = new System.Drawing.Size(80, 18);
            this.lblLoginPwdAgain.TabIndex = 5;
            this.lblLoginPwdAgain.Text = "重复密码";
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(70, 178);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(44, 18);
            this.lblLoginPwd.TabIndex = 4;
            this.lblLoginPwd.Text = "密码";
            // 
            // pnlSex
            // 
            this.pnlSex.Controls.Add(this.rdoFemale);
            this.pnlSex.Controls.Add(this.rdoMale);
            this.pnlSex.Location = new System.Drawing.Point(123, 122);
            this.pnlSex.Name = "pnlSex";
            this.pnlSex.Size = new System.Drawing.Size(200, 35);
            this.pnlSex.TabIndex = 3;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(82, 8);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(51, 22);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 6);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(51, 22);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(70, 130);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(44, 18);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "性别";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(70, 90);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(44, 18);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "年龄";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(70, 45);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(44, 18);
            this.lblNickName.TabIndex = 0;
            this.lblNickName.Text = "昵称";
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.cboBloodType);
            this.grpDetails.Controls.Add(this.cboStar);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblBloodType);
            this.grpDetails.Controls.Add(this.lblStar);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Location = new System.Drawing.Point(171, 338);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(374, 192);
            this.grpDetails.TabIndex = 2;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "选填详细资料";
            // 
            // cboBloodType
            // 
            this.cboBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBloodType.FormattingEnabled = true;
            this.cboBloodType.Location = new System.Drawing.Point(123, 120);
            this.cboBloodType.Name = "cboBloodType";
            this.cboBloodType.Size = new System.Drawing.Size(211, 26);
            this.cboBloodType.TabIndex = 5;
            // 
            // cboStar
            // 
            this.cboStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStar.FormattingEnabled = true;
            this.cboStar.Location = new System.Drawing.Point(123, 75);
            this.cboStar.Name = "cboStar";
            this.cboStar.Size = new System.Drawing.Size(211, 26);
            this.cboStar.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 28);
            this.txtName.TabIndex = 3;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(70, 123);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(44, 18);
            this.lblBloodType.TabIndex = 2;
            this.lblBloodType.Text = "血型";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(70, 81);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(44, 18);
            this.lblStar.TabIndex = 1;
            this.lblStar.Text = "星座";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "真实姓名";
            // 
            // btnRegist
            // 
            this.btnRegist.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.btnRegist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegist.FlatAppearance.BorderSize = 0;
            this.btnRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegist.Location = new System.Drawing.Point(352, 553);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 40);
            this.btnRegist.TabIndex = 3;
            this.btnRegist.Text = "注册";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(470, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.RegistFormBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 605);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpBaseInfo);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RegisterForm";
            this.Text = "申请号码";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpBaseInfo.ResumeLayout(false);
            this.grpBaseInfo.PerformLayout();
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpBaseInfo;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.TextBox txtLoginPwdAgain;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label lblLoginPwdAgain;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ComboBox cboBloodType;
        private System.Windows.Forms.ComboBox cboStar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnCancel;
    }
}