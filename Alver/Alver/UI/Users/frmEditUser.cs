using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
namespace Alver.UI.Users
{
    public partial class frmEditUser : Form
    {
        int _userId = 0;
        List<User> _users;
        //User _user;
        //Role _role;
        public frmEditUser(int UserId)
        {
            _userId = UserId;
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadDate();
        }
        private void LoadDate()
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _users = new List<User>();
                    db.Roles.AsQueryable().AsNoTracking().Load();
                    roleBindingSource.DataSource = db.Roles.AsQueryable().AsNoTracking().ToList();
                    _users = db.Users.Where(x => x.Id != _userId).ToList();
                    //_role = db.Roles.Find(_roleId);
                    User _user = db.Users.Find(_userId);
                    rolescb.SelectedValue = _user.RoleId;
                    usernametb.Text = _user.UserName;
                    fullnametb.Text = _user.FullName;
                    passwordconfirmtb.Text= passwordtb.Text = _user.Password;
                    notestextBox.Text = _user.Declaration;
                }
            }
            catch(Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            
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
                    else if (_users.Any(x => x.UserName.ToLower().Trim() == usernametb.Text.ToLower().Trim()))
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
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            return _result;
        }
        private void Save()
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    int _roleId = (int)rolescb.SelectedValue;
                    //_role = db.Roles.Find(_roleId);
                    User _user = db.Users.Find(_userId);
                    _user.RoleId = _roleId;
                    _user.UserName = usernametb.Text.Trim();
                    _user.FullName = fullnametb.Text.Trim();
                    _user.Password = passwordtb.Text;
                    _user.Declaration = notestextBox.Text.Trim();
                    // _user.LUD = DateTime.Now;
                    // _user.Hidden = false;
                    // _user.Flag = string.Empty;
                    //  _user.PROTECTED = false;
                    //_user.CD = DateTime.Now;
                    db.SaveChanges();
                    MessageBox.Show("تم حفظ التعديلات بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValues())
                    return;
                Save();
                this.Close();
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حصل خطأ أثناء حفظ التعديلات");
            }
        }
    }
}
