using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Users
{
    public partial class frmUser : Form
    {
        private User _user;

        //Role _role;
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadDate();
            ControlsEnable(false);
        }

        private void ControlsEnable(bool _enable)
        {
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }

        private void LoadDate()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Roles.AsQueryable().AsNoTracking().Load();
                roleBindingSource.DataSource = db.Roles.AsQueryable().AsNoTracking().ToList();
            }
            MISC.Utilities.SearchableComboBox(rolescb);
        }

        private void addNew()
        {
            ClearForm();
        }

        private void ClearForm()
        {
            rolescb.Text = string.Empty;
            fullnametb.Text = string.Empty;
            usernametb.Text = string.Empty;
            passwordconfirmtb.Text = string.Empty;
            passwordtb.Text = string.Empty;
            notestextBox.Text = string.Empty;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addNew();
            ControlsEnable(true);
        }

        private bool CheckValues()
        {
            bool _result = true;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    if (string.IsNullOrWhiteSpace(rolescb.Text.Trim()))
                    {
                        MessageBox.Show("الرجاء التأكد من نوع المستخدم، لا يجب ان يكون نوع المستخدم فارغاً");
                        rolescb.Focus();
                        _result = false;
                    }
                    else if (db.Users.Any(x => x.UserName.ToLower().Trim() == usernametb.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("اسم المستخدم موجود من قبل، يرجى اختيار اسم آخر");
                        usernametb.Focus();
                        _result = false;
                    }
                    else if (passwordtb.Text.Trim() != passwordconfirmtb.Text.Trim())
                    {
                        MessageBox.Show("كلمة السر غير متطابقة يرجى التأكد من صحة كتابة كلمة السر وتأكيد كلمة السر");
                        passwordconfirmtb.Focus();
                        _result = false;
                    }
                }
            }
            catch (Exception ex) { }
            return _result;
        }

        private void PrepareItem()
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    Guid _guid = Guid.NewGuid();
                    int _roleId = (int)rolescb.SelectedValue;
                    //_role = db.Roles.Find(_roleId);
                    //_user = new User
                    //{
                    //    RoleId = _roleId,
                    //    UserName = usernametb.Text.Trim(),
                    //    FullName = fullnametb.Text.Trim(),
                    //    Password = passwordtb.Text,
                    //    Declaration = notestextBox.Text.Trim(),
                    //    LUD = DateTime.Now,
                    //    Hidden = false,
                    //    Flag = string.Empty,
                    //    GUID = _guid,
                    //    PROTECTED = false,
                    //    CD = DateTime.Now
                    //};
                    _user = new User();
                    _user.RoleId = _roleId;
                    _user.UserName = usernametb.Text.Trim();
                    _user.FullName = fullnametb.Text.Trim();
                    _user.Password = passwordtb.Text;
                    _user.Declaration = notestextBox.Text.Trim();
                    _user.LUD = DateTime.Now;
                    _user.Hidden = false;
                    _user.Flag = string.Empty;
                    _user.GUID = _guid;
                    _user.PROTECTED = false;
                    _user.CD = DateTime.Now;
                    db.Set<User>().Add(_user);
                    db.SaveChanges();
                    MessageBox.Show("تم إضافة المستخدم بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dbEntities db = new dbEntities())
                    {
                        //Navigation properties
                        //_user.Role = _role;
                        //db.Set<User>().Add(_user);
                        //// use the following statement so that Childs won't be inserted
                        //db.Entry(_role).State = EntityState.Detached;
                        //db.SaveChanges();
                        //MessageBox.Show("تم إضافة المستخدم بنجاح");
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ أثناء حفظ المستخدم");
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValues())
                    return;
                PrepareItem();
                //Save();
                ControlsEnable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ أثناء حفظ المستخدم");
            }
        }

        private void frmUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                addbtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }
    }
}