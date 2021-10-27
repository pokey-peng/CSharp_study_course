using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

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
        // 绘制图层
        public static void DrawLayer(Graphics e)
        {
            if (GetGeometryCount() == 0) return;
            foreach(GeometryBase gb in GeometrySet)
            {
                gb.draw(e);
            }
        }
        
        public static int GetGeometryCount() => GeometrySet.Count;
        public static void ClaerGeometry()
        {
            GeometrySet = null;
            GeometrySet = new List<GeometryBase>();
        }
        public static void Add_Geometry(GeometryBase gb) => GeometrySet.Add(gb);
        public static void Pop_Geometry() => GeometrySet.RemoveAt(GetGeometryCount() - 1);
    }
}
