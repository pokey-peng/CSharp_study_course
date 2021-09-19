using System; using System.IO; using System.Data.SqlClient; using System.Data;
namespace CSharpBook.Chapter18
{
   class QueryByStoredProcedureTest
   {
      static void Main()
      {  // 连接到数据库
         String connString = @"Data Source= (LocalDB)\v11.0;Initial Catalog=Northwind;
                  AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         using (SqlConnection connection = new SqlConnection(connString))
         {  connection.Open();
            //创建SqlCommand命令
            SqlCommand cmdQuery = new SqlCommand("Ten Most Expensive Products", connection);
            cmdQuery.CommandType = CommandType.StoredProcedure;
            //执行SqlCommand命令并返回结果
            SqlDataReader reader = cmdQuery.ExecuteReader();
            Console.WriteLine("Products表中最贵的10个商品的信息：");
            Console.WriteLine("产品名称\t\t\t单价");
            while (reader.Read())//通过循环列表显示查询结果集
              { Console.WriteLine(" {0}\t{1}",reader[0].ToString().PadRight(30), reader[1]); }
            reader.Close();//关闭查询结果集
         }
      }
   }
}
