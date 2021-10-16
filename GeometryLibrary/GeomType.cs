using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometryLibrary
{
    // 图形对象类型
    public enum GeomType { Unknow, Point, Line, Polyline, Polygon, Arc, Circle, Rectangle, Triangle };
    // 图形对象基类
    public class GeometryBase
    {
        public virtual GeomType GetGeomType() { return GeomType.Unknow; }

    }
    // 点对象
    public class Point : GeometryBase
    {
        readonly int x;
        readonly int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override GeomType GetGeomType() { return GeomType.Point; }

    }

    public class PolyLine : GeometryBase
    {
        public List<Point> points { get { return points; } }

        public Point this[int i] => points[i];
        public void AddPoint(int x, int y) => points.Add(new Point(x, y));
        public void AddPoint(Point pt) => points.Add(pt);
        public override GeomType GetGeomType() { return GeomType.Polyline; }
    }

    public class Polygon : PolyLine
    {
        public override GeomType GetGeomType() { return GeomType.Polygon; }
    }
}
