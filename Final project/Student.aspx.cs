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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSubjectsDropDown();

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
                        string query = "SELECT Subject_name FROM Students_subject WHERE Students_ID = @ID";
                        string studentID = Session["ID"].ToString();

                        using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                        {
                            comm.Parameters.AddWithValue("@ID", studentID);
                            using (SQLiteDataReader reader = comm.ExecuteReader())
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);

                                // Clear existing items before binding
                                Subjects_student.Items.Clear();

                                // Bind the DataTable directly to the DropDownList
                                Subjects_student.DataSource = dt;
                                Subjects_student.DataTextField = "Subject_name";
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

            protected void TextBox1_TextChanged(object sender, EventArgs e)
            {

            }

            protected void Subjects_student_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
    }
}