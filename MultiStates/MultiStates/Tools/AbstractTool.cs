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
        
        protected Point mouseDown;
        protected Point mouseMove;
        protected Point mouseUP;
        
        protected Options ops = new Options();
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
