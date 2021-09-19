<%@ Page Language="C#" %>
<%@ import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>

<script runat="server">

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        //连接到数据库Northwind
        //注：如果使用LocalDB数据库服务器，则：Data Source = (LocalDB)\v11.0 
        //注：如果使用SQL Express数据库服务器，则：Data Source = .\SQLExpress
        String str1 = @"Data Source=(LocalDB)\v11.0;Initial Catalog=Northwind;
           AttachDbFilename=C:\C#\DB\Northwnd.mdf;Integrated Security=True;";
        SqlConnection con = new SqlConnection(str1); con.Open();
        //创建查询SQL命令
        SqlCommand cmd = new SqlCommand("Select CategoryName, Description From Categories", con);
        SqlDataReader dtr = cmd.ExecuteReader(); //执行SQL命令并返回结果
        String strResult = "<table><tr><td>类别名称</td><td>说明</td></tr>";//显示结果标题
        while (dtr.Read()) //通过循环列表显示产品类别信息
            strResult += "<tr><td>" + dtr["CategoryName"] + "</td><td>" + dtr["Description"] + "</td></tr>";
        lblResult.Text = strResult + "</table>";//显示结果
        dtr.Close(); con.Close(); //关闭打开的DataReader和数据库连接

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="显示类别信息" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>    
    </div>
    </form>
</body>
</html>
