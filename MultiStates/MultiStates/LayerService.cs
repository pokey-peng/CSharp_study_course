using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using MultiStates.DAL;

namespace MultiStates
{
    /// <summary>
    /// 样式选项
    /// </summary>
    public class Options
    {
        public Color penColor { get; set; }
        public Color brushColor { get; set; }
        public int penSize { get; set; }
    }

    /// <summary>
    /// 用于存放图形对象的图层
    /// </summary>
    public static class LayerService
    {
        // 存放图形对象
        private static List<GeometryBase> GeometrySet = new List<GeometryBase>();

        public static string layerName = "none";
        public static Boolean isSave = false;

        // 绘制图层
        public static void DrawLayer(Graphics e)
        {
            if (GetGeometryCount() == 0) return;
            foreach (GeometryBase gb in GeometrySet)
            {
                gb.draw(e);
            }
        }
        // 获取图层几何对象集合
        public static List<GeometryBase> getGeometrySet()
        {
            return GeometrySet;
        }
        // 获取图层几何对象个数
        public static int GetGeometryCount() => GeometrySet.Count;
        // 清空图层几何对象
        public static void ClaerGeometry()
        {
            if (GeometrySet.Count == 0) return;
            GeometrySet.Clear();
        }
        // 添加一个几何对象到图层
        public static void Add_Geometry(GeometryBase gb) => GeometrySet.Add(gb);
        // 删除图层中最后一个几何对象
        public static void Pop_Geometry() => GeometrySet.RemoveAt(GetGeometryCount() - 1);
        // 将图层中的几何对象转为几何图形信息表
        public static GeometryInfoTable getTableFromLayer()
        {
            GeometryInfoTable geoTable = new GeometryInfoTable();
            GeometryInfo geoInfo = new GeometryInfo();
            foreach (GeometryBase geo in GeometrySet)
            {
                geoInfo = GeoToInfo(geo);
                geoTable.addGeometryInfo(geoInfo);
            }
            return geoTable;
        }
        // 将一个几何对象转为一条几何图形信息
        private static GeometryInfo GeoToInfo(GeometryBase geo)
        {
            List<Point> pts = null;
            GeometryInfo geoInfo = new GeometryInfo();
            switch (geo.getGeoType())
            {
                case GeoType.polygon:
                case GeoType.polyline:
                    Polyline2D polyline = (Polyline2D)geo;
                    geoInfo.geometry = polyline.getPoints();
                    break;

                case GeoType.Ellipse:
                    Ellipse2D ellipse = (Ellipse2D)geo;
                    pts = new List<Point>();
                    pts.Add(ellipse.leftTop);
                    pts.Add(ellipse.rightBottom);
                    geoInfo.geometry = pts;
                    break;

                case GeoType.circle:
                    Circle2D circle = (Circle2D)geo;
                    pts = new List<Point>();
                    pts.Add(circle.center);
                    pts.Add(circle.endPoint);
                    geoInfo.geometry = pts;
                    break;

                case GeoType.rectangle:
                    Rectangle2D rectangle = (Rectangle2D)geo;
                    pts = new List<Point>();
                    pts.Add(rectangle.leftTop);
                    pts.Add(rectangle.rightBottom);
                    geoInfo.geometry = pts;
                    break;

                default:
                    break;
            }
            geoInfo.brushColor = geo.g_Brush.Color.ToArgb();
            geoInfo.penColor = geo.g_Pen.Color.ToArgb();
            geoInfo.penSize = (int)geo.g_Pen.Width;
            geoInfo.sid = 0;
            geoInfo.layerName = layerName;
            geoInfo.geometryType = geo.getGeoType().ToString();
            return geoInfo;
        }
        // 将几何图形信息表的所有图形载入到新图层中
        public static void LoadTable(GeometryInfoTable geoTable,Boolean newLayer = true)
        {
            if (newLayer) ClaerGeometry();
            for(int i = 0;i < geoTable.Count();i++)
            {
                Options op = new Options()
                {
                    penColor = Color.FromArgb(geoTable[i].penColor),
                    brushColor = Color.FromArgb(geoTable[i].brushColor),
                    penSize = geoTable[i].penSize
                };
                LoadGeoFromInfo(geoTable[i],op);
            }
        }
        private static void LoadGeoFromInfo(GeometryInfo geoInfo,Options op)
        {
            switch(geoInfo.geometryType)
            {
                case "polyline":
                    GeometrySet.Add(ToPolyline(geoInfo,op));
                    break;
                case "circle":
                    GeometrySet.Add(ToCircle(geoInfo, op));
                    break;
                case "Ellipse":
                    GeometrySet.Add(ToEllipse(geoInfo, op));
                    break;
                case "rectangle":
                    GeometrySet.Add(ToRectangle(geoInfo, op));
                    break;
                case "polygon":
                    GeometrySet.Add(ToPolygon(geoInfo, op));
                    break;
            }
        }
        private static Polyline2D ToPolyline(GeometryInfo geoInfo,Options op)
        {
            
            Polyline2D polyline = new Polyline2D(op);
            for(int i = 0;i<geoInfo.geometry.Count;i++)
            {
                polyline.Add_Point(geoInfo.geometry[i]);
            }
            return polyline;

        }
        private static Polygon2D ToPolygon(GeometryInfo geoInfo,Options op)
        {
            Polygon2D polygon = new Polygon2D(op,false);
            for (int i = 0; i < geoInfo.geometry.Count; i++)
            {
                polygon.Add_Point(geoInfo.geometry[i]);
            }
            return polygon;
        }
        private static Ellipse2D ToEllipse(GeometryInfo geoInfo,Options op)
        {
            Ellipse2D ellipse = new Ellipse2D(op);
            ellipse.leftTop = geoInfo.geometry[0];
            ellipse.rightBottom = geoInfo.geometry[1];
            return ellipse;
        }
        private static Circle2D ToCircle(GeometryInfo geoInfo,Options op)
        {
            Circle2D circle = new Circle2D(op);
            circle.center = geoInfo.geometry[0];
            circle.endPoint = geoInfo.geometry[1];
            return circle;
        }
        private static Rectangle2D ToRectangle(GeometryInfo geoInfo,Options op)
        {
            Rectangle2D rectangle = new Rectangle2D(op);
            rectangle.leftTop = geoInfo.geometry[0];
            rectangle.rightBottom = geoInfo.geometry[1];
            return rectangle;
        }
    }
}