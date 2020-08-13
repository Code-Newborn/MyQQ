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
                if (id != "")
                {
                    int result = dataOperator.ExecSQLResult(sql + id);
                }
            }
        }

        /// <summary>
        /// 获取所有未读消息
        /// </summary>
        private void ShowMessage()
        {
            string messageID = "";
            string message;
            string messageTime;
            string sql = "select ID,Message,MessageTime from tb_Message where FromUserID=" + friendID + " and ToUserID=" + PublicClass.login_ID + " and MessageTypeID=1 and MessageState=0";//好友用户ID                
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);
            while (dataReader.Read())
            {
                messageID += dataReader["ID"] + "_";//将消息ID连接
                message = dataReader["Message"].ToString();
                messageTime = Convert.ToDateTime(dataReader["MessageTime"]).ToString();
                richTextBox_Message.Text += "\n" + nickName + "  " + messageTime + "\n" + message + "";
            }
            dataReader.Close();
            DataOperator.connection.Close();
            if (messageID.Length > 1)
            {
                messageID = messageID.Remove(messageID.Length - 1);//去除连接消息最后的"_"符号
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

        private void timer_ShowMessage_Tick(object sender, EventArgs e)
        {
            ShowMessage();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (richTextBox_Chat.Text == "")
            {
                MessageBox.Show("不能发送空消息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = string.Format("insert into tb_Message(FromUserID,ToUserID,Message,MessageTypeID,MessageState) " +
                    "values({0},{1},'{2}',{3},{4})", PublicClass.login_ID, friendID, richTextBox_Chat.Text, 1, 0);
                int result = dataOperator.ExecSQLResult(sql);
                richTextBox_Message.Text += "\n" + Frm_Main.nickName + "  " + DateTime.Now + "\n" + richTextBox_Chat.Text;
                if (result != 1)
                {
                    MessageBox.Show("消息发送失败，请重新发送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                richTextBox_Chat.Text = "";//清空发送消息
                richTextBox_Chat.Focus();//鼠标定位到消息输入文本框
            }
        }

        /// <summary>
        /// 聊天文本框内按键发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_Chat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 13)//按下Ctrl+Enter键发送消息
            {
                e.Handled = true;//如果为false，发送完消息，聊天文本框会多出一空行
                button_Send_Click(this, null);
            }
        }

        /// <summary>
        /// 消息记录显示按钮 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_MessageRecord_Click(object sender, EventArgs e)
        {
            richTextBox_Message.Clear();                                                    //清空消息框
            string messageID = "";                                                          //消息ID
            string message;                                                                 //消息内容
            string messageTime;                                                             //消息时间
            string sql = "select ID,NickName,Message,MessageTime from v_Message " + "where " +
                "(FromUserID=" + friendID + " and ToUserID=" + PublicClass.login_ID + ") or" +
                "(FromUserID=" + PublicClass.login_ID + "and ToUserID=" + friendID + ") " +
                "order by MessageTime asc";                                                 //消息查询SQL语句
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);                     //执行查询
            while(dataReader.Read())                                                        //循环读取消息
            {
                messageID += dataReader["ID"] + "_";                                        //连接消息ID字符串
                message = dataReader["Message"].ToString();                                 //获取消息内容
                messageTime = Convert.ToDateTime(dataReader["MessageTime"]).ToString();     //获取消息时间
                richTextBox_Message.Text += "\n" + dataReader["NickName"] + "  " + messageTime + "\n  " + message;  //消息显示格式
            }
            dataReader.Close();
            DataOperator.connection.Close();
        }


        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Frm_Chat_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture(); //释放被当前线程中某个窗口捕获的光标

            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);

        }
    }
}
