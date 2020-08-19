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
    public partial class Frm_EditInfo : Form
    {
        public Frm_Main frmMain;
        public Frm_EditInfo()
        {
            InitializeComponent();
        }
        DataOperator dataOperator = new DataOperator();

        public void ShowHead(int headID)
        {
            pictureBox_head.Image = imageList_Head.Images[headID];
            pictureBox_head.Tag = headID;//设置Tag属性，在拼接更新SQL语句时使用
        }

        private void Frm_EditInfo_Load(object sender, EventArgs e)
        {
            int headID = 0;
            int friendLimitID = 0;
            string sql = "select * from tb_User where ID=" + PublicClass.login_ID + "";
            SqlDataReader dataReader = dataOperator.GetDataReader(sql);//获取登录ID的全部信息
            if (dataReader.Read())
            {
                textBox_ID.Text = dataReader["ID"].ToString();//设置ID信息
                textBox_nickName.Text = dataReader["NickName"].ToString();//设置昵称信息
                comboBox_sex.Text = dataReader["Sex"].ToString();//设置性别信息
                if (!(dataReader["Name"] is DBNull))
                {
                    textBox_realName.Text = dataReader["Name"].ToString();//设置真实姓名信息
                }
                textBox_age.Text = dataReader["Age"].ToString();//设置年龄信息
                textBox_oldPwd.Text = dataReader["Pwd"].ToString();//设置旧密码信息
                if (!(dataReader["Star"] is DBNull))
                {
                    comboBox_star.Text = dataReader["Star"].ToString();//设置星座信息
                }
                if (!(dataReader["BloodType"] is DBNull))
                {
                    comboBox_bloodType.Text = dataReader["BloodType"].ToString();//设置血型信息
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);//获取头像ID
                friendLimitID = Convert.ToInt32(dataReader["FriendLimitID"]);//获取添加好友限制信息
            }
            dataReader.Close();
            DataOperator.connection.Close();
            ShowHead(headID);//显示登录头像
            switch (friendLimitID)
            {
                case 1:
                    radioButton_Anybody.Checked = true;
                    break;
                case 2:
                    radioButton_Validation.Checked = true;
                    break;
                case 3:
                    radioButton_Nobody.Checked = true;
                    break;
                default:
                    radioButton_Anybody.Checked = true;
                    break;
            }
        }

        private void button_showHead_Click(object sender, EventArgs e)
        {
            Frm_Head frmHead = new Frm_Head();
            frmHead.frmEditInfo = this;//设置头像窗体中的个人信息窗体为当前窗体
            frmHead.Show();
        }

        /// <summary>
        /// 验证用户输入是否恰当
        /// </summary>
        /// <returns></returns>
        private bool ValidateInput()
        {
            if (textBox_nickName.Text.Trim() == "" || textBox_nickName.Text.Length > 20)
            {
                MessageBox.Show("昵称输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_nickName.Focus();
                return false;
            }
            if (textBox_age.Text.Trim() == "")
            {
                MessageBox.Show("请输入年龄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_age.Focus();
                return false;
            }
            if (comboBox_sex.Text.Trim() == "")
            {
                MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_sex.Focus();
                return false;
            }
            if (textBox_newPwd.Text.Trim() != textBox_newPwdAgain.Text.Trim())
            {
                MessageBox.Show("两次输入密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_newPwdAgain.Focus();
                return false;
            }
            return true;
        }

        private string GetUpdateSQL()
        {
            string sql = string.Format("update tb_User set NickName='{0}',HeadID={1},Sex='{2}',Age={3}",
                textBox_nickName.Text.Trim(), Convert.ToInt32(pictureBox_head.Tag), comboBox_sex.Text, Convert.ToInt32(textBox_age.Text.Trim()));
            if (textBox_newPwd.Text.Trim() != "")
            {
                sql = string.Format("{0},Pwd='{1}',Remember=0,AutoLogin=0", sql, textBox_newPwd.Text.Trim());

            }
            int friendLimitID = 0;
            if (radioButton_Anybody.Checked)
            {
                friendLimitID = Convert.ToInt32(radioButton_Anybody.Tag);
            }
            else if (radioButton_Validation.Checked)
            {
                friendLimitID = Convert.ToInt32(radioButton_Validation.Tag);
            }
            else if (radioButton_Nobody.Checked)
            {
                friendLimitID = Convert.ToInt32(radioButton_Nobody.Tag);
            }
            sql = string.Format("{0},FriendLimitID={1},Name='{2}',Star='{3}',BloodType='{4}' where ID={5}",
                sql, friendLimitID, textBox_realName.Text.Trim(), comboBox_star.Text, comboBox_bloodType.Text, PublicClass.login_ID);
            return sql;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//用户输入合适
            {
                string sql = GetUpdateSQL();//获取执行的SQL语句
                int result = dataOperator.ExecSQLResult(sql);
                if (result == 1)
                {
                    MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("数据保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmMain.ShowUserInfo();
                this.Close();
            }
        }

        //关闭窗体
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
