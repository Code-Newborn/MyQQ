using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_AddFriend : Form
    {
        public Frm_AddFriend()
        {
            InitializeComponent();
        }
        DataOperator dataOperator = new DataOperator();//数据库操作类
        private DataSet dataSet;

        private void Frm_AddFriend_Load(object sender, EventArgs e)
        {
            //获取除掉自己以外的所有账号信息
            string sql = "select ID,NickName,Age,Sex from tb_User where ID <> " + PublicClass.login_ID;
            dataSet = dataOperator.GetDataSet(sql);
            //指定DatagridView的数据源
            dataGridView_BasicResult.DataSource = dataSet.Tables[0];
            dataGridView_AdvancedResult.DataSource = dataSet.Tables[0];
        }

        private void BasicSearch()
        {
            string sql = "select ID,NickName,Age,Sex from tb_User";
            if (radioButton_DetailSearch.Checked == true)
            {
                if (textBox_ID.Text.Trim() == "" && textBox_NickName.Text.Trim() == "")
                {
                    MessageBox.Show("请输入查询条件!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (textBox_ID.Text.Trim() != "")
                {
                    sql += string.Format(" where ID={0}", int.Parse(textBox_ID.Text.Trim()));
                }
                else
                {
                    sql += string.Format(" where NickName like '%{0}%'", textBox_NickName.Text.Trim());
                }
            }
            dataGridView_BasicResult.DataSource = dataOperator.GetDataSet(sql).Tables[0];

            dataGridView_BasicResult.Location = panel_BasicCondition.Location;
            panel_BaseResult.Visible = true;
            button_Add.Visible = true;
            button_Back.Visible = true;
            groupBox_BaseCondition.Visible = false;
        }


        private void AdvancedSearch()
        {
            string sql = "select ID,NickName,Age,Sex from tb_User";
            string strAge = "";
            string strSex = comboBox_Sex.Text;
            switch (comboBox_Age.SelectedIndex)//将索引文本转换成SQL部分语句
            {
                case 1:
                    strAge = "Age>0 and Age<10";
                    break;
                case 2:
                    strAge = " Age>=10 and Age<20";
                    break;
                case 3:
                    strAge = " Age>=20 and Age<30";
                    break;
                case 4:
                    strAge = " Age>=30 and Age<40";
                    break;
                case 5:
                    strAge = " Age>=40 and Age<50";
                    break;
                case 6:
                    strAge = " Age>=50";
                    break;
                default:
                    strAge = "";
                    break;
            }
            if (strAge == "" && strSex == "")//判断是否选中了查询条件
            {
                MessageBox.Show("还没有选择查询条件呢！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else//组合查询条件
            {
                if (strAge != "" && strSex == "")
                {
                    sql += " where " + strAge;
                }
                else if (strAge == "" && strSex != "")
                {
                    sql += " where Sex='" + strSex + "'";
                }
                else
                {
                    sql += string.Format(" where " + strAge + " and Sex='" + strSex + "'");
                }
            }
            dataGridView_AdvancedResult.DataSource = dataOperator.GetDataSet(sql).Tables[0];//填充DataSet

            //设置控件的属性
            panel_AdvancedResult.Location = panel_AdvancedCondition.Location;
            panel_AdvancedResult.Visible = true;//高级查询结果显示
            button_Add.Visible = true;//显示添加好友按钮
            button_Back.Visible = true;//显示上一步按钮
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            panel_BaseResult.Visible = false;
            panel_AdvancedResult.Visible = false;
            panel_SearchType.Visible = true;
            panel_AdvancedCondition.Visible = true;
            button_Back.Visible = false;
            button_Add.Visible = false;
            groupBox_BaseCondition.Visible = true;
        }

        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗口最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        /// <summary>
        /// 窗体拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_AddFriend_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 基本查找和精确查找按钮切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_DetailSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_DetailSearch.Checked == true)//如果精确查找单选按钮选中
            {
                groupBox_BaseCondition.Visible = true;//显示精确查找条件的容器
            }
            else
            {
                groupBox_BaseCondition.Visible = false;//隐藏精确查找条件的容器
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (tabControl_Search.SelectedIndex == 0) //基本查找选项卡选中
            {
                BasicSearch();//基本查找
            }
            else  //高级查找选项卡选中
            {
                AdvancedSearch();//高级查找
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int friendID = GetSelectFriendID();
            if (friendID == -1)
            {
                MessageBox.Show("请选择一个好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (HasAdded(friendID))
            {
                MessageBox.Show("对方已经是您的好友，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "select FriendLimitID from tb_User where ID=" + friendID;
            int friendLimitID = dataOperator.ExecSQL(sql);
            if (friendLimitID == 1)
            {
                sql = "insert into tb_Friend (HostID,FriendID) values (" + PublicClass.login_ID + "," + friendID + ")";
                int result = dataOperator.ExecSQLResult(sql);
                if (result == 1)
                {
                    MessageBox.Show("添加成功，请刷新好友列表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (friendLimitID == 2)
            {
                sql = "insert into tb_Message (FromUserID, ToUserID, MessageTypeID, MessageState) values (" + PublicClass.login_ID + "," + friendID + ",2,0)";
                int result = dataOperator.ExecSQLResult(sql);
                if (result == 1)
                {
                    MessageBox.Show("对方需要身份验证才可以被加为好友，已发出请求！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(friendLimitID==3)
            {
                MessageBox.Show("对方不允许任何人加他为好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 获取选中好友的ID
        /// </summary>
        /// <returns></returns>
        private int GetSelectFriendID()
        {
            int friendID = -1;
            if (tabControl_Search.SelectedIndex == 0)//基本查找选项卡
            {
                if (dataGridView_BasicResult.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请选择一个好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dataGridView_BasicResult.SelectedRows[0].Cells[0] != null)//保证选中行的第一列有值
                {
                    friendID = int.Parse(dataGridView_BasicResult.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else if (tabControl_Search.SelectedIndex == 1)//高级查找选项卡
            {
                if (dataGridView_AdvancedResult.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请选择一个好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dataGridView_AdvancedResult.SelectedRows[0].Cells[0] != null)
                {
                    friendID = int.Parse(dataGridView_AdvancedResult.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            return friendID;//返回选中好友的ID
        }

        private bool HasAdded(int friendID)
        {
            //SQL查询语句
            string sql = "select count(*) from tb_Friend where HostID=" + PublicClass.login_ID + "and FriendID=" + friendID;
            int result = dataOperator.ExecSQL(sql);//执行查询
            bool returnValue = result > 0 ? true : false;//好友是否已添加
            return returnValue;
        }
    }
}
