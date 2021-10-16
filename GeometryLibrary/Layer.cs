using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Layer
    {
        //public int width { get; set; }
        //public int height { get; set; }
        //public Layer()
        //{
        //    width = 
        //}
        public List<GeometryBase> geometrySet;
        public void Add_Geometry(GeometryBase geoBase) => geometrySet.Add(geoBase);

        public int GetGeometryCount() => geometrySet.Count();

        //public void reset()
        //{

        //}

    }
}
