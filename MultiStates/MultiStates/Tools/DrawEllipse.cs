using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace MultiStates.Tools
{
    //class DrawEllipse: AbstractTool
    //{
    //    private Point leftTop;
    //    private Point rightBottom;
    //    private Ellipse2D _ellipse;
    //    private bool _dragging = false;
    //    public DrawEllipse(Pen p) : base(p) { }

    //    public override void onmousedown(MouseEventArgs e)
    //    {

    //        base.onmousedown(e);
    //        if (e.Button == MouseButtons.Left)
    //        {
    //            if (_dragging)
    //            {
    //                rightBottom = mouseDown;
    //                _ellipse.rightBottom = rightBottom;
    //                LayerService.Add_Geometry(_ellipse);
    //                _dragging = false;

    //            }
    //            else
    //            {
    //                _ellipse = new Ellipse2D(_pen);
    //                leftTop = mouseDown;
    //                _ellipse.leftTop = leftTop;
    //                _dragging = true;
    //            }
    //        }

    //    }

    //    public override void onmousemove(MouseEventArgs e, Graphics g)
    //    {
    //        base.onmousemove(e, g);
    //        if (_dragging)
    //        {
    //            _ellipse.rightBottom = mouseMove;
    //            _ellipse.draw(g);
    //        }
    //    }
    //}

    
}
