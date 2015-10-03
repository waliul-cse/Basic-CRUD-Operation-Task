using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.UserName = txtuser.Text;
            student.Password = txtpwd.Text;
            student.ConfirmPassword = txtcnmpwd.Text;
            student.FirstName = txtfname.Text;
            student.LastName = txtlname.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtphone.Text;
            student.Location = txtlocation.Text;



            
            var i = DAL.InsertAdmissionInfo(student);
            Response.Redirect("welcome.aspx");



            /*
                        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                        SqlConnection connection = new SqlConnection(cs);
                        SqlCommand cmd = new SqlCommand("insert into student2(Username,Password,ConfirmPassword,FirstName,LastName,Email,Phone,Location)values('"+txtuser.Text+"','"+txtpwd.Text+"','"+txtcnmpwd.Text+"','"+txtfname.Text+"','"+txtlname.Text+"','"+txtEmail.Text+"','"+txtphone.Text+"','"+txtlocation.Text+"')",connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        Response.Redirect("Welcome.aspx");

                    }*/
        }
    }
}