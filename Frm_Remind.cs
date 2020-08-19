using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Remind : Form
    {
        public Frm_Remind()
        {
            InitializeComponent();
            Rectangle rect = Screen.GetWorkingArea(this);//获取桌面区域的Rectangle
            this.Rect = new Rectangle(rect.Right - this.Width - 1, rect.Bottom - this.Height - 1, this.Width, this.Height);
            //获得桌面右下角的一个大小和Frm_Remind一样的矩形区域
        }

        protected enum FormState
        {
            Hide = 0,
            Display = 1,
            Displaying = 2,
            Hiding = 3
        }

        protected FormState formNowState
        {
            get { return this.InfoState; }
            set { this.InfoState = value; }
        }

        int fromUserID;
        private Rectangle Rect;//定义一个存储矩形框的Struct
        private FormState InfoState = FormState.Hide;
        static private Frm_Remind dropDownForm = new Frm_Remind();
        DataOperator dataOperator = new DataOperator();

        public void ShowForm()
        {
            switch (this.formNowState)
            {
                case FormState.Hide:
                    this.SetBounds(Rect.X, Rect.Y, Rect.Width, Rect.Height);
                    PublicClass.AnimateWindow(this.Handle, 800, PublicClass.AW_SLIDE + PublicClass.AW_VER_NEGATIVE);//动态显示窗体
                    break;
            }
        }

        private void Frm_Remind_Load(object sender, EventArgs e)
        {
            ShowForm();
            int messageID = 0;
            string sql = "select Top 1 ID,FromUserID from tb_Message where ToUserID=" + PublicClass.login_ID + " AND MessageTypeID=2 AND MessageState=0";
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);
            if (dataReader.Read())//获取  发送好友添加信息的用户ID 和消息ID
            {
                messageID = (int)dataReader["ID"];
                fromUserID = (int)dataReader["FromUserID"];
            }
            DataOperator.connection.Close();

            sql = "update tb_Message set MessageState=1 where ID=" + messageID;
            dataOperator.ExecSQLResult(sql);//设置好友消息已读

            sql = "select NickName,HeadID from tb_User where ID=" + this.fromUserID;
            dataReader = dataOperator.GetDataReader(sql);

            if (dataReader.Read())//获取发送消息者 的昵称和头像ID
            {
                int HeadID = (int)dataReader["HeadID"];
                string nickName = (string)dataReader["NickName"];
                label_message.Text = nickName + "(" + fromUserID + ")请求添加您为好友";
                button_OK.Visible = true;
                pictureBox_head.Image = imageList_Head.Images[HeadID];
            }
            else
            {
                label_message.Text = "暂无系统消息";
                button_OK.Visible = false;
            }
            dataReader.Close();
            DataOperator.connection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PublicClass.AnimateWindow(this.Handle, 800, PublicClass.AW_SLIDE + PublicClass.AW_VER_POSITIVE + PublicClass.AW_HIDE);
            this.formNowState = FormState.Hide;
        }

        private void pictureBox_head_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Close.BackColor = Color.Red;
        }

        private void pictureBox_head_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Close.BackColor = Color.Blue;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from tb_Friend where HostID=" + fromUserID + " and FriendID=" + PublicClass.login_ID;
            int num = dataOperator.ExecSQL(sql);
            if (num <= 0)
            {
                sql = "insert into tb_Friend (HostID,FriendID) values (" + fromUserID + "," + PublicClass.login_ID + ")";
                dataOperator.ExecSQLResult(sql);
                sql = "insert into tb_Friend (HostID,FriendID) values (" + PublicClass.login_ID + "," + fromUserID + ")";
                dataOperator.ExecSQLResult(sql);
            }
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
