using System; using System.IO; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class InsertRegionTest
   {
      static void Main()
      {  //(1)连接到数据库
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
               AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String commandTextInsert = 
                "INSERT INTO Region(RegionID,RegionDescription) VALUES(@id,@name)";
         using (SqlConnection connection = new SqlConnection(connString))
         {  connection.Open();
            //(2)创建SqlCommand命令
            SqlCommand cmdInsert = new SqlCommand(commandTextInsert, connection);
            cmdInsert.Parameters.AddWithValue("@id", 5);
            cmdInsert.Parameters.AddWithValue("@name", "ECNU");
            //(3)执行SqlCommand命令并检查结果
            int result = cmdInsert.ExecuteNonQuery();
            if (result == 1) { Console.WriteLine("插入记录操作成功."); }
            else { Console.WriteLine("插入记录操作失败."); }
         }
      }
   }
}
