<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Final_project.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListStudents" runat="server"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="Subjects_student" runat="server" OnSelectedIndexChanged="Subjects_student_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;<asp:ListBox ID="ListStudents0" runat="server" OnSelectedIndexChanged="ListStudents0_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="ListStudents1" runat="server"></asp:ListBox>
            <br />
            <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Surname" runat="server" Text="Surname:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="DoB" runat="server" Text="Date of birth:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Nationality" runat="server" Text="Nationality:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
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
            <asp:Button ID="Add" runat="server" Text="Add" />
            <asp:Button ID="Delete0" runat="server" OnClick="Delete_Click" Text="Delete" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Confirm changes" />
        </div>
    </form>
</body>
</html>
