<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log-in.aspx.cs" Inherits="Final_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="User_label" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txt_box_User" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Btn_login" runat="server" Text="Log in" />
        </p>
    </form>
</body>
</html>
