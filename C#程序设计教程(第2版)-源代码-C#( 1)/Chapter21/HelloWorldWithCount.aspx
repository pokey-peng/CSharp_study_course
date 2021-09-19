<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Application["nCount"] = (int)Application["nCount"] + 1;
        Message.Text = Name.Text + "，您好!  ";
        lblTime.Text = Application["sTime"].ToString();
        lblCount.Text = Application["nCount"].ToString();

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
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
            Text="请输入您的姓名："></asp:Label>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="确定" onclick="Button1_Click" />
        <br />
        <asp:Label ID="Message" runat="server" Font-Bold="True" ForeColor="Blue" 
            style="text-align: center"></asp:Label>
        您是自<asp:Label ID="lblTime" runat="server"></asp:Label>
        的第<asp:Label ID="lblCount" runat="server"></asp:Label>
        个访问者    
    </div>
    </form>
</body>
</html>
