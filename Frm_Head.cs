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
    public partial class Frm_Head : Form
    {
        public Frm_Head()
        {
            InitializeComponent();
        }
        public Frm_EditInfo frmEditInfo;//个人信息窗体,便于在头像窗体中对信息编辑窗体的信息进行修改，类是引用类型

        private void Frm_Head_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < imageListHead.Images.Count; i++)
            {
                listView_Head.Items.Add(i.ToString());//向ListView_Head添加项
                listView_Head.Items[i].ImageIndex = i;//设置项图片索引
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (listView_Head.SelectedItems.Count != 0)//若有选中头像
            {
                int headID = listView_Head.SelectedItems[0].ImageIndex;//图片索引作为头像ID
                frmEditInfo.ShowHead(headID);//在信息编辑页面中刷新显示ID对应的头像
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择一个头像！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 头像选择窗体  中双击以更改用户头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Head_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int headID = listView_Head.SelectedItems[0].ImageIndex;
            frmEditInfo.ShowHead(headID);
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
