<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CartID,BookID" DataSourceID="SqlDataSource1" EmptyDataText="购物车为空！">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="CartID" HeaderText="CartID" ReadOnly="True" SortExpression="CartID" />
            <asp:BoundField DataField="BookID" HeaderText="书号" ReadOnly="True" SortExpression="BookID" />
            <asp:BoundField DataField="Bookname" HeaderText="书名" ReadOnly="True" SortExpression="Bookname" />
            <asp:BoundField DataField="UnitCost" HeaderText="单价" ReadOnly="True" SortExpression="UnitCost"
                DataFormatString="{0:f2}" />
            <asp:BoundField DataField="Quantity" HeaderText="数量" SortExpression="Quantity" />
            <asp:BoundField DataField="Amount" HeaderText="金额" ReadOnly="True" SortExpression="Amount"
                DataFormatString="{0:f2}" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM ShoppingCart WHERE (CartID = @CartID) AND (BookID = @BookID)" SelectCommand="SELECT ShoppingCart.CartID, ShoppingCart.BookID, Books.Bookname, Books.UnitCost, ShoppingCart.Quantity, Books.UnitCost * ShoppingCart.Quantity AS Amount FROM ShoppingCart INNER JOIN Books ON ShoppingCart.BookID = Books.BookID WHERE (ShoppingCart.CartID = @CartID)" UpdateCommand="UPDATE ShoppingCart SET Quantity = @Quantity WHERE (CartID = @CartID) AND (BookID = @BookID)">
        <DeleteParameters>
            <asp:Parameter Name="CartID" />
            <asp:Parameter Name="BookID" />
        </DeleteParameters>
        <SelectParameters>
            <asp:SessionParameter Name="CartID" SessionField="CartID" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Quantity" />
            <asp:Parameter Name="CartID" />
            <asp:Parameter Name="BookID" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

