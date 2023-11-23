<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Final_project.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListStudents" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ListStudents_SelectedIndexChanged"></asp:ListBox>
            <asp:ListBox ID="ListProfessor" runat="server" AutoPostBack="true" Width="132px" OnSelectedIndexChanged="ListProfessor_SelectedIndexChanged"></asp:ListBox>
            <asp:DropDownList ID="Subjects_student" runat="server" OnSelectedIndexChanged="Subjects_student_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            
            <br />
            
            <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="Name_txtbox" runat="server"></asp:TextBox>
           
            <asp:Label ID="Surname" runat="server" Text="Surname:"></asp:Label>
            <asp:TextBox ID="Surname_txtbox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="DoB" runat="server" Text="Date of birth:"></asp:Label>
            <asp:TextBox ID="DOB_txtbox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Nationality" runat="server" Text="Nationality:"></asp:Label>
            <asp:TextBox ID="Nation_txtbox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="IDNumber" runat="server" Text="ID-Number:"></asp:Label>
            <asp:TextBox ID="ID_txtbox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Adress" runat="server" Text="Adress:"></asp:Label>
            <asp:TextBox ID="Adress_txtbox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="EMail" runat="server" Text="E-Mail Adress:"></asp:Label>
            <asp:TextBox ID="Email_txtbox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="Pass_txtbox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Profile_label" runat="server" Text="Profile:"></asp:Label>
            <asp:DropDownList ID="DropDownProfile" runat="server" OnSelectedIndexChanged="DropDownProfile_SelectedIndexChanged">
                <asp:ListItem>Student</asp:ListItem>
                <asp:ListItem>Professor</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" Width="96px" />
            <asp:Button ID="Delete0" runat="server" OnClick="Delete_Click" Text="Delete" Width="91px" />
            <asp:Button ID="Changes" runat="server" Text="Confirm changes" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:ListBox ID="ListProfessors" runat="server" OnSelectedIndexChanged="ListStudents0_SelectedIndexChanged" Width="121px"></asp:ListBox>
            <asp:ListBox ID="ListStudents1" runat="server" Width="132px"></asp:ListBox>
            <asp:Button ID="AddStudentSubject" runat="server" Text="Add Student" Width="122px" OnClick="AddStudentSubject_Click" />
            <asp:Button ID="AddProfessorSubject" runat="server" Text="Add Professor" Width="132px" />
            <asp:Button ID="DeleteStudentSubject" runat="server" Text="Delete student" Width="120px" OnClick="DeleteStudentSubject_Click" />
            <asp:Button ID="DeleteProfessorSubject" runat="server" Text="Delete Professor" Width="134px" />
        </div>
    </form>
</body>
</html>
