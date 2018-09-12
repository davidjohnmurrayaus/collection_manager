<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemEdit.aspx.cs" Inherits="CollectionManager.Web.ItemEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Item</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Edit Item</h1>
            <table>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="TextName" runat="server" /></td>
                </tr>
                <tr>
                    <td>Tags</td>
                    <td><asp:TextBox ID="TextTags" runat="server" /></td>
                </tr>
                <tr>
                    <td>Notes</td>
                    <td><asp:TextBox ID="TextNotes" TextMode="MultiLine" runat="server" /></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Button ID="ButtonSave" Text="Save" runat="server" OnClick="ButtonSave_Click" />
            <asp:Button ID="ButtonCancel" Text="Cancel" runat="server" OnClick="ButtonCancel_Click" />
        </div>
    </form>
</body>
</html>
