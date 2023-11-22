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
            if (!IsPostBack)
            {
                BindStudentList();
                BindSubjectsDropDown();
                BindProfessorList();
            }

        }
        private void BindStudentList()
        {
            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Students";

                using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        foreach (DataRow dr in dt.Rows)
                        {
                            string ID = dr["Student_ID"].ToString();
                            ListStudents.Items.Add(ID);
                        }
                    }
                }
            }

        }
        private void BindProfessorList()
        {
            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Professors";

                using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        foreach (DataRow dr in dt.Rows)
                        {
                            string ID = dr["Professor_ID"].ToString();
                            ListProfessor.Items.Add(ID);
                        }
                    }
                }
            }

        }
        private void BindSubjectsDropDown()
        {
            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Subjects";

                    using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = comm.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Clear existing items before binding
                            Subjects_student.Items.Clear();

                            // Bind the DataTable directly to the DropDownList
                            Subjects_student.DataSource = dt;
                            Subjects_student.DataTextField = "Name";
                            Subjects_student.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log the error, or display a user-friendly message
                Console.WriteLine("Error: " + ex.Message);
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
            Student student = new Student(ID_txtbox.Text, Name_txtbox.Text, Surname_txtbox.Text, DOB_txtbox.Text, Adress_txtbox.Text, Email_txtbox.Text,Nation_txtbox.Text);
            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = @"INSERT INTO Students (Student_ID, Name,Surname,DOB,Address,Email,Nationality) 
                    VALUES (@ID, @Name, @Surname,@DOB,@Address,@Email,@Nationality)";

                SQLiteCommand comm = new SQLiteCommand(query, conn);
                comm.Parameters.AddWithValue("@ID", student.ID);
                comm.Parameters.AddWithValue("@Name", student.Name);
                comm.Parameters.AddWithValue("@Surname", student.Surname);
                comm.Parameters.AddWithValue("@DOB", student.DateOfBirth);
                comm.Parameters.AddWithValue("@Address", student.Address);
                comm.Parameters.AddWithValue("@Email", student.Email);
                comm.Parameters.AddWithValue("@Nationality", student.Nation);
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
            string selectedSubject = Subjects_student.SelectedValue;

            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Students_subject WHERE Subject_name = @Subject_name";
                string query2 = "SELECT * FROM Professors_subjects WHERE Subject_name = @Subject_name";
                using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                {
                    comm.Parameters.AddWithValue("@Subject_name", selectedSubject);

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        ListStudents1.Items.Clear();
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {

                                string ID = dr["Students_ID"].ToString();
                                ListStudents1.Items.Add(ID);
                            }
                        }
                        else
                        {
                            ListStudents1.Items.Add("There's no students enrolled in this subject");
                        }
                    }
                }
                using (SQLiteCommand comm = new SQLiteCommand(query2, conn))
                {
                    comm.Parameters.AddWithValue("@Subject_name", selectedSubject);

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        ListProfessors.Items.Clear();
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {

                                string ID = dr["Professors_ID"].ToString();
                                ListProfessors.Items.Add(ID);
                            }
                        }
                        else
                        {
                            ListProfessors.Items.Add("There's no professors imparting this subject");
                        }
                    }
                }
            }

        }

 
        protected void ListStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentID = ListStudents.SelectedValue;

            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Students WHERE Student_ID = @StudentID";

                using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                {
                    comm.Parameters.AddWithValue("@StudentID", selectedStudentID);

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        foreach (DataRow dr in dt.Rows)
                        {
                            Name_txtbox.Text = dr["Name"].ToString();
                            ID_txtbox.Text = dr["Student_ID"].ToString();
                            Surname_txtbox.Text = dr["Surname"].ToString();
                            DOB_txtbox.Text = dr["DOB"].ToString();
                            Adress_txtbox.Text = dr["Address"].ToString();
                            Nation_txtbox.Text = dr["Nationality"].ToString();
                            Email_txtbox.Text = dr["Email"].ToString();
                            ListStudents.AutoPostBack = true;

                        }
                    }
                }
            }
        }

        protected void DeleteStudentSubject_Click(object sender, EventArgs e)
        {

        }

        protected void AddStudentSubject_Click(object sender, EventArgs e)
        {
            string selectedStudentID = ListStudents.SelectedValue;
            string selectedSubject = Subjects_student.SelectedValue;
            try
            {
                if (selectedStudentID == "")
                {
                    string errorScript = "alert('Error adding subject. Student not selected');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorMessage", errorScript, true);

                }
                else
                {
                    string pathDB = Server.MapPath("~/bin/Debug/data/University.db");

                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
                    {
                        conn.Open();
                        string query = @"INSERT INTO Students_subject(Students_ID, Subject_name)
                             VALUES (@ID, @Name)";

                        using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                        {
                            comm.Parameters.AddWithValue("@ID", selectedStudentID);
                            comm.Parameters.AddWithValue("@Name", selectedSubject);
                            comm.ExecuteNonQuery();
                        }
                        Page.Response.Redirect(Request.Url.ToString(), true);
                        string successScript = "alert('Subject added successfully.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", successScript, true);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorScript = "alert('Error adding subject. Please try again');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorMessage", errorScript, true);

            }
        }

    }
}