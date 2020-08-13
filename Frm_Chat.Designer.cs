namespace MyQQ
{
    partial class Frm_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Chat));
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.pictureBox_ChatHead = new System.Windows.Forms.PictureBox();
            this.pictureBox_ChatMin = new System.Windows.Forms.PictureBox();
            this.pictureBox_ChatClose = new System.Windows.Forms.PictureBox();
            this.pictureBox_MessageRecord = new System.Windows.Forms.PictureBox();
            this.label_Friend = new System.Windows.Forms.Label();
            this.richTextBox_Chat = new System.Windows.Forms.RichTextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.timer_ShowMessage = new System.Windows.Forms.Timer(this.components);
            this.imageList_Head = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChatHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChatClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MessageRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_Message
            // 
            this.richTextBox_Message.BackColor = System.Drawing.Color.White;
            this.richTextBox_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Message.Location = new System.Drawing.Point(3, 52);
            this.richTextBox_Message.Name = "richTextBox_Message";
            this.richTextBox_Message.ReadOnly = true;
            this.richTextBox_Message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_Message.Size = new System.Drawing.Size(590, 420);
            this.richTextBox_Message.TabIndex = 0;
            this.richTextBox_Message.Text = "";
            // 
            // pictureBox_ChatHead
            // 
            this.pictureBox_ChatHead.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ChatHead.Location = new System.Drawing.Point(9, 4);
            this.pictureBox_ChatHead.Name = "pictureBox_ChatHead";
            this.pictureBox_ChatHead.Size = new System.Drawing.Size(42, 42);
            this.pictureBox_ChatHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ChatHead.TabIndex = 1;
            this.pictureBox_ChatHead.TabStop = false;
            // 
            // pictureBox_ChatMin
            // 
            this.pictureBox_ChatMin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ChatMin.Location = new System.Drawing.Point(646, 2);
            this.pictureBox_ChatMin.Name = "pictureBox_ChatMin";
            this.pictureBox_ChatMin.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_ChatMin.TabIndex = 2;
            this.pictureBox_ChatMin.TabStop = false;
            // 
            // pictureBox_ChatClose
            // 
            this.pictureBox_ChatClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ChatClose.Location = new System.Drawing.Point(707, 2);
            this.pictureBox_ChatClose.Name = "pictureBox_ChatClose";
            this.pictureBox_ChatClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_ChatClose.TabIndex = 3;
            this.pictureBox_ChatClose.TabStop = false;
            this.pictureBox_ChatClose.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // pictureBox_MessageRecord
            // 
            this.pictureBox_MessageRecord.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_MessageRecord.Location = new System.Drawing.Point(503, 479);
            this.pictureBox_MessageRecord.Name = "pictureBox_MessageRecord";
            this.pictureBox_MessageRecord.Size = new System.Drawing.Size(90, 25);
            this.pictureBox_MessageRecord.TabIndex = 4;
            this.pictureBox_MessageRecord.TabStop = false;
            this.pictureBox_MessageRecord.Click += new System.EventHandler(this.pictureBox_MessageRecord_Click);
            // 
            // label_Friend
            // 
            this.label_Friend.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Friend.ForeColor = System.Drawing.Color.Red;
            this.label_Friend.Location = new System.Drawing.Point(57, 8);
            this.label_Friend.Name = "label_Friend";
            this.label_Friend.Size = new System.Drawing.Size(137, 23);
            this.label_Friend.TabIndex = 5;
            this.label_Friend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox_Chat
            // 
            this.richTextBox_Chat.BackColor = System.Drawing.Color.White;
            this.richTextBox_Chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Chat.Location = new System.Drawing.Point(3, 510);
            this.richTextBox_Chat.Name = "richTextBox_Chat";
            this.richTextBox_Chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_Chat.Size = new System.Drawing.Size(590, 65);
            this.richTextBox_Chat.TabIndex = 6;
            this.richTextBox_Chat.Text = "";
            this.richTextBox_Chat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_Chat_KeyDown);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(503, 581);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(90, 25);
            this.button_Send.TabIndex = 7;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(428, 581);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(74, 25);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "关闭";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // timer_ShowMessage
            // 
            this.timer_ShowMessage.Enabled = true;
            this.timer_ShowMessage.Interval = 2000;
            this.timer_ShowMessage.Tick += new System.EventHandler(this.timer_ShowMessage_Tick);
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
            // Frm_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(735, 610);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.richTextBox_Chat);
            this.Controls.Add(this.label_Friend);
            this.Controls.Add(this.pictureBox_MessageRecord);
            this.Controls.Add(this.pictureBox_ChatClose);
            this.Controls.Add(this.pictureBox_ChatMin);
            this.Controls.Add(this.pictureBox_ChatHead);
            this.Controls.Add(this.richTextBox_Message);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "聊天窗体";
            this.Load += new System.EventHandler(this.Frm_Chat_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Chat_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChatHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChatClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MessageRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Message;
        private System.Windows.Forms.PictureBox pictureBox_ChatHead;
        private System.Windows.Forms.PictureBox pictureBox_ChatMin;
        private System.Windows.Forms.PictureBox pictureBox_ChatClose;
        private System.Windows.Forms.PictureBox pictureBox_MessageRecord;
        private System.Windows.Forms.Label label_Friend;
        private System.Windows.Forms.RichTextBox richTextBox_Chat;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Timer timer_ShowMessage;
        private System.Windows.Forms.ImageList imageList_Head;
    }
}