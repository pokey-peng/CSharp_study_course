<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Message.Text = "您已成功注册！";
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
         <strong style="text-align: center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 用户注册</strong><br />
        <table >
            <tr>
                <td >用户名：</td>
                <td >
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" Display="Dynamic" ErrorMessage="请输入用户名" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="UserName" Display="Dynamic" ErrorMessage="用户名只能包含字母、数字和下划线！" ForeColor="Red" ValidationExpression="\w+"></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td >口 令：</td>
                <td>
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" Display="Dynamic" ErrorMessage="请确认口令" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Password" Display="Dynamic" ErrorMessage="口令长度必须为8到20个字符！" ForeColor="Red" ValidationExpression=".{8,20}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td >电子邮箱：</td>
                <td >
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="Email" Display="Dynamic" ErrorMessage="Email格式不对！" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>电话号码：</td>
                <td >
                    <asp:TextBox ID="Telephone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Telephone" Display="Dynamic" ErrorMessage="电话号码必须是8位号码，如果有区号，区号必须3位！" ForeColor="Red" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>年 龄：</td>
                <td >
                    <asp:TextBox ID="Age" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Age" Display="Dynamic" ErrorMessage="必须为18～200岁的成年人！" ForeColor="Red" MaximumValue="200" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确定" />
                </td>
                <td >&nbsp;</td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="Message" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>   
    </div>
    </form>
</body>
</html>
