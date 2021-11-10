using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Npgsql;
using NpgsqlTypes;

namespace MultiStates.DAL
{
    /// <summary>
    /// 用于数据库操作的类,读取速度很慢，需要改善
    /// </summary>
    public class DatabaseAcess
    {
        private string sqlConnection = "server=192.168.151.128;" +
            "database=gisc;uid=postgres;pwd=qaz2233llcpg;";

        //private string sqlConnection = "DataSource=192.168.151.128;Initial Catalog = gisc;User ID = postgres;Password=qaz2233llcpg";

        private NpgsqlConnection connection;

        public DatabaseAcess()
        {
            connection = new NpgsqlConnection(sqlConnection);
        }

        public string Connect()
        {
            string connMessage;
            try
            {
                //connection = new NpgsqlConnection(sqlConnection);
                connection.Open();
                connection.Close();
                connMessage = "Success";
            }
            catch
            {
                connMessage = "Failure";
            }
            return connMessage;
        }

        /// <summary>
        /// 数据库查询
        /// </summary>
        /// <param name="sql">查询sql</param>
        public GeometryInfoTable Query(string sql)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            NpgsqlDataReader result = command.ExecuteReader();
            GeometryInfoTable geo_Table = getTable(result);
            result.DisposeAsync();
            command.Dispose();
            connection.Close();
            return geo_Table;
        }

        /// <summary>
        /// 数据库插入
        /// </summary>
        /// <param name="geometrySet"></param>
        public void Insert(GeometryInfoTable geoTable)
        {
            int sidT = getMaxSid();
            if (sidT == -1) sidT = 0;
            else sidT++;
            string sql = "INSERT INTO public.\"Geometry2D\"(sid,geometrytype," +
                " geometry, pencolor, brushcolor, pensize, layer) " +
                "VALUES(@Sid, @Geometrytype, @Geometry, " +
                "@Pencolor, @Brushcolor, @Pensize, @Layer);";
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            foreach (GeometryInfo pGeo in geoTable.geometrylist)
            {
                int pCount = 0;
                NpgsqlPoint[] points = new NpgsqlPoint[pGeo.geometry.Count];
                foreach(Point pt in pGeo.geometry)
                {
                    points[pCount].X = pt.X;
                    points[pCount].Y = pt.Y;
                    pCount++;
                }
                command.Parameters.AddWithValue("@Sid", sidT);
                command.Parameters.AddWithValue("@Geometrytype", pGeo.geometryType);
                command.Parameters.AddWithValue("@Geometry", points);
                command.Parameters.AddWithValue("@Pencolor", pGeo.penColor);
                command.Parameters.AddWithValue("@Brushcolor", pGeo.brushColor);
                command.Parameters.AddWithValue("@Pensize", pGeo.penSize);
                command.Parameters.AddWithValue("@Layer", pGeo.layerName);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                sidT++;
                
            }
            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// 数据库更新
        /// </summary>
        /// <param name="sql">跟新sql</param>
        /// <returns></returns>
        public void Update(string sql)
        {
        }

        /// <summary>
        /// 数据库删除
        /// </summary>
        /// <param name="sql">删除sql</param>
        public void Delete(string sql)
        {
        }

        public List<GeometryInfo> ReadAll()
        {
            string sql = "select * from public.Geometry2D";
            List<GeometryInfo> geoSet = null;
            GeometryInfo geo = new GeometryInfo();
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            NpgsqlDataReader result = command.ExecuteReader();
            while (result.Read())
            {
                geo.sid = (int)result["sid"];
                geo.penSize = (int)result["PenSize"];
                geo.penColor = (int)result["PenColor"];
                geo.brushColor = (int)result["BrushColor"];
                //geo.geometry = (Point[])result["Geometry"];
                geo.geometryType = (string)result["GeometryType"];
                geoSet.Add(geo);
            }
            connection.Close();
            return geoSet;
        }

        private int getMaxSid()
        {
            int sid = -1;
            string sql = "select max(sid) from public.\"Geometry2D\"";
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            NpgsqlDataReader result = command.ExecuteReader();
            while (result.Read())
            {
                if (result["max"] == DBNull.Value) { }
                else
                {
                    sid = (int)result["max"];
                    connection.Close();
                    return sid;
                }
            }
            result.DisposeAsync();
            command.Dispose();
            connection.Close();
            return sid;
        }

        private GeometryInfoTable getTable(NpgsqlDataReader geoTable)
        {
            GeometryInfoTable geoInfoTable = new GeometryInfoTable();
            
            while (geoTable.Read())
            {
                GeometryInfo geoInfo = new GeometryInfo();
                geoInfo.sid = (int)geoTable["sid"];
                geoInfo.geometryType = geoTable["geometrytype"].ToString();
                geoInfo.penColor = (int)geoTable["pencolor"];
                geoInfo.brushColor = (int)geoTable["brushcolor"];
                geoInfo.penSize = (int)geoTable["pensize"];
                foreach (NpgsqlPoint p in ((NpgsqlPoint[])geoTable["geometry"]))
                {
                    Point pt = new Point((int)p.X, (int)p.Y);
                    geoInfo.geometry.Add(pt);
                }
                geoInfo.layerName = geoTable["Layer"].ToString();
                geoInfoTable.addGeometryInfo(geoInfo);
            }
            return geoInfoTable;
        }
    }
}