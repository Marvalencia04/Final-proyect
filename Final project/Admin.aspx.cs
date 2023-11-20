using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Final_project
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Students";

                SQLiteCommand comm = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    string ID = dr["Student_ID"].ToString();
                    string studentName = dr["Name"].ToString();
                    string element = ID + " " + studentName;
                    ListStudents.Items.Add(element);
                }
                conn.Close();
            }

        }

        protected void ListStudents0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Delete_Click(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            Student student = new Student(ID_txtbox.Text,Name_txtbox.Text,Surname_txtbox.Text,DOB_txtbox.Text,Adress_txtbox.Text,Email_txtbox.Text);
            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = @"INSERT INTO Students (Student_ID, Name,Surname,DOB,Address,Email) 
                    VALUES (@ID, @Name, @Surname,@DOB,@Address,@Email)";

                SQLiteCommand comm = new SQLiteCommand(query, conn);
                comm.Parameters.AddWithValue("@ID", student.ID);
                comm.Parameters.AddWithValue("@Name",student.Name);
                comm.Parameters.AddWithValue("@Surname",student.Surname);
                comm.Parameters.AddWithValue("@DOB",student.DateOfBirth);
                comm.Parameters.AddWithValue("@Address",student.Address);
                comm.Parameters.AddWithValue("@Email",student.Email);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        protected void Name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Subjects_student_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}