using Alver.DAL;
using Alver.Properties;
using Alver.UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.Forms
{
    public partial class frmLogin : Form
    {
        private dbEntities db;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                db = new dbEntities();
                db.Configuration.ProxyCreationEnabled = false;
                //db.Database.EnsureCreatedAsync();
                db.Users.Load();
                bool _fullActivation = Settings.Default.Activated;
                bool _trialActivation = Settings.Default.TrialActivated;
                int _runTimes = Settings.Default.RunTimes;
                int _runsLimit = Settings.Default.RunsLimit;
                Settings.Default.RunTimes = ++_runTimes;
                Settings.Default.Save();
                //_runTimes = 0;
                //_runTimes = CheckActivation(_fullActivation, _trialActivation, _runTimes, _runsLimit);
            }
            catch (Exception EX)
            {
                //string _errorMsg = EX.Message;
                //_errorMsg += "    " + EX.InnerException;
                //MessageBox.Show(_errorMsg);
                DialogResult _dialog = MessageBox.Show("لا يمكن الاتصال بقاعدة البيانات يرجى التأكد من وجود قاعدة البيانات وانها في حالة فعالة" + Environment.NewLine + "هل تريد فتح نافذة اعداد قاعدة البيانات؟؟؟؟", "خطأ في قاعدة البيانات", MessageBoxButtons.YesNo);// + Environment.NewLine + EX.Source);
                                                                                                                                                                                                                                                                        //MessageBox.Show(db.Database.Connection.ConnectionString);
                                                                                                                                                                                                                                                                        //Application.Exit();
                if (_dialog == DialogResult.Yes)
                {
                    frmDBTools frm = new frmDBTools();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        //private static int CheckActivation(bool _fullActivation, bool _trialActivation, int _runTimes, int _runsLimit)
        //{
        //    if (!_fullActivation)
        //    {
        //        if (!_trialActivation)
        //        {
        //            DialogResult _dialog = MessageBox.Show("لم يتم تفعيل اليرنامج!!! هل تريد تفعيل النسخة؟",
        //                 "تنبيه",
        //                 MessageBoxButtons.YesNo,
        //                 MessageBoxIcon.Warning
        //                 );
        //            if (_dialog == DialogResult.Yes)
        //            {
        //                DialogResult _registerationDialog = (new frmRegister()).ShowDialog();
        //                if (_registerationDialog == DialogResult.OK)
        //                {
        //                    Properties.Settings.Default.Activated = true;
        //                    Properties.Settings.Default.TrialActivated = false;
        //                    Properties.Settings.Default.Save();
        //                    MessageBox.Show("تم تفعيل النسخة مدى الحياة، يرجى إعادة تشغيل البرنامج");
        //                    Application.Exit();
        //                }
        //                else if (_registerationDialog == DialogResult.Retry)
        //                {
        //                    Properties.Settings.Default.Activated = false;
        //                    Properties.Settings.Default.TrialActivated = true;
        //                    Properties.Settings.Default.RunsLimit = 20;
        //                    Properties.Settings.Default.RunTimes = 0;
        //                    Properties.Settings.Default.Save();
        //                    MessageBox.Show("تم تفعيل النسخة بشكل تجريبي، يرجى إعادة تشغيل البرنامج");
        //                    Application.Exit();
        //                }
        //            }
        //            else if (_dialog == DialogResult.No)
        //            {
        //                if (_trialActivation && _runTimes > _runsLimit)
        //                {
        //                    MessageBox.Show("انتهت الفترة التجريبية، يرجى تفعيل البرنامج. سيتم إغلاق البرنامج");
        //                    Settings.Default.Activated = false;
        //                    Settings.Default.TrialActivated = false;
        //                    Settings.Default.Save();
        //                    //Application.Restart();
        //                    Application.Exit();
        //                }
        //                else if (_trialActivation && _runTimes <= _runsLimit)
        //                {
        //                    _runTimes = _runTimes + 1;
        //                    MessageBox.Show("باقي لانتهاء الفترة التجريبية: " + (_runsLimit - _runTimes).ToString());
        //                    Settings.Default.RunTimes = _runTimes;
        //                    Settings.Default.Save();
        //                    //_activated = true;
        //                }
        //            }
        //        }
        //        else if (_trialActivation && _runTimes > _runsLimit)
        //        {
        //            MessageBox.Show("انتهت الفترة التجريبية، يرجى تفعيل البرنامج. سيتم إغلاق البرنامج");
        //            Settings.Default.Activated = false;
        //            Settings.Default.TrialActivated = false;
        //            Settings.Default.Save();
        //            //Application.Restart();
        //            Application.Exit();
        //        }
        //        else if (_trialActivation && _runTimes <= _runsLimit)
        //        {
        //            _runTimes = _runTimes + 1;
        //            Settings.Default.RunTimes = _runTimes;
        //            Settings.Default.Save();
        //            //_activated = true;
        //        }
        //    }

        //    return _runTimes;
        //}

        private void LogIn()
        {
            try
            {
                string userid = usernametb.Text.Trim();
                string password = passwordtb.Text.Trim();
                var _user = db.Users.FirstOrDefault(u => u.UserName == userid
                           && u.Password == password);
                if (_user != null)
                {
                    Settings.Default.LoggedInUser = _user;
                    _user.LLD = DateTime.Now;
                    db.Entry(_user).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("مرحباً " + _user.FullName, "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("البيانات خاطئة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي", "تنبيه");
            }
        }
    }
}