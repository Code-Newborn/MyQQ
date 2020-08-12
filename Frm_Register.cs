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
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }

        DataOperator dataOperator = new DataOperator();

        /// <summary>
        /// “注册窗体”加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Register_Load(object sender, EventArgs e)
        {
            comboBox_Star.SelectedIndex = comboBox_BloodStyle.SelectedIndex = 0;
        }

        /// <summary>
        /// “注册”按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Register_Click(object sender, EventArgs e)
        {
            if (textBox_Nickname.Text.Trim() == "" || textBox_Nickname.Text.Length > 20)//验证昵称是否合适
            {
                MessageBox.Show("昵称输入有误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Nickname.Focus();
                return;
            }

            try//验证年龄文本框是否为数字
            {
                if (textBox_Age.Text.Trim() == "" || (int.Parse(textBox_Age.Text) <= 0) || (int.Parse(textBox_Age.Text) > 120))//验证年龄输入是否正确
                {
                    MessageBox.Show("请输入正确年龄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_Age.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("年龄只能是数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Age.Focus();
                return;
            }

            if (!radioButton_Male.Checked && !radioButton_Female.Checked)//验证性别按钮是否选择
            {
                MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox_Pwd.Text.Trim() == "")//验证密码是否为空
            {
                MessageBox.Show("请输入合适的密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Pwd.Focus();
                return;
            }
            if (textBox_PwdAgain.Text.Trim() == "")//验证重复密码是否为空
            {
                MessageBox.Show("请二次输入确认密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_PwdAgain.Focus();
                return;
            }
            if (textBox_Pwd.Text != textBox_PwdAgain.Text)//验证两次密码是否一致
            {
                MessageBox.Show("两次密码输入不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_PwdAgain.Focus();
                return;
            }
            int myQQNum = 0;//QQ号码
            string message;//弹出消息
            string sex = radioButton_Male.Checked ? radioButton_Male.Text : radioButton_Female.Text;
            //SQL语句在用户表中最后插入新注册用户号码
            string sql = string.Format("insert into tb_User (Pwd,NickName,Sex,Age,Name,Star,BloodType) " +
                "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');select @@Identity from tb_User",
                textBox_Pwd.Text.Trim(), textBox_Nickname.Text.Trim(), sex, textBox_Age.Text.Trim(), textBox_RealName.Text.Trim(), comboBox_Star.Text, comboBox_BloodStyle.Text);
            SqlCommand command = new SqlCommand(sql, DataOperator.connection);
            DataOperator.connection.Open();
            int result = command.ExecuteNonQuery();
            if (result == 1)//SQL语句是否执行成功
            {
                sql = "select @@Identity from tb_User";
                command = new SqlCommand(sql, DataOperator.connection);
                myQQNum = Convert.ToInt32(command.ExecuteScalar());
                message = string.Format("注册成功！你的MyQQ号码是" + myQQNum);
            }
            else
            {
                message = "注册失败，请重试！";
            }
            DataOperator.connection.Close();
            MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
