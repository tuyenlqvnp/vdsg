using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Npgsql;


namespace vdsg_local.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            //var connString = "Host=ec2-23-21-220-48.compute-1.amazonaws.com;Username=zqtmwnpauogptz;Password=eccd2d101e32f686c675392760bde893e91c293db73ad76a4ad3e034e774f1ff;Database=d5kv8acvn4i7it";

            //using (var conn = new NpgsqlConnection(connString))
            //{
            //    conn.Open();

            //    // Insert some data
            //    using (var cmd = new NpgsqlCommand())
            //    {
            //        cmd.Connection = conn;
            //        cmd.CommandText = "INSERT INTO data (some_field) VALUES (@p)";
            //        cmd.Parameters.AddWithValue("p", "Hello world");
            //        cmd.ExecuteNonQuery();
            //    }

            //    // Retrieve all rows
            //    using (var cmd = new NpgsqlCommand("SELECT some_field FROM data", conn))
            //    using (var reader = cmd.ExecuteReader())
            //        while (reader.Read())
            //            Console.WriteLine(reader.GetString(0));
            //}

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult ElectricInvoice()
        {
            return View();
        }

        public IActionResult GetSurveyToMakeElectricInvoice()
        {
            return View();
        }
        public IActionResult RegisterCompany()
        {
            return View();
        }
    }
}
