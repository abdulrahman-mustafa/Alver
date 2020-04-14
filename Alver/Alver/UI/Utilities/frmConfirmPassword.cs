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

namespace Alver.UI.Utilities
{
    public partial class frmConfirmPassword : Form
    {
        private User _user;

        public frmConfirmPassword()
        {
            InitializeComponent();
            //_user = Properties.Settings.Default.LoggedInUser;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities(0))
            {
                _user = db.Users.FirstOrDefault(x => x.RoleId == 2);
            }
            if (_user != null)
            {
                string NewPass, RenewPass;
                NewPass = newPasstb.Text.Trim();
                RenewPass = renewPasstb.Text.Trim();
                if (_user.Password == NewPass)
                {
                    if (NewPass == RenewPass)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("تم تأكيد العملية بنجاح");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("كلمة المرور غير مطابقة، يرجى التأكد");
                    }
                }
                else
                {
                    MessageBox.Show("كلمة المرور غير صحيحة، يرجى التأكد من صحة الكلمة");
                }
            }
        }

        private void LoadData()
        {
            //db = new dbEntities(0);
            //db.Configuration.ProxyCreationEnabled = false;
            //db.Users_User.Load();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
    }
}