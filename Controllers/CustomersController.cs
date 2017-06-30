using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Npgsql;


namespace vdsg_local.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Add(string taxcode, string cusname, string address,string contact_name, string tel, string email,string contract_code,string renews,string contents,string price, string note_contract_detail)
        {
            var connString = "Host=localhost;Username=postgres;Password=1234567;Database=postgres";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Insert some data
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO customers (taxcode,cusname,address,tel,emails,contact_name,contract_code,renews, contents,price,note_contract_detail,group_table,type_unit) VALUES (@taxcode,@cusname,@address,@tel,@emails,@contact_name,@contract_code,@renews, @contents,@price,@note_contract_detail,@group_table,@type_unit)";
                    cmd.Parameters.AddWithValue("taxcode", taxcode);
                    cmd.Parameters.AddWithValue("cusname", cusname);
                    cmd.Parameters.AddWithValue("address", address);
                    cmd.Parameters.AddWithValue("tel", tel);
                    cmd.Parameters.AddWithValue("emails", email);
                    cmd.Parameters.AddWithValue("contact_name", contact_name);
                    cmd.Parameters.AddWithValue("contract_code", contract_code);
                    cmd.Parameters.AddWithValue("renews", int.Parse(renews));
                    cmd.Parameters.AddWithValue("contents", contents);
                    cmd.Parameters.AddWithValue("price", float.Parse(price));
                    cmd.Parameters.AddWithValue("note_contract_detail", note_contract_detail);
                    cmd.Parameters.AddWithValue("group_table", "QLKhachHang");
                    cmd.Parameters.AddWithValue("type_unit", "vnd");

                    cmd.ExecuteNonQuery();
                }

            }
            return View();
        }
    }
}
