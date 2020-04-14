using Alver.DAL;
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

namespace Alver.UI.Users
{
    public partial class frmChangePassword : Form
    {
        dbEntities db;
        User _user;
        public frmChangePassword(User User)
        {
            InitializeComponent();
            _user = User;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                string OldPass, NewPass, RenewPass;
                OldPass = oldPasstb.Text.Trim();
                NewPass = newPasstb.Text.Trim();
                RenewPass = renewPasstb.Text.Trim();
                LoadData();
                if (_user.Id != 0 && _user.Password == OldPass)
                {
                    if (NewPass == RenewPass)
                    {
                        _user.Password = NewPass;
                        db.SaveChanges();
                        MessageBox.Show("تم تغيير كلمة المرور بنجاح");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("كلمة المرور الجديدة غير مطابقة، يرجى التأكد");
                    }
                }
                else if (_user.Id == 0)
                {
                    if (NewPass == RenewPass)
                    {
                        _user.Password = NewPass;
                        db.SaveChanges();
                        MessageBox.Show("تم تغيير كلمة المرور بنجاح");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("كلمة المرور القديمة غير صحيحة، يرجى التأكد من صحة الكلمة");
                }
            }
        }

        private void LoadData()
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;
            db.Users.Load();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            LoadData();
            usernamelbl.Text = "تغيير كلمة المرور للمستخدم: " + _user.FullName;
        }
    }
}
