<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Final_project.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="Subjects_student" runat="server" OnSelectedIndexChanged="Subjects_student_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Surname" runat="server" Text="Surname:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Credtis" runat="server" Text="Credits:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="DoB" runat="server" Text="Date of birth:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Semester" runat="server" Text="Semester:"></asp:Label>
        <br />
        <asp:Label ID="Nationality" runat="server" Text="Nationality:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Professors" runat="server" Text="Professors:"></asp:Label>
        <br />
        <asp:Label ID="IDNumber" runat="server" Text="ID-Number:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Adress" runat="server" Text="Adress:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="EMail" runat="server" Text="E-Mail Adress:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Confirm changes" />
    </form>
</body>
</html>
