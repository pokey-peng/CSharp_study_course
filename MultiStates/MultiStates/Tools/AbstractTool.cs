using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MultiStates.Tools
{
    abstract class AbstractTool : Tool
    {
        /// <summary>
        /// 定义鼠标按下，移动，和释放时的坐标点
        /// </summary>
        protected Point mouseDown;
        protected Point mouseMove;
        protected Point mouseUP;
        /// <summary>
        /// 定义绘制的样式信息
        /// </summary>
        protected Options ops;
        
        protected AbstractTool(Options p)
        {
            ops = p;
        }

        public virtual void onmousedown(MouseEventArgs e) { mouseDown = new Point(e.X, e.Y); }
        public virtual void onmousemove(MouseEventArgs e,Graphics g) { mouseMove = new Point(e.X, e.Y); }
        public virtual void onmouseup(MouseEventArgs e) { mouseUP = new Point(e.X, e.Y); }
        public virtual void onmouseclick(MouseEventArgs e) { }
    }
}
