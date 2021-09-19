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
                        <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl='<%# "BookImages/" + Eval("BookImage") %>' Width="75px" />
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "BookDetails.aspx?BookID=" + Eval("BookID") %>' Text='<%# Eval("Bookname") %>'></asp:HyperLink>
                        <asp:Label ID="Label1" runat="server" Text='<%# "单价："+Eval("UnitCost") %>'></asp:Label>
                        <br />
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "~/pages/AddToCart.aspx?BookID=" + Eval("BookID") %>' Text='<%# "购买" %>'></asp:HyperLink>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT BookID, Bookname, UnitCost, BookImage FROM Books WHERE (Bookname LIKE @Keyword) OR (Description LIKE @Keyword)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Keyword" QueryStringField="Keyword" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

