<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Professor.aspx.cs" Inherits="Final_project.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <asp:DropDownList ID="Subjects_student" runat="server" OnSelectedIndexChanged="Subjects_student_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Credtis" runat="server" Text="Credits:"></asp:Label>
            <br />
            <asp:Label ID="Semester" runat="server" Text="Semester:"></asp:Label>
            <br />
            <asp:Label ID="Professors" runat="server" Text="Professor:"></asp:Label>
        </div>
    </form>
</body>
</html>
