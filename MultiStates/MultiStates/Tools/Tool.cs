using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace MultiStates.Tools
{
    // 工具接口，定义鼠标响应方式
    interface Tool
    {
        /// <summary>
        /// 鼠标按下时的操作
        /// </summary>
        /// <param name="e"></param>
        void onmousedown(MouseEventArgs e);
        /// <summary>
        /// 鼠标移动时的操作
        /// </summary>
        /// <param name="e"></param>
        /// <param name="g">绘制的画布</param>
        void onmousemove(MouseEventArgs e,Graphics g);
        /// <summary>
        /// 鼠标释放时的操作
        /// </summary>
        /// <param name="e"></param>
        void onmouseup(MouseEventArgs e);
    }
}
