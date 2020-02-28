using Alver.Misc;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.UI.Utilities
{
    public partial class frmDBTools : Form
    {
        string _connectionString = string.Empty
            ,_path=string.Empty;
        bool _connected = false;
        public frmDBTools()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var _servers = DatabaseFuncs.ListLocalSqlInstances();
                foreach (var item in _servers)
                {
                    serverscb.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                databasescb.Items.Clear();
                var _databases = DatabaseFuncs.GetDatabaseList(serverscb.Text.Trim());
                foreach (var item in _databases)
                {
                    databasescb.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                useridtb.ReadOnly = passwordtb.ReadOnly = !sqlauthenticationrb.Checked;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void testconnectionbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string _server = serverscb.Text.Trim(),
                    _database = databasescb.Text.Trim(),
                    _userId = useridtb.Text.Trim(),
                    _password = passwordtb.Text.Trim();

                bool _sqlAuthentication = sqlauthenticationrb.Checked;
                if (_sqlAuthentication)
                {
                    _connectionString = "Server=" + _server
                        + ";Database=" + _database
                        + ";User Id=" + _userId
                        + ";Password=" + _password + ";";
                }
                else
                {
                    _connectionString = "Server=" + _server
                        + ";Database=" + _database
                        + ";Trusted_Connection = True;";
                }
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    _connected = true;
                    AppConnectionString();
                    MessageBox.Show("Connection Succeeded");
                }
            }
            catch (Exception ex)
            {
                _connected = false;
                MessageBox.Show("Connection Failed \n" + ex.Message);
            }
        }

        private void AppConnectionString()
        {
            try
            {
                var connection =
                                    System.Configuration.ConfigurationManager.
                                    ConnectionStrings["dbEntities"].ConnectionString;
                connectionstringtb.Text = connection.ToString();// _connectionString;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void createdatabasebtn_Click(object sender, EventArgs e)
        {
            if(_connected)
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    string _command = "CREATE DATABASE " + databasenametb.Text.Trim();

                    SqlCommand myCommand = new SqlCommand(_command, connection);
                    connection.Open();
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Database Created Successfully", "DATABASE",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void execscriptbtn_Click(object sender, EventArgs e)
        {
            try
            {
                _path = pathtb.Text;
                string script = File.ReadAllText(_path);
                SqlConnection conn = new SqlConnection(_connectionString);
                Server server = new Server(new ServerConnection(conn));
                server.ConnectionContext.ExecuteNonQuery(script);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "sql files (*.sql)|*.sql";
                ofd.ShowDialog();
                pathtb.Text = ofd.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
