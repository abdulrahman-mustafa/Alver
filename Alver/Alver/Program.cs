using Alver.Forms;
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
    static class Program
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
        static void Main()
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
    }
}
