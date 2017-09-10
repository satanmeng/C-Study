namespace 仿QQ聊天系统客户端
{
    partial class PersonalInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfoForm));
            this.picFace = new System.Windows.Forms.PictureBox();
            this.nikeName = new System.Windows.Forms.Label();
            this.lbname1 = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Star = new System.Windows.Forms.Label();
            this.BloodType = new System.Windows.Forms.Label();
            this.btnChangeFace = new System.Windows.Forms.Button();
            this.ilFaces = new System.Windows.Forms.ImageList(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboStar = new System.Windows.Forms.ComboBox();
            this.cboBloodType = new System.Windows.Forms.ComboBox();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.leSex = new 仿QQ聊天系统客户端.LableEdit();
            this.leAge = new 仿QQ聊天系统客户端.LableEdit();
            this.leName = new 仿QQ聊天系统客户端.LableEdit();
            this.leNickName = new 仿QQ聊天系统客户端.LableEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(45, 43);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(95, 79);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFace.TabIndex = 0;
            this.picFace.TabStop = false;
            // 
            // nikeName
            // 
            this.nikeName.AutoSize = true;
            this.nikeName.BackColor = System.Drawing.Color.Transparent;
            this.nikeName.Location = new System.Drawing.Point(228, 32);
            this.nikeName.Name = "nikeName";
            this.nikeName.Size = new System.Drawing.Size(44, 18);
            this.nikeName.TabIndex = 1;
            this.nikeName.Text = "昵称";
            // 
            // lbname1
            // 
            this.lbname1.AutoSize = true;
            this.lbname1.BackColor = System.Drawing.Color.Transparent;
            this.lbname1.Location = new System.Drawing.Point(192, 85);
            this.lbname1.Name = "lbname1";
            this.lbname1.Size = new System.Drawing.Size(80, 18);
            this.lbname1.TabIndex = 3;
            this.lbname1.Text = "真实姓名";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.BackColor = System.Drawing.Color.Transparent;
            this.Sex.Location = new System.Drawing.Point(228, 139);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(44, 18);
            this.Sex.TabIndex = 5;
            this.Sex.Text = "性别";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.Color.Transparent;
            this.Age.Location = new System.Drawing.Point(228, 188);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(44, 18);
            this.Age.TabIndex = 7;
            this.Age.Text = "年龄";
            // 
            // Star
            // 
            this.Star.AutoSize = true;
            this.Star.BackColor = System.Drawing.Color.Transparent;
            this.Star.Location = new System.Drawing.Point(228, 239);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(44, 18);
            this.Star.TabIndex = 9;
            this.Star.Text = "星座";
            // 
            // BloodType
            // 
            this.BloodType.AutoSize = true;
            this.BloodType.BackColor = System.Drawing.Color.Transparent;
            this.BloodType.Location = new System.Drawing.Point(228, 295);
            this.BloodType.Name = "BloodType";
            this.BloodType.Size = new System.Drawing.Size(44, 18);
            this.BloodType.TabIndex = 10;
            this.BloodType.Text = "血型";
            // 
            // btnChangeFace
            // 
            this.btnChangeFace.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeFace.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.btnChangeFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeFace.Location = new System.Drawing.Point(45, 139);
            this.btnChangeFace.Name = "btnChangeFace";
            this.btnChangeFace.Size = new System.Drawing.Size(95, 37);
            this.btnChangeFace.TabIndex = 17;
            this.btnChangeFace.Text = "更改头像";
            this.btnChangeFace.UseVisualStyleBackColor = false;
            this.btnChangeFace.Click += new System.EventHandler(this.btnChangeFace_Click);
            // 
            // ilFaces
            // 
            this.ilFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFaces.ImageStream")));
            this.ilFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFaces.Images.SetKeyName(0, "1.bmp");
            this.ilFaces.Images.SetKeyName(1, "2.bmp");
            this.ilFaces.Images.SetKeyName(2, "3.bmp");
            this.ilFaces.Images.SetKeyName(3, "4.bmp");
            this.ilFaces.Images.SetKeyName(4, "5.bmp");
            this.ilFaces.Images.SetKeyName(5, "6.bmp");
            this.ilFaces.Images.SetKeyName(6, "7.bmp");
            this.ilFaces.Images.SetKeyName(7, "8.bmp");
            this.ilFaces.Images.SetKeyName(8, "9.bmp");
            this.ilFaces.Images.SetKeyName(9, "10.bmp");
            this.ilFaces.Images.SetKeyName(10, "11.bmp");
            this.ilFaces.Images.SetKeyName(11, "12.bmp");
            this.ilFaces.Images.SetKeyName(12, "13.bmp");
            this.ilFaces.Images.SetKeyName(13, "14.bmp");
            this.ilFaces.Images.SetKeyName(14, "15.bmp");
            this.ilFaces.Images.SetKeyName(15, "16.bmp");
            this.ilFaces.Images.SetKeyName(16, "17.bmp");
            this.ilFaces.Images.SetKeyName(17, "18.bmp");
            this.ilFaces.Images.SetKeyName(18, "19.bmp");
            this.ilFaces.Images.SetKeyName(19, "20.bmp");
            this.ilFaces.Images.SetKeyName(20, "21.bmp");
            this.ilFaces.Images.SetKeyName(21, "22.bmp");
            this.ilFaces.Images.SetKeyName(22, "23.bmp");
            this.ilFaces.Images.SetKeyName(23, "24.bmp");
            this.ilFaces.Images.SetKeyName(24, "25.bmp");
            this.ilFaces.Images.SetKeyName(25, "26.bmp");
            this.ilFaces.Images.SetKeyName(26, "27.bmp");
            this.ilFaces.Images.SetKeyName(27, "28.bmp");
            this.ilFaces.Images.SetKeyName(28, "29.bmp");
            this.ilFaces.Images.SetKeyName(29, "30.bmp");
            this.ilFaces.Images.SetKeyName(30, "31.bmp");
            this.ilFaces.Images.SetKeyName(31, "32.bmp");
            this.ilFaces.Images.SetKeyName(32, "33.bmp");
            this.ilFaces.Images.SetKeyName(33, "34.bmp");
            this.ilFaces.Images.SetKeyName(34, "35.bmp");
            this.ilFaces.Images.SetKeyName(35, "36.bmp");
            this.ilFaces.Images.SetKeyName(36, "37.bmp");
            this.ilFaces.Images.SetKeyName(37, "38.bmp");
            this.ilFaces.Images.SetKeyName(38, "39.bmp");
            this.ilFaces.Images.SetKeyName(39, "40.bmp");
            this.ilFaces.Images.SetKeyName(40, "41.bmp");
            this.ilFaces.Images.SetKeyName(41, "42.bmp");
            this.ilFaces.Images.SetKeyName(42, "43.bmp");
            this.ilFaces.Images.SetKeyName(43, "44.bmp");
            this.ilFaces.Images.SetKeyName(44, "45.bmp");
            this.ilFaces.Images.SetKeyName(45, "46.bmp");
            this.ilFaces.Images.SetKeyName(46, "47.bmp");
            this.ilFaces.Images.SetKeyName(47, "48.bmp");
            this.ilFaces.Images.SetKeyName(48, "49.bmp");
            this.ilFaces.Images.SetKeyName(49, "50.bmp");
            this.ilFaces.Images.SetKeyName(50, "51.bmp");
            this.ilFaces.Images.SetKeyName(51, "52.bmp");
            this.ilFaces.Images.SetKeyName(52, "53.bmp");
            this.ilFaces.Images.SetKeyName(53, "54.bmp");
            this.ilFaces.Images.SetKeyName(54, "55.bmp");
            this.ilFaces.Images.SetKeyName(55, "56.bmp");
            this.ilFaces.Images.SetKeyName(56, "57.bmp");
            this.ilFaces.Images.SetKeyName(57, "58.bmp");
            this.ilFaces.Images.SetKeyName(58, "59.bmp");
            this.ilFaces.Images.SetKeyName(59, "60.bmp");
            this.ilFaces.Images.SetKeyName(60, "61.bmp");
            this.ilFaces.Images.SetKeyName(61, "62.bmp");
            this.ilFaces.Images.SetKeyName(62, "63.bmp");
            this.ilFaces.Images.SetKeyName(63, "64.bmp");
            this.ilFaces.Images.SetKeyName(64, "65.bmp");
            this.ilFaces.Images.SetKeyName(65, "66.bmp");
            this.ilFaces.Images.SetKeyName(66, "67.bmp");
            this.ilFaces.Images.SetKeyName(67, "68.bmp");
            this.ilFaces.Images.SetKeyName(68, "69.bmp");
            this.ilFaces.Images.SetKeyName(69, "70.bmp");
            this.ilFaces.Images.SetKeyName(70, "71.bmp");
            this.ilFaces.Images.SetKeyName(71, "72.bmp");
            this.ilFaces.Images.SetKeyName(72, "73.bmp");
            this.ilFaces.Images.SetKeyName(73, "74.bmp");
            this.ilFaces.Images.SetKeyName(74, "75.bmp");
            this.ilFaces.Images.SetKeyName(75, "76.bmp");
            this.ilFaces.Images.SetKeyName(76, "77.bmp");
            this.ilFaces.Images.SetKeyName(77, "78.bmp");
            this.ilFaces.Images.SetKeyName(78, "79.bmp");
            this.ilFaces.Images.SetKeyName(79, "80.bmp");
            this.ilFaces.Images.SetKeyName(80, "81.bmp");
            this.ilFaces.Images.SetKeyName(81, "82.bmp");
            this.ilFaces.Images.SetKeyName(82, "83.bmp");
            this.ilFaces.Images.SetKeyName(83, "84.bmp");
            this.ilFaces.Images.SetKeyName(84, "85.bmp");
            this.ilFaces.Images.SetKeyName(85, "86.bmp");
            this.ilFaces.Images.SetKeyName(86, "87.bmp");
            this.ilFaces.Images.SetKeyName(87, "88.bmp");
            this.ilFaces.Images.SetKeyName(88, "89.bmp");
            this.ilFaces.Images.SetKeyName(89, "90.bmp");
            this.ilFaces.Images.SetKeyName(90, "91.bmp");
            this.ilFaces.Images.SetKeyName(91, "92.bmp");
            this.ilFaces.Images.SetKeyName(92, "93.bmp");
            this.ilFaces.Images.SetKeyName(93, "94.bmp");
            this.ilFaces.Images.SetKeyName(94, "95.bmp");
            this.ilFaces.Images.SetKeyName(95, "96.bmp");
            this.ilFaces.Images.SetKeyName(96, "97.bmp");
            this.ilFaces.Images.SetKeyName(97, "98.bmp");
            this.ilFaces.Images.SetKeyName(98, "99.bmp");
            this.ilFaces.Images.SetKeyName(99, "100.bmp");
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(195, 356);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 34);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.button;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(389, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboStar
            // 
            this.cboStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStar.FormattingEnabled = true;
            this.cboStar.Location = new System.Drawing.Point(310, 230);
            this.cboStar.Name = "cboStar";
            this.cboStar.Size = new System.Drawing.Size(127, 26);
            this.cboStar.TabIndex = 20;
            // 
            // cboBloodType
            // 
            this.cboBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBloodType.FormattingEnabled = true;
            this.cboBloodType.Location = new System.Drawing.Point(310, 286);
            this.cboBloodType.Name = "cboBloodType";
            this.cboBloodType.Size = new System.Drawing.Size(127, 26);
            this.cboBloodType.TabIndex = 21;
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(307, 239);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(0, 18);
            this.lblStar.TabIndex = 23;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(310, 294);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(0, 18);
            this.lblBloodType.TabIndex = 24;
            // 
            // leSex
            // 
            this.leSex.BackColor = System.Drawing.Color.Transparent;
            this.leSex.Location = new System.Drawing.Point(310, 139);
            this.leSex.Name = "leSex";
            this.leSex.Size = new System.Drawing.Size(127, 23);
            this.leSex.TabIndex = 22;
            // 
            // leAge
            // 
            this.leAge.BackColor = System.Drawing.Color.Transparent;
            this.leAge.Location = new System.Drawing.Point(310, 188);
            this.leAge.Name = "leAge";
            this.leAge.Size = new System.Drawing.Size(127, 23);
            this.leAge.TabIndex = 14;
            // 
            // leName
            // 
            this.leName.BackColor = System.Drawing.Color.Transparent;
            this.leName.Location = new System.Drawing.Point(310, 85);
            this.leName.Name = "leName";
            this.leName.Size = new System.Drawing.Size(127, 23);
            this.leName.TabIndex = 12;
            // 
            // leNickName
            // 
            this.leNickName.BackColor = System.Drawing.Color.Transparent;
            this.leNickName.Location = new System.Drawing.Point(310, 32);
            this.leNickName.Name = "leNickName";
            this.leNickName.Size = new System.Drawing.Size(127, 23);
            this.leNickName.TabIndex = 11;
            // 
            // PersonalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::仿QQ聊天系统客户端.Properties.Resources.PersonalFormBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 402);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.lblStar);
            this.Controls.Add(this.leSex);
            this.Controls.Add(this.cboBloodType);
            this.Controls.Add(this.cboStar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnChangeFace);
            this.Controls.Add(this.leAge);
            this.Controls.Add(this.leName);
            this.Controls.Add(this.leNickName);
            this.Controls.Add(this.BloodType);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.lbname1);
            this.Controls.Add(this.nikeName);
            this.Controls.Add(this.picFace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PersonalInfoForm";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.PersonalInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label nikeName;
        private System.Windows.Forms.Label lbname1;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Star;
        private System.Windows.Forms.Label BloodType;
        private LableEdit leNickName;
        private LableEdit leName;
        private LableEdit leAge;
        private System.Windows.Forms.Button btnChangeFace;
        private System.Windows.Forms.ImageList ilFaces;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboStar;
        private System.Windows.Forms.ComboBox cboBloodType;
        private LableEdit leSex;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblBloodType;
    }
}