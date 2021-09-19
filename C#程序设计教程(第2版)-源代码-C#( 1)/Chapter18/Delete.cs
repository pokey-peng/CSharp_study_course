using System; using System.IO; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class DeleteRegionTest
   {
      static void Main()
      {  //(1)连接到数据库
         String connString = @"Data Source= (LocalDB)\v11.0;Initial Catalog=Northwind;
                 AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String commandTextDelete = "DELETE FROM Region WHERE RegionID = @id";
         using (SqlConnection connection = new SqlConnection(connString))
         {
            connection.Open();
            //(2)创建SqlCommand命令
            SqlCommand cmdDelete = new SqlCommand(commandTextDelete, connection);
            cmdDelete.Parameters.AddWithValue("@id", 5);
            //(3)执行SqlCommand命令并检查结果
            int result = cmdDelete.ExecuteNonQuery();
            if (result == 1) { Console.WriteLine("删除记录操作成功."); }
            else { Console.WriteLine("删除记录操作失败."); }
         }
      }
   }
}
