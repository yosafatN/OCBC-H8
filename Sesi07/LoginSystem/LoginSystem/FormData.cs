using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginSystem
{
    public partial class FormData : Form
    {
        Config db = new Config();
        List<Data> data = new List<Data>();
        public FormData()
        {
            InitializeComponent();
            db.Connect("userdata");
            getData();
        }


        private void getData()
        {
            try
            {
                string queryGet = "SELECT * FROM `data`;";
                db.ExecuteSelect(queryGet);

                Console.WriteLine("RESULT: " + db.Count());
                Console.WriteLine("TEST: " + db.Result(0,"nama"));
                if (db.Count() > 0)
                {
                    for (int i = 0; i < db.Count(); i++)
                    {
                        data.Add(new Data(
                            int.Parse(db.Result(i,"id")),
                            db.Result(i, "nama"),
                            db.Result(i, "alamat"),
                            db.Result(i, "handphone")
                        ));

                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGrid);
                        newRow.Cells[0].Value = data.Last<Data>().id;
                        newRow.Cells[1].Value = data.Last<Data>().nama;
                        newRow.Cells[2].Value = data.Last<Data>().alamat;
                        newRow.Cells[3].Value = data.Last<Data>().headphone;
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
