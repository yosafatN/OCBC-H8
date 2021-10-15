using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }
        public EmployeeContext (string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee ()
        {
            List<EmployeeItem> list = new();

            using ( MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new("SELECT * FROM `employee`", conn);
                    using MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            Id = reader.GetInt32("id"),
                            Nama = reader.GetString("nama"),
                            JenisKelamin = reader.GetString("jenis_kelamin"),
                            Alamat = reader.GetString("alamat")
                        });
                    }
                }catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new();

            using MySqlConnection conn = GetConnection();
            conn.Open();
            MySqlCommand cmd = new("SELECT * FROM `employee` WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new EmployeeItem()
                    {
                        Id = reader.GetInt32("id"),
                        Nama = reader.GetString("nama"),
                        JenisKelamin = reader.GetString("jenis_kelamin"),
                        Alamat = reader.GetString("alamat")
                    });
                }
            }
            
            return list;
        }
    }
}
