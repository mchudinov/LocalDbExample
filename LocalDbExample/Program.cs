﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace LocalDbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LocalDb Example");
            var constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

            //INSERT
            using (var con = new SqlConnection(constr))
            {
                con.Open();
                    var query = new SqlCommand($"INSERT INTO [Table] (Sum) VALUES ({new Random().Next(100)})", con);
                    query.ExecuteNonQuery();
                con.Close();
            }

            //SELECT
            using (var con = new SqlConnection(constr))
            {
                con.Open();
                    var query = new SqlCommand($"SELECT * FROM [Table]", con);
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id={reader["Id"]} \t Sum={reader["Sum"]}");
                        }
                    }
                con.Close();
            }

            Console.ReadLine();
        }
    }
}
