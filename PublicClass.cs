using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MyQQ
{
    class PublicClass
    {
        public static int login_ID;//记录当前登录用户ID

        /// <summary>
        /// 用来释放被当前线程中的窗口捕获的光标
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// 向指定的窗体发送Windows消息
        /// </summary>
        /// <param name="hwdn">窗体句柄</param>
        /// <param name="wMsg">消息内容16进制</param>
        /// <param name="mParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwdn,int wMsg,int mParam,int lParam);//向指定的窗体发送Windows消息

        /// <summary>
        /// 顶部隐藏
        /// </summary>
        /// <param name="r"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool PtInRect(ref Rectangle r, Point p);

        /// <summary>
        /// 动画效果显示窗体
        /// </summary>
        /// <param name="hwdn"></param>
        /// <param name="dwTime"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hwdn, int dwTime, int dwFlags);

        #region 本程序中需要声明的变量

        public const int LVM_SETICONAPACING = 0x1035;
        /// <summary>
        /// 该变量表示将向Windows发送的消息类型
        /// </summary>
        public const int WM_SYSCOMMAND = 0x0112;
        /// <summary>
        /// 该变量表示发送消息的附加消息
        /// </summary>
        public const int SC_MOVE = 0xF010;
        /// <summary>
        /// 该变量表示发送消息的附加消息
        /// </summary>
        public const int HTCAPTION = 0x0002;
        /// <summary>
        /// 该变量表示动画隐藏窗体
        /// </summary>
        public static int AW_HIDE = 0x00010000;
        /// <summary>
        /// 该变量表示出现滑行效果的窗体
        /// </summary>
        public static int AW_SLIDE = 0x00040000;
        /// <summary>
        /// 该变量表示从下向上开屏
        /// </summary>
        public static int AW_VER_NEGATIVE = 0x00000008;
        /// <summary>
        /// 该变量表示从上向下开屏
        /// </summary>
        public static int AW_VER_POSITIVE = 0x00000004;

        #endregion
    }
}
