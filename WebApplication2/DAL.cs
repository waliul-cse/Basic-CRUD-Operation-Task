using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication2
{

    public class Student
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }


    public class DAL
    {

        public static int InsertAdmissionInfo(Student Student)
        {

            //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Waliul\Desktop\StudentAdmssion.accdb");
            string cs1 = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs1);
            connection.Open();
            SqlCommand o_cmd = new SqlCommand("insert into student2 values(@a,@b,@c,@d,@e,@f,@g,@h)", connection);
            o_cmd.Parameters.AddWithValue("a", Student.UserName);
            o_cmd.Parameters.AddWithValue("b", Student.Password);
            o_cmd.Parameters.AddWithValue("c", Student.ConfirmPassword);
            o_cmd.Parameters.AddWithValue("d", Student.FirstName);
            o_cmd.Parameters.AddWithValue("e", Student.LastName);
            o_cmd.Parameters.AddWithValue("f", Student.Email);
            o_cmd.Parameters.AddWithValue("g", Student.Phone);
            o_cmd.Parameters.AddWithValue("h", Student.Location);


            int i = o_cmd.ExecuteNonQuery();
            connection.Close();
            return i;

        }

        public static int DeleteInfo(Student student)
        {

            string cs1 = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs1);

                connection.Open();
                string qry = "delete from student2";

                SqlCommand cmd = new SqlCommand(qry, connection);
              int i=  cmd.ExecuteNonQuery();
              connection.Close();
              return i;
            }
            
                
            
        
       
        
        



        public static List<Student> GetAllStudent()
        {
            List<Student> listStudent = new List<Student>();
            string cs1 = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs1);
            connection.Open();
            string qry1 = "select* from student2";
            SqlCommand cmd = new SqlCommand(qry1, connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Student student = new Student();
                student.UserName = rdr[0].ToString();
                student.Password = rdr[1].ToString();
                student.ConfirmPassword = rdr[2].ToString();
                student.FirstName = rdr[3].ToString();
                student.LastName = rdr[4].ToString();
                student.Email = rdr[5].ToString();
                student.Phone = rdr[6].ToString();
                student.Location = rdr[7].ToString();
                
                listStudent.Add(student);
            }
            connection.Close();
            return listStudent;
        }





        public static void UpdateStudent(string UserName, string Password, string ConfirmPassword, string FirstName, string LastName, string Email,string Phone,string Location)
        {
            string cs1 = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
           SqlConnection connection = new SqlConnection(cs1);
            connection.Open();
            string qry = "update student2 SET UserName = '" + UserName + "', Password = '" + Password + "',ConfirmPassword='"+ConfirmPassword+"',FirstName='"+FirstName+"',LastName='"+LastName+"',Email='"+Email+"',Phone='"+Phone+"',Location='"+Location+"' where UserName = '" + UserName + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteStudent(string Email)
        {

            string cs1 = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs1);

            connection.Open();
            string qry = "delete from student2";

            SqlCommand cmd = new SqlCommand(qry, connection);
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            
        }

    }
}