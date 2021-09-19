<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text != txtPassword2.Text)
        { lblMessage.Text = "输入的密码不一致，请重新输入！"; return; }
        lblMessage.Text = "您的用户ID是： " + txtID.Text;
        if (rbSexMale.Checked) lblMessage.Text += "<br/>您的性别是： " + rbSexMale.Text;
        else if (rbSexFemale.Checked) lblMessage.Text += "<br/>您的性别是： " + rbSexFemale.Text;
        lblMessage.Text += "<br/>您的学校是： " + DropDownListCollege.SelectedItem.Text;
        lblMessage.Text += "<br/>您的专业是： " + DropDownListMajor.SelectedItem.Text;
        lblMessage.Text += "<br/>您的爱好是：";
        if (cbSports.Checked) lblMessage.Text += cbSports.Text + " ";
        if (cbReading.Checked) lblMessage.Text += cbReading.Text + " ";
        if (cbTravel.Checked) lblMessage.Text += cbTravel.Text + " ";
        if (cbGame.Checked) lblMessage.Text += cbGame.Text + " ";
        if ((cbSports.Checked || cbReading.Checked || cbTravel.Checked || cbGame.Checked) == false)
            lblMessage.Text = "您居然没有兴趣爱好！";

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 295px">
        <div class="auto-style1">
            <strong>新用户注册</strong></div>
        <table >
            <tr>
                <td >
                    用户ID</td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    密码</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    确认密码</td>
                <td>
                    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    性别</td>
                <td>
                    <asp:RadioButton ID="rbSexMale" runat="server" Checked="True" GroupName="Sex" 
                        Text="男" />
                    <asp:RadioButton ID="rbSexFemale" runat="server" GroupName="Sex" Text="女" />
                </td>
            </tr>
            <tr>
                <td >
                    学校</td>
                <td>
                    <asp:DropDownList ID="DropDownListCollege" runat="server">
                        <asp:ListItem>上海电大</asp:ListItem>
                        <asp:ListItem>复旦大学</asp:ListItem>
                        <asp:ListItem>上海交大</asp:ListItem>
                        <asp:ListItem Selected="True">华东师大</asp:ListItem>
                        <asp:ListItem>上海师大</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td >
                    专业</td>
                <td>
                    <asp:DropDownList ID="DropDownListMajor" runat="server">
                        <asp:ListItem Selected="True">计算机</asp:ListItem>
                        <asp:ListItem>商务英语</asp:ListItem>
                        <asp:ListItem>工商管理</asp:ListItem>
                        <asp:ListItem>对外汉语</asp:ListItem>
                        <asp:ListItem>国际金融</asp:ListItem>
                        <asp:ListItem>经济管理</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td >
                    兴趣爱好</td>
                <td>
                    <asp:CheckBox ID="cbSports" runat="server" Text="运动" />
                    <asp:CheckBox ID="cbReading" runat="server" Text="阅读" />
                    <asp:CheckBox ID="cbTravel" runat="server" Text="旅游" />
                    <asp:CheckBox ID="cbGame" runat="server" Text="游戏" />
                </td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
             Text="提交" />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>

    </div>
    </form>
</body>
</html>
