<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHItemText" Runat="Server">
    <asp:Label ID="lblDescription" runat="server" Text="孔雀开屏，争奇斗艳"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHItemPicture" Runat="Server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/peacock.jpg" />
</asp:Content>

