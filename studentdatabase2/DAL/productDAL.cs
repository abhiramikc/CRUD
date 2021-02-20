using MySql.Data.MySqlClient;
using studentdatabase2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace studentdatabase2.DAL
{
    public class productDAL
    {
        private List<Product> Productlist;
        public List<Product> Getproducts()
        //public string GetStudents()
        {
            List<Product> Productlist = new List<Product>();
            try
            {
                string connectionstring = "server=localhost;port=3306;database=angulartutorialdb;user=root;password=root;";

                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM products"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                Console.WriteLine(sda);
                                Productlist = (from DataRow sa in dt.Rows
                                               select new Product()
                                               {

                                                   Id = Convert.ToInt32(sa["Id"]),
                                                   Name = Convert.ToString(sa["Name"]),
                                               }).ToList();
                                //return studentlist;
                                Console.WriteLine(Productlist);
                                //return studentlist;
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            //return "abhi";
            return Productlist;
        }

        public List<Product> GetOneproducts(int id)
        //public string GetStudents()
        {
            List<Product> Productlist = new List<Product>();
            try
            {
                string connectionstring = "server=localhost;port=3306;database=angulartutorialdb;user=root;password=root;";

                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    string query = "SELECT * FROM products where Id=" + id;

                    using (MySqlCommand cmd = new MySqlCommand(query))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                Console.WriteLine(sda);
                                Productlist = (from DataRow sa in dt.Rows
                                               select new Product()
                                               {

                                                   Id = Convert.ToInt32(sa["Id"]),
                                                   Name = Convert.ToString(sa["Name"]),
                                               }).ToList();
                                //return studentlist;
                                Console.WriteLine(Productlist);
                                //return studentlist;
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            //return "abhi";
            return Productlist;
        }


    }
}
