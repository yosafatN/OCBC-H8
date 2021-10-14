using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string queryBuilder = $"SELECT * FROM `user_info` where username ='{textUsername.Text}' and password = '{textPassword.Text}'";
            Console.WriteLine(queryBuilder);
            db.ExecuteSelect(queryBuilder);
            if (db.Count() == 1)
            {
                MessageBox.Show("Success You will Login as " + db.Result(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong Username or Password Combination");
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
