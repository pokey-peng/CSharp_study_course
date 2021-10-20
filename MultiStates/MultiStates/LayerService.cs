using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MultiStates
{
    public class Options
    {
        public Color penColor;
        public Color brushColor;
        public int penSize;
    }
    public static class LayerService
    {
        public static bool Rubber = false;
        //public static Pen g_Pen = new Pen(Color.FromArgb(255, 0, 122, 0), 2);
        private static List<GeometryBase> GeometrySet = new List<GeometryBase>();

        public static void DrawLayer(Graphics e)
        {
            if (GetGeometryCount() == 0) return;
            foreach(GeometryBase gb in GeometrySet)
            {
                gb.draw(e);
            }
            //if (Rubber) Pop_Geometry();
        }
        
        public static int GetGeometryCount() => GeometrySet.Count;
        public static void Add_Geometry(GeometryBase gb) => GeometrySet.Add(gb);
        public static void Pop_Geometry() => GeometrySet.RemoveAt(GetGeometryCount() - 1);
    }
}
