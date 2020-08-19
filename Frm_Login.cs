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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        DataOperator dataOperator = new DataOperator();

        /// <summary>
        /// 验证账户输入是否有效
        /// </summary>
        /// <returns></returns>
        public bool ValidateInput()
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹窗提示
                textBox_ID.Focus();//使登录账号文本框获得焦点
                return false;
            }
            else if (int.Parse(textBox_ID.Text.Trim()) > 65535)
            {
                MessageBox.Show("请输入正确的登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_ID.Focus();//使登录账号文本框获得焦点
                return false;
            }
            else if (textBox_ID.Text.Trim() != "" && textBox_Pwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Pwd.Focus();//使登录密码文本框获得焦点
                return false;
            }
            return true;
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 账户文本框只允许输入“数字键”“回车键”“删除键”
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b')//只能按下三个键
            {
                if (e.KeyChar == '\r')
                    textBox_Pwd.Focus();
                e.Handled = false;//按键有效

            }
            else
                e.Handled = true;//按键无效
        }

        private void pictureBox_Login_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                //SQL语句
                string sql = "select count(*) from tb_User where ID=" + int.Parse(textBox_ID.Text.Trim()) + "and Pwd = '" + textBox_Pwd.Text.Trim() + "'";
                int num = dataOperator.ExecSQL(sql);
                if (num == 1)
                {
                    PublicClass.login_ID = int.Parse(textBox_ID.Text.Trim());
                    if (checkBox_Remember.Checked)
                    {
                        dataOperator.ExecSQLResult("update tb_User set Remember=1 where ID=" + int.Parse(textBox_ID.Text.Trim()));//更新数据库“记住密码”标识
                        if (checkBox_AutoLogin.Checked)
                        {
                            dataOperator.ExecSQLResult("update tb_User set AutoLogin=1 where ID=" + int.Parse(textBox_ID.Text.Trim()));//更新数据库“自动登录”标识
                        }
                    }
                    else
                    {
                        dataOperator.ExecSQLResult("update tb_User set Remember=0 where ID=" + int.Parse(textBox_ID.Text.Trim()));
                        dataOperator.ExecSQLResult("update tb_User set AutoLogin=0 where ID=" + int.Parse(textBox_ID.Text.Trim()));
                    }
                    dataOperator.ExecSQLResult("update tb_User set Flag=1 where ID=" + int.Parse(textBox_ID.Text.Trim()));//设置在线状态Flag=1为在线，Flag=0为离线
                    Frm_Main frmMain = new Frm_Main();//创建主窗体对象
                    frmMain.Show();//显示主界面
                    this.Visible = false;//隐藏登录窗体
                }
                else
                {
                    MessageBox.Show("输入的用户名或密码错误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox_Pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                pictureBox_Login_Click(sender, e);
            }
        }

        private void checkBox_Remember_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Remember.Checked)
            {
                checkBox_AutoLogin.Checked = false;
            }
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            string sql = "select Pwd,Remember,AutoLogin from tb_User where ID=" + (textBox_ID.Text.Trim() == "" ? "000000000" : textBox_ID.Text.Trim());
            DataSet ds = dataOperator.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)//输入的ID是否存在
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)//检测数据库中账号的“remember”标志
                {
                    checkBox_Remember.Checked = true;
                    textBox_Pwd.Text = ds.Tables[0].Rows[0][0].ToString();
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)//检测数据库中账号的“autoLogin”标志
                    {
                        checkBox_AutoLogin.Checked = true;
                        pictureBox_Login_Click(sender, e);//自动登录
                    }
                }
            }
        }

        private void linkLabel_Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Register frm_Register = new Frm_Register();
            frm_Register.Show();
        }

        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Frm_Login_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();
            //向Window发送拖动窗体的消息，登录窗体可拖动了
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);
        }
    }
}
