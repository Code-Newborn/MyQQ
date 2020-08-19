using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            //控制ListView的行距和列距
            PublicClass.SendMessage(this.listView_Friend.Handle, PublicClass.LVM_SETICONAPACING, 0, 0x10000 * 70 + 130);
            //行距70、列距130
        }

        int fromUserID;
        int friendHeadID;//好友头像ID
        int messageImageIndex;//消息图片索引
        public static string nickName = "";//昵称
        public static string strFlag = "[离线]";//默认离线状态
        DataOperator dataOperator = new DataOperator();//为调用数据库操作

        /// <summary>
        /// 显示用户主界面信息
        /// </summary>
        public void ShowUserInfo()
        {
            int headID = 0;
            string sql = "select NickName,HeadID,Sign from tb_User Where ID=" + PublicClass.login_ID + "";//数据库查询语句
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);
            if (dataReader.Read())//读取查询结果
            {
                if (!(dataReader["NickName"] is DBNull))//判断NickName不为空
                {
                    nickName = dataReader["NickName"].ToString();//获取昵称
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);//获取头像索引
                textBox_Sign.Text = dataReader["Sign"].ToString();//显示个性签名
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库
            this.Text = PublicClass.login_ID.ToString();//设置窗体标题为当前用户ID
            pictureBox_Head.Image = imageList_Head.Images[headID];//显示用户头像
            label_Name.Text = nickName + "(" + PublicClass.login_ID + ")";//显示昵称及账号
        }


        /// <summary>
        /// 获取显示好友信息
        /// </summary>
        private void ShowFriendList()
        {
            listView_Friend.Items.Clear();//清空好友列表
            string sql = "select FriendID,NickName,HeadID,Flag from tb_User,tb_Friend where tb_Friend.HostID =" + PublicClass.login_ID +
                "and tb_User.ID = tb_Friend.FriendID";//定义登录ID下的好友信息SQL查询语句
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);//执行查询语句
            int i = listView_Friend.Items.Count;//i=0
            while (dataReader.Read())//循环添加好友列表
            {
                if (dataReader["Flag"].ToString() == "0")
                {
                    strFlag = "[离线]";
                }
                else
                {
                    strFlag = "[在线]";
                }
                string strTemp = dataReader["NickName"].ToString();//好友昵称

                string strFriendName = strTemp;//备份对好友昵称显示进行处理
                if (strTemp.Length < 9)
                    strFriendName = strTemp.PadLeft(9, ' ');
                else
                    strFriendName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                listView_Friend.Items.Add(dataReader["FriendID"].ToString(), strFriendName + strFlag, (int)dataReader["HeadID"]);
                listView_Friend.Items[i].Group = listView_Friend.Groups[0];//设置项的分组为我的好友
                i++;
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
        }

        /// <summary>
        /// 查询是否在当前用户列表中有关系ID
        /// </summary>
        /// <param name="ID">两账号关系的ID号</param>
        /// <returns></returns>
        private bool HasShowUser(int ID)
        {
            bool find = false;//列表中是否查询到该ID
            for (int i = 0; i < 2; i++)//列表分组间循环查询
            {
                for (int j = 0; j < listView_Friend.Groups[i].Items.Count; j++)//组内元素循环查询
                {
                    if (Convert.ToInt32(listView_Friend.Groups[i].Items[j].Name) == ID)//列表中存在该ID
                    {
                        find = true;
                    }
                }
            }
            return find;
        }

        /// <summary>
        /// 更新陌生人列表
        /// </summary>
        /// <param name="ID">两账号间的好友标识号</param>
        private void UpdateStranger(int ID)
        {
            listView_Friend.Items.Clear();
            string sql = "select NIckName,HeadID from tb_User where ID=" + ID;
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);
            int i = listView_Friend.Items.Count;
            while (dataReader.Read())
            {
                string strTemp = dataReader["NickName"].ToString();
                string strName = strTemp;
                if (strTemp.Length < 9)
                    strName = strTemp.PadLeft(9, ' ');
                else
                    strName = (strTemp.Substring(0, 2).PadLeft(9, ' '));
                listView_Friend.Items.Add(fromUserID.ToString(), strName, (int)dataReader["HeadID"]);
                listView_Friend.Items[i].Group = listView_Friend.Groups[1];
                i++;
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            toolStripButton_MessageRead.Image = imageList_Message.Images[0];//工具栏的消息图标
            ShowUserInfo();//显示个人信息
            ShowFriendList();//显示好友列表
        }

        /// <summary>
        /// "显示个人信息"功能键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Info_Click(object sender, EventArgs e)
        {
            Frm_EditInfo frm_Info = new Frm_EditInfo();//创建个人信息窗体对象
            frm_Info.frmMain = this;
            frm_Info.Show();
        }

        /// <summary>
        /// "查找好友"功能键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_SearchFriend_Click(object sender, EventArgs e)
        {
            Frm_AddFriend frm_AddFriend = new Frm_AddFriend();
            frm_AddFriend.Show();
        }

        /// <summary>
        /// "刷新好友列表"    功能键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_UpdateFriendList_Click(object sender, EventArgs e)
        {
            ShowFriendList();
        }

        /// <summary>
        /// "消息"    按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_MessageRead_Click(object sender, EventArgs e)
        {
            timer_AddFriend.Stop();
            messageImageIndex = 0;
            toolStripButton_MessageRead.Image = imageList_Message.Images[messageImageIndex];
            Frm_Remind frm_Remind = new Frm_Remind();
            frm_Remind.Show();
        }

        /// <summary>
        /// "退出"    功能键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要退出MyQQ？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.ExitThread();
        }

        Frm_Chat frm_Chat;//声明聊天窗体
        /// <summary>
        /// 双击好友列表事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Friend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView_Friend.SelectedItems.Count > 0)//是否选中好友
            {
                if (frm_Chat == null)//聊天窗体对象是否为空
                {
                    frm_Chat = new Frm_Chat();//创建聊天窗体
                    frm_Chat.friendID = Convert.ToInt32(listView_Friend.SelectedItems[0].Name);//获取聊天窗体好友关系ID
                    //数据库查询获取   好友的昵称
                    frm_Chat.nickName = dataOperator.GetDataSet("select NickName from tb_User where ID=" + frm_Chat.friendID).Tables[0].Rows[0][0].ToString();
                    //数据库查询获取   好友头像ID
                    frm_Chat.headID = Convert.ToInt32(dataOperator.GetDataSet("select HeadID from tb_User where ID=" + frm_Chat.friendID).Tables[0].Rows[0][0]) + 1;

                    frm_Chat.ShowDialog();//以对话框形式显示聊天窗体
                    frm_Chat = null;//将聊天窗体对象设置为空
                }
                if (timer_Chat.Enabled == true)//如果消息提示定时器处于可用状态
                {
                    timer_Chat.Stop();//停止头像闪烁
                    listView_Friend.SelectedItems[0].ImageIndex = friendHeadID;//将选中项的头像显示为正常状态
                }
            }
        }

        /// <summary>
        /// Message消息计时器时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Message_Tick(object sender, EventArgs e)
        {
            if (listView_Friend.SelectedItems.Count > 0)//好友列表中是否有选中项
            {
                if (listView_Friend.SelectedItems[0].Group == listView_Friend.Groups[0])//若在好友列表
                {
                    ToolStripMenuItem_Del.Visible = true;//显示删除好友选项
                    ToolStripMenuItem_Add.Visible = false;//隐藏添加好友选项
                }
                else if (listView_Friend.SelectedItems[0].Group == listView_Friend.Groups[1])//若在陌生人列表
                {
                    ToolStripMenuItem_Del.Visible = false;
                    ToolStripMenuItem_Add.Visible = true;
                }
            }
            int messageTypeID = 1;
            int messageState = 1;
            //查找未读消息来源的好友ID
            string sql = "select top 1 FromUserID,MessageTypeID,MessageState from tb_Message where toUserID=" + PublicClass.login_ID + "and MessageState =0";
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);
            if (dataReader.Read())
            {
                fromUserID = (int)dataReader["FromUserID"];
                messageTypeID = (int)dataReader["MessageTypeID"];
                messageState = (int)dataReader["MessageState"];
            }
            dataReader.Close();
            DataOperator.connection.Close();
            //如果是添加好友信息，启动  添加好友消息提醒计时器
            if (messageTypeID == 2 && messageState == 0)
            {
                SoundPlayer player = new SoundPlayer("system.wav");
                player.Play();
                timer_AddFriend.Start();
            }
            //如果是聊天消息，启动    聊天计时器，使好友头像闪烁
            else if (messageTypeID == 1 && messageState == 0)
            {
                sql = "select HeadID from tb_User where ID=" + fromUserID;
                friendHeadID = dataOperator.ExecSQL(sql);
                if (!HasShowUser(fromUserID))
                {
                    UpdateStranger(fromUserID);
                }
                SoundPlayer player = new SoundPlayer("msg.wav");
                player.Play();
                timer_Chat.Start();
            }
        }

        private void timer_AddFriend_Tick(object sender, EventArgs e)
        {
            messageImageIndex = messageImageIndex == 0 ? 1 : 0;//添加好友信息图标闪烁

            toolStripButton_MessageRead.Image = imageList_Message.Images[messageImageIndex];//工具栏中显示消息读取状态图像
        }


        /// <summary>
        /// 消息发送者头像闪烁-计时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Chat_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < listView_Friend.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(listView_Friend.Groups[i].Items[j].Name) == fromUserID)
                    {
                        if (frm_Chat != null && frm_Chat.friendID != 0)
                        {
                            listView_Friend.SelectedItems[0].ImageIndex = friendHeadID;
                        }
                        else//消息对象头的像闪烁
                        {
                            if (listView_Friend.Groups[i].Items[j].ImageIndex < 100)
                            {
                                listView_Friend.Groups[i].Items[j].ImageIndex = 100;
                            }
                            else
                            {
                                listView_Friend.Groups[i].Items[j].ImageIndex = friendHeadID;
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)//关闭
        {
            dataOperator.ExecSQLResult("update tb_User set Flag=0 where ID=" + PublicClass.login_ID);
            Application.ExitThread();
        }

        /// <summary>
        /// 使窗体能够拖动（窗体FormBorderStyle设置为无边框，无法移动）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Main_MouseDown(object sender, MouseEventArgs e)
        {
            //用来释放被当前线程中某个窗口捕获的光标
            PublicClass.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);

        }

        /// <summary>
        /// 右键大小头像显示转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_HeadView_Click(object sender, EventArgs e)
        {
            if (listView_Friend.View == View.LargeIcon)//当前显示的是大头像
            {
                for (int i = 0; i < listView_Friend.Items.Count; i++)
                    listView_Friend.Items[i].Text = "  " + listView_Friend.Items[i].Text.TrimStart();
                listView_Friend.View = View.SmallIcon;
                toolStripMenuItem_HeadView.Text = "大头像";
            }
            else if (listView_Friend.View == View.SmallIcon)//当前显示的是小头像
            {
                for (int i = 0; i < listView_Friend.Items.Count; i++)
                    listView_Friend.Items[i].Text = listView_Friend.Items[i].Text.PadLeft(9, ' ');
                listView_Friend.View = View.LargeIcon;
                toolStripMenuItem_HeadView.Text = "小头像";
            }
        }

        /// <summary>
        /// 右键添加好友
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            if (listView_Friend.SelectedItems.Count > 0)//ListViewFriend有选中项
            {
                //定义为用户添加指定好友的SQL语句
                string sql = "insert into tb_Friend (HostID,FriendID) values (" + PublicClass.login_ID + "," + Convert.ToInt32(listView_Friend.SelectedItems[0].Name) + ")";
                int result = dataOperator.ExecSQLResult(sql);//执行SQL语句
                if (result == 1)//执行成功
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView_Friend.Groups[0].Items.Add(listView_Friend.SelectedItems[0]);
                    ShowFriendList();
                }
                else
                {
                    MessageBox.Show("添加失败，请稍后再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 右键删除好友
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Del_Click(object sender, EventArgs e)
        {
            if (listView_Friend.SelectedItems.Count > 0)//如果有选中项
            {
                ToolStripMenuItem_Del.Visible = true;
                //弹出好友删除确认对话框
                DialogResult result = MessageBox.Show("确实要删除该好友吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //定义删除好友的SQL语句
                    string sql = "delete from tb_Friend where HostID=" + PublicClass.login_ID + " and FriendID=" + Convert.ToInt32(listView_Friend.SelectedItems[0].Name);
                    int deleteResult = dataOperator.ExecSQLResult(sql);
                    if (deleteResult == 1)//执行成功
                    {
                        MessageBox.Show("好友已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listView_Friend.Items.Remove(listView_Friend.SelectedItems[0]);
                    }
                }
            }
            ShowFriendList();
        }

        private void textBox_Sign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//若在个性签名中按下回车键
            {
                dataOperator.ExecSQLResult("update tb_User set Sign='" + textBox_Sign.Text + "' where ID=" + PublicClass.login_ID);
                //更新个性签名
                textBox_Sign.ReadOnly = true;
                //使个性签名不可编辑
            }
        }

        private void textBox_Sign_Click(object sender, EventArgs e)
        {
            textBox_Sign.ReadOnly = false;//使个性签名可编辑
            textBox_Sign.SelectAll();//选中所有文本
        }
    }
}
