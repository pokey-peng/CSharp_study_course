using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MultiStates
{
    public enum GeoType { unknow, point, line, polyline, polygon, rectangle, circle, arc, Ellipse }

    /// <summary>
    /// 图形对象基类
    /// </summary>
    public class GeometryBase
    {
        public virtual Pen g_Pen { get; set; }
        public virtual SolidBrush g_Brush { get; set; }
        protected bool _fill = false;

        public GeometryBase(Options p)
        {
            InitOptions(p);
        }

        public GeometryBase(Options p, bool f)
        {
            InitOptions(p); _fill = f;
        }

        // 初始化样式信息
        private void InitOptions(Options ops)
        {
            g_Pen = new Pen(ops.penColor, ops.penSize);
            g_Brush = new SolidBrush(ops.brushColor);
        }

        public virtual GeoType getGeoType() => GeoType.unknow;

        // 绘制图形
        public virtual void draw(Graphics e) { }
    }

    /// <summary>
    /// 点对象
    /// </summary>
    public class Point2D : GeometryBase
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point2D(Options p) : base(p)
        {
            this.x = 0;
            this.y = 0;
        }

        public Point2D(Options p, int x, int y) : base(p)
        {
            this.x = x;
            this.y = y;
        }

        public override GeoType getGeoType() => GeoType.point;

        public override void draw(Graphics e)
        {
        }
    }

    /// <summary>
    /// 折线对象
    /// </summary>
    public class Polyline2D : GeometryBase
    {
        public Point this[int i]
        {
            set { pts[i] = value; }
            get { return pts[i]; }
        }

        public Polyline2D(Options p) : base(p)
        {
        }

        protected List<Point> pts = new List<Point> { };

        public void Add_Point(Point p) => pts.Add(p);

        public void Pop_Point() => pts.RemoveAt(getPtCount() - 1);

        public List<Point> getPoints() => pts;

        public int getPtCount() => pts.Count;

        public override GeoType getGeoType() => GeoType.polyline;

        public override void draw(Graphics e)
        {
            for (int i = 1; i < pts.Count; i++)
            {
                e.DrawLine(g_Pen, pts[i - 1], pts[i]);
            }
        }
    }

    /// <summary>
    /// 多边形
    /// </summary>
    public class Polygon2D : Polyline2D
    {
        //private bool _fill;
        public Polygon2D(Options p, bool f) : base(p) { _fill = f; }

        public override GeoType getGeoType() => GeoType.polygon;

        public override void draw(Graphics e)
        {
            int i = 0;
            for (i = 1; i < pts.Count; i++)
            {
                e.DrawLine(g_Pen, pts[i - 1], pts[i]);
            }
            e.DrawLine(g_Pen, pts[i - 1], pts[0]);
            if (_fill)
            {
                Point[] pt = pts.ToArray();
                e.FillPolygon(g_Brush, pt);
            }
        }
    }

    /// <summary>
    /// 圆弧
    /// </summary>
    public class Arc2D : GeometryBase
    {
        public Arc2D(Options p) : base(p)
        {
        }
    }

    /// <summary>
    /// 椭圆
    /// </summary>
    public class Ellipse2D : GeometryBase
    {
        public Point leftTop { get; set; }
        public Point rightBottom { get; set; }

        public Ellipse2D(Options p) : base(p)
        {
        }

        public override GeoType getGeoType() => GeoType.Ellipse;

        public override void draw(Graphics e)
        {
            e.DrawEllipse(g_Pen, leftTop.X, leftTop.Y, rightBottom.X - leftTop.X, rightBottom.Y - leftTop.Y);
        }
    }

    /// <summary>
    /// 圆
    /// </summary>
    public class Circle2D : GeometryBase
    {
        public Point center { get; set; }
        public Point endPoint { get; set; }
        private int leftX = 0, leftY = 0;
        private int width = 0, height = 0;

        public Circle2D(Options p) : base(p)
        {
        }

        public Circle2D(Options p, bool f) : base(p, f)
        {
        }

        public override GeoType getGeoType() => GeoType.circle;

        private void GetXYdh()
        {
            int dx = Math.Abs(center.X - endPoint.X);
            int dy = Math.Abs(center.Y - endPoint.Y);
            int radius = (int)(Math.Sqrt(dx * dx + dy * dy));
            width = radius + radius;
            height = radius + radius;
            leftX = center.X - radius;
            leftY = center.Y - radius;
        }

        public override void draw(Graphics e)
        {
            GetXYdh();
            e.DrawEllipse(g_Pen, leftX, leftY, width, height);
            if (_fill)
                e.FillEllipse(g_Brush, leftX, leftY, width, height);
        }
    }

    /// <summary>
    /// 矩形
    /// </summary>
    public class Rectangle2D : GeometryBase
    {
        public Point leftTop { get; set; }
        public Point rightBottom { get; set; }
        private int leftX = 0;
        private int leftY = 0;
        private int width = 0, height = 0;

        public Rectangle2D(Options p) : base(p)
        {
        }

        public Rectangle2D(Options p, bool f) : base(p, f)
        {
        }

        private void ChangeLeftRight()
        {
            width = Math.Abs(leftTop.X - rightBottom.X);
            height = Math.Abs(leftTop.Y - rightBottom.Y);
            if (leftTop.X > rightBottom.X) { leftX = rightBottom.X; }
            else { leftX = leftTop.X; }
            if (leftTop.Y > rightBottom.Y) { leftY = rightBottom.Y; }
            else { leftY = leftTop.Y; }
        }
        public override GeoType getGeoType() => GeoType.rectangle;

        public override void draw(Graphics e)
        {
            e.DrawLine(g_Pen, leftTop.X, leftTop.Y, rightBottom.X, leftTop.Y);
            e.DrawLine(g_Pen, rightBottom.X, leftTop.Y, rightBottom.X, rightBottom.Y);
            e.DrawLine(g_Pen, rightBottom.X, rightBottom.Y, leftTop.X, rightBottom.Y);
            e.DrawLine(g_Pen, leftTop.X, rightBottom.Y, leftTop.X, leftTop.Y);
            if (_fill)
                ChangeLeftRight();
            e.FillRectangle(g_Brush, leftX, leftY, width, height);
        }
    }
}