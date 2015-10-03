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
    public partial class View : System.Web.UI.Page
    {

     
        protected void Page_Load(object sender, EventArgs e)
        {

            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection con=new SqlConnection(cs);
            con.Open();

            SqlCommand mycommand=new SqlCommand("select*from student2",con);
            SqlDataAdapter dr=new SqlDataAdapter(mycommand);
            DataTable dt=new DataTable();
            dr.Fill(dt);
            GridView1.DataSource=dt;
            GridView1.DataBind();


            }

        }
    }
