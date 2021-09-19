<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        string strBookID = Request.QueryString["BookID"];
        Session["CartID"] = Context.User.Identity.GetUserName(); //获取登录用户信息
        string strCartID = Session["CartID"].ToString();  
        //连接到数据库BooksDB
        string conStr = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(conStr);
        //创建插入ShoppingCart表的SQL命令
        string strInsert = "Insert into ShoppingCart(CartID, BookID,Quantity) Values(@CartID,@BookID,0)";
        SqlCommand cmdInsert = new SqlCommand(strInsert, con);
        cmdInsert.Parameters.AddWithValue("@CartID", strCartID);  //设置参数
        cmdInsert.Parameters.AddWithValue("@BookID", strBookID);//设置参数
        try
        {
            con.Open(); cmdInsert.ExecuteNonQuery();
            Response.Redirect("~/pages/Cart.aspx"); //跳转到购物车
        }
        catch (Exception ex)
        {  //如果购物车已存在该商品，则数量+1
            string strUpdate = "Update ShoppingCart set Quantity=Quantity+1 where CartID=@CartID and BookID=@BookID";
            SqlCommand cmdUpdate = new SqlCommand(strUpdate, con);
            cmdUpdate.Parameters.AddWithValue("@CartID", strCartID);  //设置参数
            cmdUpdate.Parameters.AddWithValue("@BookID", strBookID);//设置参数
            cmdUpdate.ExecuteNonQuery();
            Response.Redirect("~/pages/Cart.aspx"); //跳转到购物车
        }
        finally { con.Close(); }
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
</asp:Content>

