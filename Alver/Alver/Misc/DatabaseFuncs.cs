using Alver.DAL;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Alver.Misc
{
    public static class DatabaseFuncs
    {
        //public static dbEntities db;
        public static FolderBrowserDialog fbd;
        public static string _path;
        public static bool BackupBrowse()
        {
            bool _action = false;

            try
            {
                fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _path = fbd.SelectedPath;
                    _action = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _action;
        }
        public static void BackupDatabase()
        {
            try
            {
                //LoadData();
                if (!BackupBrowse()) return;
                //db = new dbEntities();
                if (_path == string.Empty)
                {
                    MessageBox.Show("اختر مسار صحيح لحفظ النسخة الاحتياطية");
                }
                else
                {
                    string DatabaseName, ServerName, UserId, Password, conn;
                    using (dbEntities db = new DAL.dbEntities())
                    {
                        conn= db.Database.Connection.ConnectionString;
                        DatabaseName = db.Database.Connection.Database;
                        ServerName = db.Database.Connection.DataSource;
                        UserId = "sa";
                        Password = "11";
                    }

                    //Define a Backup object variable.
                    Backup sqlBackup = new Backup();

                    ////Specify the type of backup, the description, the name, and the database to be backed up.
                    sqlBackup.Action = BackupActionType.Database;
                    sqlBackup.BackupSetDescription = "نسخة احتياطية_" + DatabaseName + " بتاريخ " + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss").Replace("/", "_");
                    sqlBackup.BackupSetName = "FullBackUp";
                    sqlBackup.Database = DatabaseName;

                    ////Declare a BackupDeviceItem
                    string destinationPath = _path;
                    string backupfileName = sqlBackup.BackupSetDescription + ".bak";
                    var fileName = Path.Combine(destinationPath, String.Format(backupfileName));
                    if (!Directory.Exists(destinationPath))
                        Directory.CreateDirectory(destinationPath);
                    BackupDeviceItem deviceItem = new BackupDeviceItem(fileName, DeviceType.File);
                    ////Define Server connection

                    //ServerConnection connection = new ServerConnection(frm.serverName, frm.userName, frm.password);
                    ServerConnection connection = new ServerConnection(ServerName, UserId, Password);
                    ////To Avoid TimeOut Exception
                    Server sqlServer = new Server(connection);
                    sqlServer.ConnectionContext.StatementTimeout = 60 * 60;
                    Database dbase = sqlServer.Databases[DatabaseName];

                    sqlBackup.Initialize = true;
                    sqlBackup.Checksum = true;
                    sqlBackup.ContinueAfterError = true;

                    ////Add the device to the Backup object.
                    sqlBackup.Devices.Add(deviceItem);
                    ////Set the Incremental property to False to specify that this is a full database backup.
                    sqlBackup.Incremental = false;

                    sqlBackup.ExpirationDate = DateTime.Now.AddDays(3);
                    ////Specify that the log must be truncated after the backup is complete.
                    sqlBackup.LogTruncation = BackupTruncateLogType.Truncate;

                    sqlBackup.FormatMedia = false;
                    ////Run SqlBackup to perform the full database backup on the instance of SQL Server.
                    sqlBackup.SqlBackup(sqlServer);
                    ////Remove the backup device from the Backup object.
                    sqlBackup.Devices.Remove(deviceItem);
                    MessageBox.Show("تم أخذ نسخة احتياطية بنجاح", "نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("خطأ في أخذ النسخة الاحتياطية", "نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MSGs.ErrorMessage(ex);
            }
        }
        public static void BackupDatabase2()
        {
            //LoadData();
            BackupBrowse();
            using (dbEntities db = new DAL.dbEntities())
            {
                string database = db.Database.Connection.Database;
                //string cmd = @"BACKUP DATABASE [{0}] TO  DISK = N'{1}' WITH NOFORMAT, NOINIT,  NAME = N'MyAir-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + _path + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                db.Database.ExecuteSqlCommand(
                    System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction,
                    string.Format(cmd, database, "1"));
            }
        }
        public static void BackupDatabase1()
        {
            BackupBrowse();
            string connstr = "Data Source =.; Initial Catalog = Master; Persist Security Info = True; User ID = sa; Password = 11";
            //db.Database.Connection.ConnectionString;
            SqlConnection _conn = new SqlConnection(connstr);
            string DatabaseName;
            using (dbEntities db = new DAL.dbEntities())
            {
                DatabaseName = db.Database.Connection.Database;
            }
            try
            {
                StringBuilder builder = new StringBuilder(_path);
                builder.Replace(@"\\", @"\");
                _path = builder.ToString();
                //_path.Replace("\\", "\");
                if (_path == string.Empty)
                {
                    MessageBox.Show("اختر مسار صحيح لحفظ النسخة الاحتياطية");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + DatabaseName + "] TO DISK='" + _path + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    using (SqlCommand command = new SqlCommand(cmd, _conn))
                    {
                        if (_conn.State != System.Data.ConnectionState.Open)
                        {
                            _conn.Open();
                        }
                        command.ExecuteNonQuery();
                        _conn.Close();
                        MessageBox.Show("تم أخذ نسخة احتياطية بنجاح", "نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //BackupButton.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في أخذ النسخة الاحتياطية", "نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool RestoreBrowse()
        {
            bool _action = true;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = @"backup files(*.bak)|*.bak|all files(*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.Title = "***استرجاع نسخة احتياطية***";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _path = ofd.FileName;
                    //restoreButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _action = false;
            }
            return _action;
        }
        public static void RestoreDatabase()
        {
            if (!RestoreBrowse()) return;
            using (dbEntities db = new dbEntities())
            {
                SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString);
                string database = db.Database.Connection.Database;

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                try
                {
                    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                    bu2.ExecuteNonQuery();

                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + _path + "'WITH REPLACE;";
                    SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                    bu3.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                    bu4.ExecuteNonQuery();

                    MessageBox.Show("تم استرجاع قاعدة البيانات بنجاح", "استرجاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public static List<string> ServersNamesLookup()
        {
            List<string> _servers = new List<string>();
            DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow server in table.Rows)
            {
                _servers.Add(server[table.Columns["ServerName"]].ToString());
            }
            return _servers;
        }
        public static List<IPAddress> ServersIPsLookup()
        {
            List<IPAddress> _serversIPs = new List<IPAddress>();
            _serversIPs.AddRange(Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork));
            return _serversIPs;
        }
        public static void DatabaseTables(dbEntities db)
        {
            using (db)
            {
                var metadata = ((IObjectContextAdapter)db).ObjectContext.MetadataWorkspace;
                string _msg = "";
                var tables = metadata.GetItemCollection(DataSpace.SSpace)
                    .GetItems<EntityContainer>()
                    .Single()
                    .BaseEntitySets
                    .OfType<EntitySet>()
                    .Where(s => !s.MetadataProperties.Contains("Type")
                    || s.MetadataProperties["Type"].ToString() == "Tables");

                foreach (var table in tables)
                {
                    var tableName = table.MetadataProperties.Contains("Table")
                        && table.MetadataProperties["Table"].Value != null
                        ? table.MetadataProperties["Table"].Value.ToString()
                        : table.Name;

                    var tableSchema = table.MetadataProperties["Schema"].Value.ToString();
                    _msg += tableSchema + "." + tableName + Environment.NewLine;
                }
                MessageBox.Show(_msg);
            }
        }
    }
}
