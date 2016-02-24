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
            Console.WriteLine("Use ADO");
            var constr = ConfigurationManager.ConnectionStrings["AppDb"].ToString();

            //INSERT
            using (var con = new SqlConnection(constr))
            {
                con.Open();
                    var query = new SqlCommand($"INSERT INTO [Widget] (Sum) VALUES ({new Random().Next(100)})", con);
                    query.ExecuteNonQuery();
                con.Close();
            }

            //SELECT
            using (var con = new SqlConnection(constr))
            {
                con.Open();
                    var query = new SqlCommand($"SELECT * FROM [Widget]", con);
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
