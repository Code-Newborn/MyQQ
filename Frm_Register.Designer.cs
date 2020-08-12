namespace MyQQ
{
    partial class Frm_Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nickname = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.textBox_PwdAgain = new System.Windows.Forms.TextBox();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Star = new System.Windows.Forms.ComboBox();
            this.comboBox_BloodStyle = new System.Windows.Forms.ComboBox();
            this.textBox_RealName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyQQ.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 334);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Female);
            this.groupBox1.Controls.Add(this.radioButton_Male);
            this.groupBox1.Controls.Add(this.textBox_PwdAgain);
            this.groupBox1.Controls.Add(this.textBox_Pwd);
            this.groupBox1.Controls.Add(this.textBox_Age);
            this.groupBox1.Controls.Add(this.textBox_Nickname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(118, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册基本资料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_RealName);
            this.groupBox2.Controls.Add(this.comboBox_BloodStyle);
            this.groupBox2.Controls.Add(this.comboBox_Star);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(118, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选填详细资料";
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(197, 323);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(75, 23);
            this.button_Register.TabIndex = 3;
            this.button_Register.Text = "注册";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(299, 323);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "重复密码";
            // 
            // textBox_Nickname
            // 
            this.textBox_Nickname.Location = new System.Drawing.Point(75, 23);
            this.textBox_Nickname.Name = "textBox_Nickname";
            this.textBox_Nickname.Size = new System.Drawing.Size(139, 21);
            this.textBox_Nickname.TabIndex = 5;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(75, 53);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(139, 21);
            this.textBox_Age.TabIndex = 6;
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(75, 113);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.Size = new System.Drawing.Size(139, 21);
            this.textBox_Pwd.TabIndex = 7;
            // 
            // textBox_PwdAgain
            // 
            this.textBox_PwdAgain.Location = new System.Drawing.Point(75, 143);
            this.textBox_PwdAgain.Name = "textBox_PwdAgain";
            this.textBox_PwdAgain.Size = new System.Drawing.Size(139, 21);
            this.textBox_PwdAgain.TabIndex = 8;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(75, 84);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(35, 16);
            this.radioButton_Male.TabIndex = 9;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "男";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(116, 84);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(35, 16);
            this.radioButton_Female.TabIndex = 10;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "女";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "真实姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "星座";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "血型";
            // 
            // comboBox_Star
            // 
            this.comboBox_Star.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Star.FormattingEnabled = true;
            this.comboBox_Star.Items.AddRange(new object[] {
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
            this.comboBox_Star.Location = new System.Drawing.Point(75, 56);
            this.comboBox_Star.Name = "comboBox_Star";
            this.comboBox_Star.Size = new System.Drawing.Size(139, 20);
            this.comboBox_Star.TabIndex = 3;
            // 
            // comboBox_BloodStyle
            // 
            this.comboBox_BloodStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BloodStyle.FormattingEnabled = true;
            this.comboBox_BloodStyle.Items.AddRange(new object[] {
            "A型",
            "B型",
            "O型",
            "AB型"});
            this.comboBox_BloodStyle.Location = new System.Drawing.Point(75, 85);
            this.comboBox_BloodStyle.Name = "comboBox_BloodStyle";
            this.comboBox_BloodStyle.Size = new System.Drawing.Size(139, 20);
            this.comboBox_BloodStyle.TabIndex = 4;
            // 
            // textBox_RealName
            // 
            this.textBox_RealName.Location = new System.Drawing.Point(75, 27);
            this.textBox_RealName.Name = "textBox_RealName";
            this.textBox_RealName.Size = new System.Drawing.Size(139, 21);
            this.textBox_RealName.TabIndex = 5;
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 358);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "申请账号";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_Nickname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.TextBox textBox_PwdAgain;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.TextBox textBox_RealName;
        private System.Windows.Forms.ComboBox comboBox_BloodStyle;
        private System.Windows.Forms.ComboBox comboBox_Star;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}