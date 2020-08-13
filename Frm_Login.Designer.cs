namespace MyQQ
{
    partial class Frm_Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.checkBox_Remember = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoLogin = new System.Windows.Forms.CheckBox();
            this.linkLabel_Reg = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_ID.Location = new System.Drawing.Point(135, 196);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(190, 26);
            this.textBox_ID.TabIndex = 0;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_Pwd.Location = new System.Drawing.Point(135, 224);
            this.textBox_Pwd.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(190, 26);
            this.textBox_Pwd.TabIndex = 1;
            this.textBox_Pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Pwd_KeyPress);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Min.Location = new System.Drawing.Point(373, 2);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Min.TabIndex = 2;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Login.Location = new System.Drawing.Point(135, 287);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(190, 31);
            this.pictureBox_Login.TabIndex = 3;
            this.pictureBox_Login.TabStop = false;
            this.pictureBox_Login.Click += new System.EventHandler(this.pictureBox_Login_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Location = new System.Drawing.Point(403, 2);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Close.TabIndex = 4;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // checkBox_Remember
            // 
            this.checkBox_Remember.AutoSize = true;
            this.checkBox_Remember.Location = new System.Drawing.Point(134, 260);
            this.checkBox_Remember.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_Remember.Name = "checkBox_Remember";
            this.checkBox_Remember.Size = new System.Drawing.Size(72, 16);
            this.checkBox_Remember.TabIndex = 5;
            this.checkBox_Remember.Text = "记住密码";
            this.checkBox_Remember.UseVisualStyleBackColor = true;
            this.checkBox_Remember.CheckedChanged += new System.EventHandler(this.checkBox_Remember_CheckedChanged);
            // 
            // checkBox_AutoLogin
            // 
            this.checkBox_AutoLogin.AutoSize = true;
            this.checkBox_AutoLogin.Location = new System.Drawing.Point(260, 260);
            this.checkBox_AutoLogin.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox_AutoLogin.Name = "checkBox_AutoLogin";
            this.checkBox_AutoLogin.Size = new System.Drawing.Size(72, 16);
            this.checkBox_AutoLogin.TabIndex = 6;
            this.checkBox_AutoLogin.Text = "自动登录";
            this.checkBox_AutoLogin.UseVisualStyleBackColor = true;
            // 
            // linkLabel_Reg
            // 
            this.linkLabel_Reg.AutoSize = true;
            this.linkLabel_Reg.Font = new System.Drawing.Font("宋体", 12F);
            this.linkLabel_Reg.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_Reg.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel_Reg.Location = new System.Drawing.Point(334, 201);
            this.linkLabel_Reg.Name = "linkLabel_Reg";
            this.linkLabel_Reg.Size = new System.Drawing.Size(72, 16);
            this.linkLabel_Reg.TabIndex = 7;
            this.linkLabel_Reg.TabStop = true;
            this.linkLabel_Reg.Text = "申请账号";
            this.linkLabel_Reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Reg_LinkClicked);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQQ.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.Controls.Add(this.linkLabel_Reg);
            this.Controls.Add(this.checkBox_AutoLogin);
            this.Controls.Add(this.checkBox_Remember);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.pictureBox_Login);
            this.Controls.Add(this.pictureBox_Min);
            this.Controls.Add(this.textBox_Pwd);
            this.Controls.Add(this.textBox_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q友登录";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.PictureBox pictureBox_Min;
        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.CheckBox checkBox_Remember;
        private System.Windows.Forms.CheckBox checkBox_AutoLogin;
        private System.Windows.Forms.LinkLabel linkLabel_Reg;
    }
}

