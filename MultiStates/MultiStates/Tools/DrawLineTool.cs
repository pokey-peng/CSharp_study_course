using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
//using MultiStates;

namespace MultiStates.Tools
{
    class DrawLineTool : AbstractTool
    {
        private Point _startPoint;
        private Point _endPoint;
        private Polyline2D _line;
        public bool _dragging = false;
        public DrawLineTool(Options p) : base(p) {}
        public override void onmousedown(MouseEventArgs e)
        {
            // 构造图形对象
            base.onmousedown(e);
            if(e.Button == MouseButtons.Left)
            {
                if (_dragging)
                {
                    _endPoint = mouseDown;
                    _line.Add_Point(_endPoint);
                    LayerService.Add_Geometry(_line);
                    _dragging = false;
                    
                }
                else
                {
                    _startPoint = mouseDown;
                    _line = new Polyline2D(ops);
                    _line.Add_Point(_startPoint);
                    _dragging = true;
                }
            }
            
        }
        // 橡皮筋效果实现
        public override void onmousemove(MouseEventArgs e,Graphics g)
        {
            base.onmousemove(e, g);
            if (_dragging)
            {
                if (_line.getPtCount() < 2)
                    _line.Add_Point(mouseMove);
                else
                    _line[1] = mouseMove;
                _line.draw(g);
            }
        }
    }

    class DrawEllipse : AbstractTool
    {
        private Point leftTop;
        private Point rightBottom;
        private Ellipse2D _ellipse;
        private bool _dragging = false;
        public DrawEllipse(Options p) : base(p) { }

        public override void onmousedown(MouseEventArgs e)
        {

            base.onmousedown(e);
            if (e.Button == MouseButtons.Left)
            {
                if (_dragging)
                {
                    rightBottom = mouseDown;
                    _ellipse.rightBottom = rightBottom;
                    LayerService.Add_Geometry(_ellipse);
                    _dragging = false;

                }
                else
                {
                    _ellipse = new Ellipse2D(ops);
                    leftTop = mouseDown;
                    _ellipse.leftTop = leftTop;
                    _dragging = true;
                }
            }

        }
        public override void onmousemove(MouseEventArgs e, Graphics g)
        {
            base.onmousemove(e, g);
            if (_dragging)
            {
                _ellipse.rightBottom = mouseMove;
                _ellipse.draw(g);
            }
        }
    }

    class DrawCircle : AbstractTool
    {
        private Point leftTop;
        private Point rightBottom;
        private bool _dragging;
        private Circle2D _circle;

        public DrawCircle(Options p) : base(p) { }
        public override void onmousedown(MouseEventArgs e)
        {

            base.onmousedown(e);
            if (e.Button == MouseButtons.Left)
            {
                if (_dragging)
                {
                    rightBottom = mouseDown;
                    _circle.endPoint = rightBottom;
                    LayerService.Add_Geometry(_circle);
                    _dragging = false;

                }
                else
                {
                    _circle = new Circle2D(ops);
                    leftTop = mouseDown;
                    _circle.center = leftTop;
                    _dragging = true;
                }
            }

        }

        public override void onmousemove(MouseEventArgs e, Graphics g)
        {
            base.onmousemove(e, g);
            if (_dragging)
            {
                _circle.endPoint = mouseMove;
                _circle.draw(g);
            }
        }

    }

    class DrawRectangle:AbstractTool
    {
        private Point startP;
        private Point endP;
        private Rectangle2D _rectangle;
        private bool _dragging;
        public DrawRectangle(Options p) : base(p) { }
        public override void onmousedown(MouseEventArgs e)
        {

            base.onmousedown(e);
            if (e.Button == MouseButtons.Left)
            {
                if (_dragging)
                {
                    endP = mouseDown;
                    _rectangle.rightBottom = endP;
                    LayerService.Add_Geometry(_rectangle);
                    _dragging = false;

                }
                else
                {
                    _rectangle = new Rectangle2D(ops);
                    startP = mouseDown;
                    _rectangle.leftTop = startP;
                    _dragging = true;
                }
            }

        }

        public override void onmousemove(MouseEventArgs e, Graphics g)
        {
            base.onmousemove(e, g);
            if (_dragging)
            {
                _rectangle.rightBottom = mouseMove;
                _rectangle.draw(g);
            }
        }


    }

    class DrawPolyline:AbstractTool
    {
        private bool _dragging;
        private Polyline2D _polyline = null;
        public DrawPolyline(Options p) : base(p) { }

        public override void onmousedown(MouseEventArgs e)
        {

            base.onmousedown(e);
            if (e.Button == MouseButtons.Right)
            {
                _dragging = false;
                LayerService.Add_Geometry(_polyline);
            }
            else
            {
                if(_dragging)
                {
                    _polyline.Add_Point(mouseDown);
                }
                else
                {
                    _polyline = new Polyline2D(ops);
                    _polyline.Add_Point(mouseDown);
                    _dragging = true;
                }
                
            }

        }

        public override void onmousemove(MouseEventArgs e, Graphics g)
        {
            base.onmousemove(e, g);
            if (_dragging)
            {
                _polyline.Add_Point(mouseMove);
                _polyline.draw(g);
                _polyline.Pop_Point();
            }
        }

    }

    class DrawPolygon:AbstractTool
    {
        private bool _dragging;
        private Polygon2D _polygon = null;
        private bool _fill;

        public DrawPolygon(Options p,bool f) : base(p) { _fill = f; }
        public override void onmousedown(MouseEventArgs e)
        {

            base.onmousedown(e);
            if (e.Button == MouseButtons.Right)
            {
                _dragging = false;
                LayerService.Add_Geometry(_polygon);
            }
            else
            {
                if (_dragging)
                {
                    _polygon.Add_Point(mouseDown);
                }
                else
                {
                    _polygon = new Polygon2D(ops,_fill);
                    _polygon.Add_Point(mouseDown);
                    _dragging = true;
                }

            }

        }

        public override void onmousemove(MouseEventArgs e, Graphics g)
        {
            base.onmousemove(e, g);
            if (_dragging)
            {
                _polygon.Add_Point(mouseMove);
                _polygon.draw(g);
                _polygon.Pop_Point();
            }
        }

    }
}

