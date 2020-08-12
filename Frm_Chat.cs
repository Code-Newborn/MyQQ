using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class Frm_Chat : Form
    {
        public Frm_Chat()
        {
            InitializeComponent();
        }

        public int friendID = 0;//好友ID
        public string nickName;
        public int headID;//聊天窗体头像的ID
        DataOperator dataOperator = new DataOperator();

        /// <summary>
        /// 更新消息为已读状态
        /// </summary>
        /// <param name="messageID">消息ID集合</param>
        private void SetMessage(string messageID)
        {
            string[] messageIDs = messageID.Split('_');//分割出每个消息ID；
            string sql = "update tb_Message set MessageState=1 where ID=";//修改消息状态为已读MessageState=1
            foreach (string id in messageIDs)
            {
                if(id !="")
                {
                    sql += id;
                    int result = dataOperator.ExecSQLResult(sql);
                }
            }
        }

        /// <summary>
        /// 获取所有未读消息
        /// </summary>
        private void ShoeMessage()
        {
            string messageID = "";
            string message;
            string messageTime;
            string sql = "select ID,Message,MessageTime from tb_Message" +" where " +
                "FromUserID=" + friendID +//好友用户ID
                "and ToUserID" + PublicClass.login_ID +//登录用户ID
                "and MessageTypeID=1 and MessageState=0";//MessageTypeID=1表示为聊天消息，MessageState=0表示消息未读。
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);
            while(dataReader.Read())
            {
                messageID += dataReader["ID"] + "_";//将消息ID连接
                message = dataReader["Message"].ToString();
                messageTime = Convert.ToDateTime(dataReader["MessageTime"]).ToString();
                richTextBox_Message.Text += "\n" + nickName + "  " + messageTime + "\n" + message + "";
            }
            dataReader.Close();
            DataOperator.connection.Close();
            if(messageID.Length>1)
            {
                messageID.Remove(messageID.Length - 1);//去除连接消息最后的"_"符号
                SetMessage(messageID);//设置消息已读
            }
        }

        //窗体加载事件
        private void Frm_Chat_Load(object sender, EventArgs e)
        {
            this.Text = "与\"" + nickName + "\"聊天中";
            pictureBox_ChatHead.Image = imageList_Head.Images[headID - 1];
            label_Friend.Text = string.Format("{0} {1}", nickName, friendID);
            richTextBox_Message.ScrollToCaret();
        }
    }
}
