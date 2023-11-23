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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            string ID= txt_box_User.Text;
            string Password =txt_box_Pass.Text;
            string C_ID = "";
            string C_Password = "";
            string Profile = "";
            string pathDB = Server.MapPath("~/bin/Debug/data/University.db");
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + pathDB + ";Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE ID = @ID";

                using (SQLiteCommand comm = new SQLiteCommand(query, conn))
                {
                    comm.Parameters.AddWithValue("@ID", ID);

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        foreach (DataRow dr in dt.Rows)
                        {
                            C_ID = dr["ID"].ToString();
                            C_Password = dr["Password"].ToString();
                            Profile= dr["Profile"].ToString(); 
                        }
                    }
                }
            }
            if(C_ID==ID && C_Password == Password)
            {
                if (Profile == "Professor")
                {
                    Session["ID"] = ID;
                    Session["Profile"] = Profile;
                    Response.Redirect("~/Professor.aspx");

                }
                if (Profile == "Student")
                {
                    Session["ID"] = ID;
                    Session["Profile"] = Profile;
                    Response.Redirect("~/Student.aspx");

                }
                if (Profile == "Admin")
                {
                    Session["ID"] = ID;
                    Session["Profile"] = Profile;
                    Response.Redirect("~/Admin.aspx");

                }
            }
            else
            {
                lblErrorMessage.Text = "Incorrect ID or password. Please try again.";
            }

        }
    }
 }