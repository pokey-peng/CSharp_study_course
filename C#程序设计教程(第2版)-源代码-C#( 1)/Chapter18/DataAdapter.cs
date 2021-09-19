using System; using System.IO; using System.Data; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class QueryRegionByDataSetTest
   {
      static void Main()
      {  //(1)连接到数据库
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
              AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String selectCommandText = "SELECT RegionID, RegionDescription FROM Region";
         using (SqlConnection connection = new SqlConnection(connString))
         {  //(2)创建DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, connection);
            connection.Open();
            DataSet dataSet = new DataSet();//创建DataSet
            //(3)从DataAdapter填充DataSet
            adapter.Fill(dataSet, "Region");
            Console.WriteLine("Northwind数据库的Region表的内容如下：");
            Console.WriteLine("地区编号 \t 地区说明 ");
            //(4)操作和处理DataSet
            foreach (DataRow row in dataSet.Tables["Region"].Rows)
             { Console.WriteLine("  {0} \t\t {1}", row["RegionID"], row["RegionDescription"]);}
         }
      }
   }
}
