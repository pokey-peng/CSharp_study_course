<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //获取系统日期和时间
        String strDateTime = DateTime.Now.ToString();
        txtMessageAll.Text = strDateTime + " " + txtName.Text + " 留言:\n" + txtMessage.Text + "\n" + txtMessageAll.Text;
        txtName.Text = ""; txtMessage.Text = ""; //清空
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 409px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <strong>&nbsp;&nbsp;&nbsp; 留言簿</strong><br />
        姓名：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        留言：<asp:TextBox ID="txtMessage" runat="server" 
            TextMode="MultiLine"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" onclick="btnOK_Click" Text="留言" />
        <br />
        <hr />
        <asp:TextBox ID="txtMessageAll" runat="server" Height="100px" ReadOnly="True" 
            TextMode="MultiLine" Width="400px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
