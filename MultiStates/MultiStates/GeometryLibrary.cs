using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MultiStates
{

    public enum GeoType { unknow, point, line, polyline, polygon, rectangle, circle, arc ,Ellipse}

    public class GeometryBase
    {
        protected Pen g_Pen;
        protected SolidBrush g_Brush;
        public GeometryBase(Options p) { InitOptions(p); }

        private void InitOptions(Options ops)
        {
            g_Pen = new Pen(ops.penColor, ops.penSize);
            g_Brush = new SolidBrush(ops.brushColor);
        }
        public virtual GeoType getGeoType() => GeoType.unknow;
        public virtual void draw(Graphics e) { }
    }

    public class Point2D : GeometryBase
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point2D(Options p) : base(p) 
        {
            this.x = 0;
            this.y = 0;
        }
        public Point2D(Options p,int x, int y) : base(p)
        {
            this.x = x;
            this.y = y;
        }
        public override GeoType getGeoType() => GeoType.point;
        public override void draw(Graphics e)
        {

        }
    }
    
    public class Polyline2D : GeometryBase
    {
        public Point this[int i]
        {
            set { pts[i] = value; }
            get { return pts[i]; }
        }
        public Point LastPoint
        {
            get
            {
                return pts[pts.Count() - 1];
            }
            set
            {
                pts[pts.Count() - 1] = value;
            }
        }
        public Polyline2D(Options p):base(p) { }
        protected List<Point> pts = new List<Point> { };

        public void Add_Point(Point p) => pts.Add(p);
        public void Pop_Point() => pts.RemoveAt(getPtCount() - 1);
        public List<Point> getPoints() => pts;
        public int getPtCount() => pts.Count;
        public override GeoType getGeoType() => GeoType.polyline;
        public override void draw(Graphics e)
        {
            for(int i = 1;i < pts.Count; i++)
            {
                e.DrawLine(g_Pen, pts[i-1], pts[i]);
            }
        }
    }

    public class Polygon2D : Polyline2D
    {
        private bool _fill;
        public Polygon2D(Options p,bool f) : base(p) { _fill = f; }
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

    public class Arc2D : GeometryBase
    {
        public Arc2D(Options p) : base(p) { }

    }

    public class Ellipse2D : GeometryBase
    {
        public Point leftTop { protected get; set; }
        public Point rightBottom { get; set; }
        public Ellipse2D(Options p) : base(p) { }

        public override GeoType getGeoType() => GeoType.Ellipse;

        public override void draw(Graphics e)
        {
            e.DrawEllipse(g_Pen, leftTop.X, leftTop.Y, rightBottom.X - leftTop.X, rightBottom.Y - leftTop.Y);
        }
    }

    public class Circle2D : GeometryBase
    {
        public  Point center { private get; set; }
        private float r;
        public Point endPoint { get; set; }

        public Circle2D(Options p):base(p) { }
        public override GeoType getGeoType() => GeoType.circle;
        private float GetDistance(int x1, int x2, int y1, int y2)
        {
            float radius = (float)Math.Sqrt((((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2))) * 1.0);
            return radius;
        }
        public override void draw(Graphics e)
        {
            r = GetDistance(center.X, endPoint.X, center.Y, endPoint.Y);
            e.DrawEllipse(g_Pen, center.X, center.Y, r, r);
        }
    }

    public class Rectangle2D:GeometryBase
    {
        public Point leftTop { get; set; }
        public Point rightBottom { get; set; }
        public Rectangle2D(Options p) : base(p) { }
        public override void draw(Graphics e)
        {
            e.DrawLine(g_Pen, leftTop.X, leftTop.Y, rightBottom.X, leftTop.Y);
            e.DrawLine(g_Pen, rightBottom.X, leftTop.Y, rightBottom.X, rightBottom.Y);
            e.DrawLine(g_Pen, rightBottom.X, rightBottom.Y, leftTop.X, rightBottom.Y);
            e.DrawLine(g_Pen, leftTop.X, rightBottom.Y, leftTop.X, leftTop.Y);
        }

    }

}

