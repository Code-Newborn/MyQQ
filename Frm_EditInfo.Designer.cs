namespace MyQQ
{
    partial class Frm_EditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditInfo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.comboBox_bloodType = new System.Windows.Forms.ComboBox();
            this.comboBox_star = new System.Windows.Forms.ComboBox();
            this.textBox_realName = new System.Windows.Forms.TextBox();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.textBox_nickName = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_bloodType = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.button_showHead = new System.Windows.Forms.Button();
            this.pictureBox_head = new System.Windows.Forms.PictureBox();
            this.label_star = new System.Windows.Forms.Label();
            this.label_realName = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_nickName = new System.Windows.Forms.Label();
            this.label_LoginID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_IDConfirm = new System.Windows.Forms.GroupBox();
            this.radioButton_Validation = new System.Windows.Forms.RadioButton();
            this.radioButton_Nobody = new System.Windows.Forms.RadioButton();
            this.radioButton_Anybody = new System.Windows.Forms.RadioButton();
            this.groupBox_EditPwd = new System.Windows.Forms.GroupBox();
            this.textBox_newPwdAgain = new System.Windows.Forms.TextBox();
            this.textBox_newPwd = new System.Windows.Forms.TextBox();
            this.textBox_oldPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.imageList_Head = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_head)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox_IDConfirm.SuspendLayout();
            this.groupBox_EditPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 219);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_age);
            this.tabPage1.Controls.Add(this.comboBox_bloodType);
            this.tabPage1.Controls.Add(this.comboBox_star);
            this.tabPage1.Controls.Add(this.textBox_realName);
            this.tabPage1.Controls.Add(this.comboBox_sex);
            this.tabPage1.Controls.Add(this.textBox_nickName);
            this.tabPage1.Controls.Add(this.textBox_ID);
            this.tabPage1.Controls.Add(this.label_bloodType);
            this.tabPage1.Controls.Add(this.label_age);
            this.tabPage1.Controls.Add(this.button_showHead);
            this.tabPage1.Controls.Add(this.pictureBox_head);
            this.tabPage1.Controls.Add(this.label_star);
            this.tabPage1.Controls.Add(this.label_realName);
            this.tabPage1.Controls.Add(this.label_Sex);
            this.tabPage1.Controls.Add(this.label_nickName);
            this.tabPage1.Controls.Add(this.label_LoginID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(249, 114);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(61, 21);
            this.textBox_age.TabIndex = 14;
            // 
            // comboBox_bloodType
            // 
            this.comboBox_bloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bloodType.FormattingEnabled = true;
            this.comboBox_bloodType.Items.AddRange(new object[] {
            "A型 ",
            "B型 ",
            "O型 ",
            "AB型"});
            this.comboBox_bloodType.Location = new System.Drawing.Point(249, 146);
            this.comboBox_bloodType.Name = "comboBox_bloodType";
            this.comboBox_bloodType.Size = new System.Drawing.Size(61, 20);
            this.comboBox_bloodType.TabIndex = 13;
            // 
            // comboBox_star
            // 
            this.comboBox_star.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_star.FormattingEnabled = true;
            this.comboBox_star.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "双鱼座"});
            this.comboBox_star.Location = new System.Drawing.Point(85, 146);
            this.comboBox_star.Name = "comboBox_star";
            this.comboBox_star.Size = new System.Drawing.Size(100, 20);
            this.comboBox_star.TabIndex = 12;
            // 
            // textBox_realName
            // 
            this.textBox_realName.Location = new System.Drawing.Point(85, 114);
            this.textBox_realName.Name = "textBox_realName";
            this.textBox_realName.Size = new System.Drawing.Size(100, 21);
            this.textBox_realName.TabIndex = 11;
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_sex.Location = new System.Drawing.Point(85, 82);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(100, 20);
            this.comboBox_sex.TabIndex = 10;
            // 
            // textBox_nickName
            // 
            this.textBox_nickName.Location = new System.Drawing.Point(85, 50);
            this.textBox_nickName.Name = "textBox_nickName";
            this.textBox_nickName.Size = new System.Drawing.Size(100, 21);
            this.textBox_nickName.TabIndex = 9;
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_ID.Location = new System.Drawing.Point(85, 18);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(100, 21);
            this.textBox_ID.TabIndex = 2;
            this.textBox_ID.TabStop = false;
            // 
            // label_bloodType
            // 
            this.label_bloodType.AutoSize = true;
            this.label_bloodType.Location = new System.Drawing.Point(202, 149);
            this.label_bloodType.Name = "label_bloodType";
            this.label_bloodType.Size = new System.Drawing.Size(41, 12);
            this.label_bloodType.TabIndex = 8;
            this.label_bloodType.Text = "血型：";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(202, 117);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(41, 12);
            this.label_age.TabIndex = 7;
            this.label_age.Text = "年龄：";
            // 
            // button_showHead
            // 
            this.button_showHead.BackColor = System.Drawing.Color.Black;
            this.button_showHead.Location = new System.Drawing.Point(277, 47);
            this.button_showHead.Name = "button_showHead";
            this.button_showHead.Size = new System.Drawing.Size(18, 16);
            this.button_showHead.TabIndex = 6;
            this.button_showHead.Text = " ";
            this.button_showHead.UseVisualStyleBackColor = false;
            this.button_showHead.Click += new System.EventHandler(this.button_showHead_Click);
            // 
            // pictureBox_head
            // 
            this.pictureBox_head.Location = new System.Drawing.Point(221, 21);
            this.pictureBox_head.Name = "pictureBox_head";
            this.pictureBox_head.Size = new System.Drawing.Size(50, 40);
            this.pictureBox_head.TabIndex = 5;
            this.pictureBox_head.TabStop = false;
            // 
            // label_star
            // 
            this.label_star.AutoSize = true;
            this.label_star.Location = new System.Drawing.Point(38, 149);
            this.label_star.Name = "label_star";
            this.label_star.Size = new System.Drawing.Size(41, 12);
            this.label_star.TabIndex = 4;
            this.label_star.Text = "星座：";
            // 
            // label_realName
            // 
            this.label_realName.AutoSize = true;
            this.label_realName.Location = new System.Drawing.Point(14, 117);
            this.label_realName.Name = "label_realName";
            this.label_realName.Size = new System.Drawing.Size(65, 12);
            this.label_realName.TabIndex = 3;
            this.label_realName.Text = "真实姓名：";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(38, 85);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(41, 12);
            this.label_Sex.TabIndex = 2;
            this.label_Sex.Text = "性别：";
            // 
            // label_nickName
            // 
            this.label_nickName.AutoSize = true;
            this.label_nickName.Location = new System.Drawing.Point(14, 53);
            this.label_nickName.Name = "label_nickName";
            this.label_nickName.Size = new System.Drawing.Size(65, 12);
            this.label_nickName.TabIndex = 1;
            this.label_nickName.Text = "用户昵称：";
            // 
            // label_LoginID
            // 
            this.label_LoginID.AutoSize = true;
            this.label_LoginID.Location = new System.Drawing.Point(14, 21);
            this.label_LoginID.Name = "label_LoginID";
            this.label_LoginID.Size = new System.Drawing.Size(65, 12);
            this.label_LoginID.TabIndex = 0;
            this.label_LoginID.Text = "用户号码：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_IDConfirm);
            this.tabPage2.Controls.Add(this.groupBox_EditPwd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "安全设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_IDConfirm
            // 
            this.groupBox_IDConfirm.Controls.Add(this.radioButton_Validation);
            this.groupBox_IDConfirm.Controls.Add(this.radioButton_Nobody);
            this.groupBox_IDConfirm.Controls.Add(this.radioButton_Anybody);
            this.groupBox_IDConfirm.Location = new System.Drawing.Point(8, 105);
            this.groupBox_IDConfirm.Name = "groupBox_IDConfirm";
            this.groupBox_IDConfirm.Size = new System.Drawing.Size(305, 82);
            this.groupBox_IDConfirm.TabIndex = 0;
            this.groupBox_IDConfirm.TabStop = false;
            this.groupBox_IDConfirm.Text = "身份验证";
            // 
            // radioButton_Validation
            // 
            this.radioButton_Validation.AutoSize = true;
            this.radioButton_Validation.Location = new System.Drawing.Point(11, 40);
            this.radioButton_Validation.Name = "radioButton_Validation";
            this.radioButton_Validation.Size = new System.Drawing.Size(179, 16);
            this.radioButton_Validation.TabIndex = 2;
            this.radioButton_Validation.TabStop = true;
            this.radioButton_Validation.Tag = "1";
            this.radioButton_Validation.Text = "需要身份验证才能加我为好友";
            this.radioButton_Validation.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nobody
            // 
            this.radioButton_Nobody.AutoSize = true;
            this.radioButton_Nobody.Location = new System.Drawing.Point(11, 60);
            this.radioButton_Nobody.Name = "radioButton_Nobody";
            this.radioButton_Nobody.Size = new System.Drawing.Size(155, 16);
            this.radioButton_Nobody.TabIndex = 1;
            this.radioButton_Nobody.TabStop = true;
            this.radioButton_Nobody.Tag = "2";
            this.radioButton_Nobody.Text = "不允许任何人加我为好友";
            this.radioButton_Nobody.UseVisualStyleBackColor = true;
            // 
            // radioButton_Anybody
            // 
            this.radioButton_Anybody.AutoSize = true;
            this.radioButton_Anybody.Location = new System.Drawing.Point(11, 20);
            this.radioButton_Anybody.Name = "radioButton_Anybody";
            this.radioButton_Anybody.Size = new System.Drawing.Size(143, 16);
            this.radioButton_Anybody.TabIndex = 0;
            this.radioButton_Anybody.TabStop = true;
            this.radioButton_Anybody.Tag = "0";
            this.radioButton_Anybody.Text = "允许任何人加我为好友";
            this.radioButton_Anybody.UseVisualStyleBackColor = true;
            // 
            // groupBox_EditPwd
            // 
            this.groupBox_EditPwd.Controls.Add(this.textBox_newPwdAgain);
            this.groupBox_EditPwd.Controls.Add(this.textBox_newPwd);
            this.groupBox_EditPwd.Controls.Add(this.textBox_oldPwd);
            this.groupBox_EditPwd.Controls.Add(this.label3);
            this.groupBox_EditPwd.Controls.Add(this.label2);
            this.groupBox_EditPwd.Controls.Add(this.label1);
            this.groupBox_EditPwd.Location = new System.Drawing.Point(8, 6);
            this.groupBox_EditPwd.Name = "groupBox_EditPwd";
            this.groupBox_EditPwd.Size = new System.Drawing.Size(305, 93);
            this.groupBox_EditPwd.TabIndex = 0;
            this.groupBox_EditPwd.TabStop = false;
            this.groupBox_EditPwd.Text = "修改密码";
            // 
            // textBox_newPwdAgain
            // 
            this.textBox_newPwdAgain.Location = new System.Drawing.Point(92, 66);
            this.textBox_newPwdAgain.Name = "textBox_newPwdAgain";
            this.textBox_newPwdAgain.Size = new System.Drawing.Size(162, 21);
            this.textBox_newPwdAgain.TabIndex = 5;
            // 
            // textBox_newPwd
            // 
            this.textBox_newPwd.Location = new System.Drawing.Point(92, 41);
            this.textBox_newPwd.Name = "textBox_newPwd";
            this.textBox_newPwd.Size = new System.Drawing.Size(162, 21);
            this.textBox_newPwd.TabIndex = 4;
            // 
            // textBox_oldPwd
            // 
            this.textBox_oldPwd.Location = new System.Drawing.Point(92, 16);
            this.textBox_oldPwd.Name = "textBox_oldPwd";
            this.textBox_oldPwd.Size = new System.Drawing.Size(162, 21);
            this.textBox_oldPwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码确认：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(172, 225);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(260, 225);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // imageList_Head
            // 
            this.imageList_Head.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Head.ImageStream")));
            this.imageList_Head.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Head.Images.SetKeyName(0, "1.bmp");
            this.imageList_Head.Images.SetKeyName(1, "2.bmp");
            this.imageList_Head.Images.SetKeyName(2, "3.bmp");
            this.imageList_Head.Images.SetKeyName(3, "4.bmp");
            this.imageList_Head.Images.SetKeyName(4, "5.bmp");
            this.imageList_Head.Images.SetKeyName(5, "6.bmp");
            this.imageList_Head.Images.SetKeyName(6, "7.bmp");
            this.imageList_Head.Images.SetKeyName(7, "8.bmp");
            this.imageList_Head.Images.SetKeyName(8, "9.bmp");
            this.imageList_Head.Images.SetKeyName(9, "10.bmp");
            this.imageList_Head.Images.SetKeyName(10, "11.bmp");
            this.imageList_Head.Images.SetKeyName(11, "12.bmp");
            this.imageList_Head.Images.SetKeyName(12, "13.bmp");
            this.imageList_Head.Images.SetKeyName(13, "14.bmp");
            this.imageList_Head.Images.SetKeyName(14, "15.bmp");
            this.imageList_Head.Images.SetKeyName(15, "16.bmp");
            this.imageList_Head.Images.SetKeyName(16, "17.bmp");
            this.imageList_Head.Images.SetKeyName(17, "18.bmp");
            this.imageList_Head.Images.SetKeyName(18, "19.bmp");
            this.imageList_Head.Images.SetKeyName(19, "20.bmp");
            this.imageList_Head.Images.SetKeyName(20, "21.bmp");
            this.imageList_Head.Images.SetKeyName(21, "22.bmp");
            this.imageList_Head.Images.SetKeyName(22, "23.bmp");
            this.imageList_Head.Images.SetKeyName(23, "24.bmp");
            this.imageList_Head.Images.SetKeyName(24, "25.bmp");
            this.imageList_Head.Images.SetKeyName(25, "26.bmp");
            this.imageList_Head.Images.SetKeyName(26, "27.bmp");
            this.imageList_Head.Images.SetKeyName(27, "28.bmp");
            this.imageList_Head.Images.SetKeyName(28, "29.bmp");
            this.imageList_Head.Images.SetKeyName(29, "30.bmp");
            this.imageList_Head.Images.SetKeyName(30, "31.bmp");
            this.imageList_Head.Images.SetKeyName(31, "32.bmp");
            this.imageList_Head.Images.SetKeyName(32, "33.bmp");
            this.imageList_Head.Images.SetKeyName(33, "34.bmp");
            this.imageList_Head.Images.SetKeyName(34, "35.bmp");
            this.imageList_Head.Images.SetKeyName(35, "36.bmp");
            this.imageList_Head.Images.SetKeyName(36, "37.bmp");
            this.imageList_Head.Images.SetKeyName(37, "38.bmp");
            this.imageList_Head.Images.SetKeyName(38, "39.bmp");
            this.imageList_Head.Images.SetKeyName(39, "40.bmp");
            this.imageList_Head.Images.SetKeyName(40, "41.bmp");
            this.imageList_Head.Images.SetKeyName(41, "42.bmp");
            this.imageList_Head.Images.SetKeyName(42, "43.bmp");
            this.imageList_Head.Images.SetKeyName(43, "44.bmp");
            this.imageList_Head.Images.SetKeyName(44, "45.bmp");
            this.imageList_Head.Images.SetKeyName(45, "46.bmp");
            this.imageList_Head.Images.SetKeyName(46, "47.bmp");
            this.imageList_Head.Images.SetKeyName(47, "48.bmp");
            this.imageList_Head.Images.SetKeyName(48, "49.bmp");
            this.imageList_Head.Images.SetKeyName(49, "50.bmp");
            this.imageList_Head.Images.SetKeyName(50, "51.bmp");
            this.imageList_Head.Images.SetKeyName(51, "52.bmp");
            this.imageList_Head.Images.SetKeyName(52, "53.bmp");
            this.imageList_Head.Images.SetKeyName(53, "54.bmp");
            this.imageList_Head.Images.SetKeyName(54, "55.bmp");
            this.imageList_Head.Images.SetKeyName(55, "56.bmp");
            this.imageList_Head.Images.SetKeyName(56, "57.bmp");
            this.imageList_Head.Images.SetKeyName(57, "58.bmp");
            this.imageList_Head.Images.SetKeyName(58, "59.bmp");
            this.imageList_Head.Images.SetKeyName(59, "60.bmp");
            this.imageList_Head.Images.SetKeyName(60, "61.bmp");
            this.imageList_Head.Images.SetKeyName(61, "62.bmp");
            this.imageList_Head.Images.SetKeyName(62, "63.bmp");
            this.imageList_Head.Images.SetKeyName(63, "64.bmp");
            this.imageList_Head.Images.SetKeyName(64, "65.bmp");
            this.imageList_Head.Images.SetKeyName(65, "66.bmp");
            this.imageList_Head.Images.SetKeyName(66, "67.bmp");
            this.imageList_Head.Images.SetKeyName(67, "68.bmp");
            this.imageList_Head.Images.SetKeyName(68, "69.bmp");
            this.imageList_Head.Images.SetKeyName(69, "70.bmp");
            this.imageList_Head.Images.SetKeyName(70, "71.bmp");
            this.imageList_Head.Images.SetKeyName(71, "72.bmp");
            this.imageList_Head.Images.SetKeyName(72, "73.bmp");
            this.imageList_Head.Images.SetKeyName(73, "74.bmp");
            this.imageList_Head.Images.SetKeyName(74, "75.bmp");
            this.imageList_Head.Images.SetKeyName(75, "76.bmp");
            this.imageList_Head.Images.SetKeyName(76, "77.bmp");
            this.imageList_Head.Images.SetKeyName(77, "78.bmp");
            this.imageList_Head.Images.SetKeyName(78, "79.bmp");
            this.imageList_Head.Images.SetKeyName(79, "80.bmp");
            this.imageList_Head.Images.SetKeyName(80, "81.bmp");
            this.imageList_Head.Images.SetKeyName(81, "82.bmp");
            this.imageList_Head.Images.SetKeyName(82, "83.bmp");
            this.imageList_Head.Images.SetKeyName(83, "84.bmp");
            this.imageList_Head.Images.SetKeyName(84, "85.bmp");
            this.imageList_Head.Images.SetKeyName(85, "86.bmp");
            this.imageList_Head.Images.SetKeyName(86, "87.bmp");
            this.imageList_Head.Images.SetKeyName(87, "88.bmp");
            this.imageList_Head.Images.SetKeyName(88, "89.bmp");
            this.imageList_Head.Images.SetKeyName(89, "90.bmp");
            this.imageList_Head.Images.SetKeyName(90, "91.bmp");
            this.imageList_Head.Images.SetKeyName(91, "92.bmp");
            this.imageList_Head.Images.SetKeyName(92, "93.bmp");
            this.imageList_Head.Images.SetKeyName(93, "94.bmp");
            this.imageList_Head.Images.SetKeyName(94, "95.bmp");
            this.imageList_Head.Images.SetKeyName(95, "96.bmp");
            this.imageList_Head.Images.SetKeyName(96, "97.bmp");
            this.imageList_Head.Images.SetKeyName(97, "98.bmp");
            this.imageList_Head.Images.SetKeyName(98, "99.bmp");
            this.imageList_Head.Images.SetKeyName(99, "100.bmp");
            this.imageList_Head.Images.SetKeyName(100, "back.bmp");
            // 
            // Frm_EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 255);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_EditInfo";
            this.Text = "个人信息设置";
            this.Load += new System.EventHandler(this.Frm_EditInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_head)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox_IDConfirm.ResumeLayout(false);
            this.groupBox_IDConfirm.PerformLayout();
            this.groupBox_EditPwd.ResumeLayout(false);
            this.groupBox_EditPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_bloodType;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Button button_showHead;
        private System.Windows.Forms.PictureBox pictureBox_head;
        private System.Windows.Forms.Label label_star;
        private System.Windows.Forms.Label label_realName;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_nickName;
        private System.Windows.Forms.Label label_LoginID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.ComboBox comboBox_bloodType;
        private System.Windows.Forms.ComboBox comboBox_star;
        private System.Windows.Forms.TextBox textBox_realName;
        private System.Windows.Forms.ComboBox comboBox_sex;
        private System.Windows.Forms.TextBox textBox_nickName;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.GroupBox groupBox_IDConfirm;
        private System.Windows.Forms.RadioButton radioButton_Validation;
        private System.Windows.Forms.RadioButton radioButton_Nobody;
        private System.Windows.Forms.RadioButton radioButton_Anybody;
        private System.Windows.Forms.GroupBox groupBox_EditPwd;
        private System.Windows.Forms.TextBox textBox_newPwdAgain;
        private System.Windows.Forms.TextBox textBox_newPwd;
        private System.Windows.Forms.TextBox textBox_oldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ImageList imageList_Head;
    }
}