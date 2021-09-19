using System; using System.IO; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class QueryCategoriesTest
   {
      static void Main()
      {  // (1)连接到数据库
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
                  AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String commandTextQuery = "SELECT RegionID, RegionDescription FROM Region";
         using (SqlConnection connection = new SqlConnection(connString))
         {
            connection.Open();
            // (2)创建SqlCommand命令
            SqlCommand cmdQuery = new SqlCommand(commandTextQuery, connection);
            // (3)执行SqlCommand命令并返回结果
            SqlDataReader reader = cmdQuery.ExecuteReader();
            Console.WriteLine("Northwind.MDF数据库的Region表的内容如下：");
            Console.WriteLine("地区编号\t地区说明");
            //(4)通过循环列表显示查询结果集
            while (reader.Read()){ Console.WriteLine("   {0} \t\t {1}", reader[0], reader[1]); }
            reader.Close();  //关闭查询结果集
         }
       }
   }
}
