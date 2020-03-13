using Alver.Forms;
using Alver.MISC;
using Alver.Properties;
using Alver.UI.Utilities;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Alver
{
    internal static class Program
    {
        //public class ObservableListSource<T> : ObservableCollection<T>, IListSource
        //   where T : class
        //{
        //    private IBindingList _bindingList;

        //    bool IListSource.ContainsListCollection { get { return false; } }

        //    IList IListSource.GetList()
        //    {
        //        return _bindingList ?? (_bindingList = this.ToBindingList());
        //    }
        //}
        public static Process PriorProcess()
        // Returns a System.Diagnostics.Process pointing to
        // a pre-existing process with the same name as the
        // current one, if any; or null if the current process
        // is unique.
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) &&
                    (p.MainModule.FileName == curr.MainModule.FileName))
                    return p;
            }
            return null;
        }

        private static void Start(Action a)
        {
            a.BeginInvoke(null, null);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            if (PriorProcess() != null)
            {
                MessageBox.Show("لا يمكن تشغيل أكثر من نسخة من اليرنامج في نفس الوقت");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Start(() =>
            //{
            //    using (dbEntities context = new dbEntities())
            //    {
            //        context.SaveChangesAsync();
            //    }
            //});
            //try
            //{
            //    Settings.Default.Activated = false;
            //    Settings.Default.RunsLimit = 20;
            //    Settings.Default.RunTimes = 0;
            //Settings.Default.FirstRun = false;
            //Settings.Default.Save();
            //    MessageBox.Show("تم الاستعادة بنجاح");
            //}
            //catch (Exception ex)
            //{
            //    MSGs.ErrorMessage(ex);
            //}
            if (Settings.Default.FirstRun)
            {
                if (!DatabaseFuncs.CheckDatabaseExists(Settings.Default.InitialCatalog))
                {
                    if (DatabaseFuncs.CreateDatabase())
                    {
                        Settings.Default.FirstRun = false;
                        Settings.Default.Save();
                        Application.Exit();
                    }
                }
            }
            else if (DatabaseFuncs.CheckDatabaseExists(Settings.Default.InitialCatalog))
            {
                frmLogin login_form = new frmLogin();
                if (login_form.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMain());
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult _dialog =
                    MessageBox.Show("قاعدة البيانات غير موجودة، او تم حذفها او تم إيقاف السيرفر" + Environment.NewLine + "هل تريد فتح نافذة اعداد قاعدة البيانات؟؟؟؟",
                    "خطأ في قاعدة البيانات",
                    MessageBoxButtons.YesNo);// + Environment.NewLine + EX.Source);
                                             //MessageBox.Show(db.Database.Connection.ConnectionString);
                                             //Application.Exit();
                if (_dialog == DialogResult.Yes)
                {
                    frmDBTools frm = new frmDBTools();
                    frm.ShowDialog();
                    MessageBox.Show("يرجى إعادة تشغيل البرنامج");
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}