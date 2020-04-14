using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Users
{
    public partial class frmUsers : Form
    {
        private dbEntities db;
        private User _user;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;
            LoadData();
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities(0))
            {
                db.Users.Load();
                db.Roles.Load();
                users_UserBindingSource.DataSource = db.Users.Where(x => x.Hidden == false).ToList();
                roleBindingSource.DataSource = db.Roles.Where(x => x.Hidden.Value == false).ToList();
            }
        }

        private void UserDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void UserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                int _userId = (users_UserBindingSource.Current as User).Id;
                frmEditUser frm = new frmEditUser(_userId);
                frm.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //User newUser = UserBindingSource.AddNew() as User;
            //newUser.CD = DateTime.Now;
            //newUser.Locked = false;
            //newUser.IsActive = true;
            //newUser.Hidden = false;
            //newUser.Flag = string.Empty;
            //newUser.GUID = Guid.NewGuid();
            //newUser.PROTECTED = false;
            //newUser.Password = "0";
            //db.Entry(newUser).State = EntityState.Added;

            frmUser frm = new frmUser();
            frm.ShowDialog();
            LoadData();
        }

        private void UserBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                _user = users_UserBindingSource.Current as User;
                if (_user.Locked == null || !_user.Locked.Value)
                {
                    deleteuserbtn.Enabled = true;
                }
                else if (_user.Locked.Value)
                {
                    deleteuserbtn.Enabled = false;
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _user = users_UserBindingSource.Current as User;
                if (_user != null)
                {
                    frmChangePassword frm = new frmChangePassword(_user);
                    frm.ShowDialog();
                    LoadData();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult _ConfirmationDialog = MessageBox.Show("هل انت متأكد من تنفيذ العملية؟، لن تتمكن من التراجع عن تنفيذ العملية!",
                "تنبيه",
                MessageBoxButtons.YesNo);
            if (_ConfirmationDialog != DialogResult.Yes)
                return;
            //if (UserBindingSource.Count > 0 && UserBindingSource.Current != null)
            try
            {
                User _user = users_UserBindingSource.Current as User;
                int _userId = _user.Id;

                if (_user != null && users_UserBindingSource.Count > 0)
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        _user = db.Users.Find(_userId);
                        if (_user.PROTECTED.Value != true)
                        {
                            db.Users.Remove(_user);
                            users_UserBindingSource.RemoveCurrent();
                            db.SaveChanges();
                            MessageBox.Show("تم الحذف بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("لا يمكن حذف المستخدم المحدد!، المستخدم محمي ضد الحذف");
                        }
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حصل خطأ داخلي");
                throw;
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void pdfexportbtn_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.ExportToPDF();
            }
        }
    }
}