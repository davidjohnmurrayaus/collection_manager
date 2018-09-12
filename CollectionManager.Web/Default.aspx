<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CollectionManager.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Collection Manager</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Collection Manager</h1>
        <div>
            <asp:Repeater ID="RepeaterItems" runat="server">
                <ItemTemplate><%# Eval("Name") %></ItemTemplate>
            </asp:Repeater>
        </div>
        <div>
            <asp:Button ID="ButtonAddItem" Text="Add" runat="server" OnClick="ButtonAddItem_Click" />
        </div>
    </form>
</body>
</html>
