using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace MultiStates.DAL
{
    public struct GeometryInfo
    {
        public int sid { get; set; }
        public string geometryType { get; set; }
        private List<Point> _geometry;

        public List<Point> geometry
        {
            get
            {
                if (_geometry == null)
                {
                    _geometry = new List<Point>();
                    return _geometry;
                }
                else return _geometry;
            }
            set { _geometry = value; }
        }

        public int penColor { get; set; }
        public int brushColor { get; set; }
        public int penSize { get; set; }
        public string layerName { get; set; }
    }

    public struct GeometryInfoTable
    {
        private List<GeometryInfo> _geolist;

        public List<GeometryInfo> geometrylist
        {
            set { _geolist = value; }
            get
            {
                if (_geolist == null)
                {
                    _geolist = new List<GeometryInfo>();
                    return _geolist;
                }
                else return _geolist;
            }
        }
        public GeometryInfo this[int i]
        {
            get
            {
                return geometrylist[i];
            }
            set
            {
                geometrylist[i] = value;
            }
        }

        public void addGeometryInfo(GeometryInfo geoInfo)
        {
            geometrylist.Add(geoInfo);
        }
        public int Count()
        {
            return geometrylist.Count;
        }
    }
}