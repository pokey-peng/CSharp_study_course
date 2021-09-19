<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:DataList ID="DataList2" runat="server" DataKeyField="BookID" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <table>
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/BookImages/" + Eval("BookImage") %>'
                            Height="150px" Width="120px" />
                    </td>
                    <td >
                        <asp:Label ID="Label1" runat="server" Text='<%# "书  名："+Eval("Bookname") %>'></asp:Label><br />
                        <asp:Label ID="Label2" runat="server" Text='<%# "作  者："+Eval("Author") %>'></asp:Label><br />
                        <asp:Label ID="Label3" runat="server" Text='<%# "出版社："+Eval("Publisher") %>'></asp:Label><br />
                        <asp:Label ID="Label4" runat="server" Text='<%# "书  号："+Eval("BookID") %>'></asp:Label><br />
                        <asp:Label ID="Label5" runat="server" Text='<%# "单  价："+Eval("UnitCost", "{0:f2}")%>'></asp:Label><br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/pages/AddToCart.aspx?BookID=" + Eval("BookID") %>'
                            Text='<%# "购买" %>'></asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" >
                        内容简介：<br />
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("Description") %>' TextMode="MultiLine"
                            Width="700px"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [BookID], [Bookname], [Author], [Publisher], [UnitCost], [BookImage], [Description] FROM [Books] WHERE ([BookID] = @BookID)">
        <SelectParameters>
            <asp:QueryStringParameter Name="BookID" QueryStringField="BookID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

