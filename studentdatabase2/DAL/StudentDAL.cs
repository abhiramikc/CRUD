using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using MySql.Data.MySqlClient;
using studentdatabase2.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace studentdatabase2.DAL
{
    public class StudentDAL
    {
        private List<Student> studentlist;

        public List<Student> GetStudents()
        //public string GetStudents()
        {
            List<Student> studentlist = new List<Student>();
            try
            {
               
               
                string connectionstring = "server=localhost;port=3306;database=angulartutorialdb;user=root;password=root;";

                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM student"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                Console.WriteLine(sda);
                                studentlist = (from DataRow sa in dt.Rows
                                               select new Student()
                                               {
                                                   
                                                   Id=Convert.ToInt32(sa["stuId"]),
                                                   Name = Convert.ToString(sa["name"]),
                                                   Department = Convert.ToString(sa["department"])
                                               }).ToList();
                                //return studentlist;
                                Console.WriteLine(studentlist);
                                //return studentlist;
                            }
                          
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                
            }
            //return "abhi";
            return studentlist;
        }

        public string PostStudents(Student obj)
        //public string GetStudents()
        {
            string result = null;
            //List<Student> studentlist = new List<Student>();
            try
            {


                string connectionstring = "server=localhost;port=3306;database=angulartutorialdb;user=root;password=root;";

                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    String query = "INSERT INTO angulartutorialdb.student (stuId,Name,Department) values(@id,@name,@Department)";

                    using (MySqlCommand cmd = new MySqlCommand(query,con))
                    {
                        cmd.Parameters.AddWithValue("@id",0);
                        cmd.Parameters.AddWithValue("@name", obj.Name);
                        cmd.Parameters.AddWithValue("@department", obj.Department);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                      
                    }
                    result = "success message";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result = "Error message" + e.Message;

            }
            //return "abhi";
            return result;
        }


        public string DeleteStudents(int id)
        //public string GetStudents()
        {
            string result = null;
            //List<Student> studentlist = new List<Student>();
            try
            {


                string connectionstring = "server=localhost;port=3306;database=angulartutorialdb;user=root;password=root;";

                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                 
                    string query = "DELETE FROM angulartutorialdb.student WHERE stuId="+id;

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                       
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    result = "success message";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result = "Error message" + e.Message;

            }

            return result;
        }


    }


 



}

