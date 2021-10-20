using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace MultiStates.Tools
{
    interface Tool
    {
        void onmousedown(MouseEventArgs e);

        void onmousemove(MouseEventArgs e,Graphics g);

        void onmouseup(MouseEventArgs e);
    }
}
