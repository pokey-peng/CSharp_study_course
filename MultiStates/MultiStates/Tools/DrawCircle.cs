using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MultiStates.Tools
{
    //class DrawCircle : AbstractTool
    //{
    //    private Point leftTop;
    //    private Point rightBottom;
    //    private bool _dragging;
    //    private Circle2D _circle;

    //    public DrawCircle(Pen p) : base(p) { }
    //    public override void onmousedown(MouseEventArgs e)
    //    {

    //        base.onmousedown(e);
    //        if (e.Button == MouseButtons.Left)
    //        {
    //            if (_dragging)
    //            {
    //                rightBottom = mouseDown;
    //                _circle.endPoint = rightBottom;
    //                LayerService.Add_Geometry(_circle);
    //                _dragging = false;

    //            }
    //            else
    //            {
    //                _circle = new Circle2D(_pen);
    //                leftTop = mouseDown;
    //                _circle.center = leftTop;
    //                _dragging = true;
    //            }
    //        }

    //    }

    //    public override void onmousemove(MouseEventArgs e,Graphics g)
    //    {
    //        base.onmousemove(e,g);
    //        if (_dragging)
    //        {
    //            _circle.endPoint = mouseMove;
    //            _circle.draw(g);
    //        }
    //    }

    //}
}
