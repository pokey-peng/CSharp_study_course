using System; using System.IO; using System.Data; using System.Data.SqlClient;
namespace CSharpBook.Chapter18
{
   class MaintainCategoriesByDataSetTest
   {
      static void Main()
      {  //连接到数据库
         String connString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
              AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
         String selectCommandText = "SELECT RegionID, RegionDescription FROM Region";
         using (SqlConnection connection = new SqlConnection(connString))
         {
            connection.Open();
            //删除旧数据（如果存在的话）
            SqlCommand cmdDelete =
               new SqlCommand("DELETE FROM Region WHERE RegionID > 4", connection);
            cmdDelete.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, connection);
            //使用CommandBuilder自动生成DataAdapter的InsertCommand、
            //UpdateCommand和DeleteCommand属性
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();  //创建DataSet
            adapter.Fill(dataSet, "Region");   //从DataAdapter填充DataSet
            //设置DataTable的主键列
            DataColumn[] keys = new DataColumn[1];
            keys[0] = dataSet.Tables["Region"].Columns["RegionID"];
            dataSet.Tables["Region"].PrimaryKey = keys;
            //操作和处理DataSet——增加记录
            DataRow newRow1 = dataSet.Tables["Region"].NewRow();
            newRow1["RegionID"] = 5;  newRow1["RegionDescription"] = "Shanghai";
            dataSet.Tables["Region"].Rows.Add(newRow1);
            DataRow newRow2 = dataSet.Tables["Region"].NewRow();
            newRow2["RegionID"] = 6;  newRow2["RegionDescription"] = "ECNU";
            dataSet.Tables["Region"].Rows.Add(newRow2);
            //操作和处理DataSet——更新记录
            DataRow updateRow = dataSet.Tables["Region"].Rows.Find(5);
            updateRow["RegionDescription"] = "Shanghai, China";
            //操作和处理DataSet——删除记录
            DataRow deleteRow = dataSet.Tables["Region"].Rows.Find(6);
            dataSet.Tables["Region"].Rows.Remove(deleteRow);
            adapter.Update(dataSet, "Region"); //调用DataAdapter的Update方法更新数据源
            Console.WriteLine("完成使用DataAdapter和DataSet维护Region表！");
         }
      }
   }
}
