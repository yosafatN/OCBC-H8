using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace LoginSystem
{
    public class Config
    {
        string ConectionString = "";

        public MySqlConnection connection = null;
        public string server = "localhost";
        public string user = "root";
        public string password = "root";

        DataSet ds;
        DataTable dt;
        public string Table = "user_info";
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempData;

        public Config()
        {

        }

        public void Connect (string database_name)
        {
            try
            {
                ConectionString = "SERVER=" + server + ";" + "DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(ConectionString);
            }catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public void ExecuteSql (string Sql_command)
        {
            nowquiee(Sql_command);
        }

        public void nowquiee (string sql_comm)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();

                cs.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Execute (string SQL_comm)
        {
            RecordSource = SQL_comm;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                //da2.Fill(tempds);
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        public string Result (int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return "";
            }
        }

        public void ExecuteSelect (string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempData = new DataGridView();
            } catch (Exception err) { MessageBox.Show(err.Message); }
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}
