using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alver.Misc
{
    public static class Utilities
    {
        public enum BillType
        {
            بيع, شراء
        }
        public enum AccountGroup
        {
            وكيل_حوالات, مختلط, شريك, صاحب_ذمة, تعاملات_مالية
        }
        public enum PaymentType
        {
            دفعة_من_وكيل, دفعة_لوكيل, تغذية_صندوق, سحب_من_صندوق
        }
        public enum WageOrigin
        {
            وكيل_مقبوض,
            وكيل_مدفوع,
            وكيل_غير_مقبوض,
            مكتب_مقبوض,
            مكتب_عند_الوكيل
        }
        public enum RemittanceType
        {
            صادرة,
            واردة,
            خارجية
        }
        public enum ExchangeType
        {
            بيع, شراء
        }
        public enum Factor
        {
            M, D
        }
        public enum PaymentTransactionType
        {
            دين_مدفوع,
            دين_مقبوض,
            أمانة_مستلمة,
            أمانة_مسلمة
        }
       
        public enum WithdrawDirections
        {
            سحب_أرباح, إيداع_أرباح
        }
        public static void OpenCalculator()
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            //Thread _thread=new Thread(new )
        }
        public static decimal cConvert(bool Factor, decimal Rate, decimal amount)
        {
            //Factor = True ==> * ||Factor = False ==> /
            decimal _value = amount;
            if (Rate != 0)
            {
                if (Factor)
                {
                    _value = amount * Rate;
                }
                else
                {
                    _value = amount / Rate;
                }
            }
            _value = Math.Round(_value, 2);
            return _value;
        }
        public static void formLoad(ref dbEntities db)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            //db.Configuration.AutoDetectChangesEnabled = false;
            //db.Configuration.ValidateOnSaveEnabled = false;
        }
        public static DataGridView _dgv;
        public static void ComboBoxBlackBGFix(DataGridView dgv, DataGridViewEditingControlShowingEventArgs e)
        {
            var comboBox = e.Control as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                _dgv = dgv;
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.DropDown -= new EventHandler(combo_DropDown);
                comboBox.DropDown += new EventHandler(combo_DropDown);
            }
        }
        public static void combo_DropDown(object sender, EventArgs e)
        {
            ((ComboBox)sender).BackColor = _dgv.DefaultCellStyle.BackColor;
        }
        public static void SaveChanges(ref dbEntities db, ref List<BindingSource> bss, Form frm)
        {
            try
            {
                frm.Validate();
                foreach (BindingSource bs in bss)
                {
                    bs.EndEdit();
                }
                db.SaveChanges();
                MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(string.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                //throw;
            }
        }
        public static void SaveChanges(ref dbEntities db, Form frm, string msg = "")
        {
            try
            {
                frm.Validate();
                db.SaveChanges();
                if (msg != "")
                {
                    MessageBox.Show("تم الحفظ بنجاح" + Environment.NewLine + "رقم إشعار الحوالة: " + msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }
                else
                {
                    MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(string.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                //throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم تم الحفظ بنجاح" + Environment.NewLine + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }
        public static void ResetBindings(ref List<BindingSource> bss)
        {
            try
            {
                foreach (BindingSource bs in bss)
                {
                    bs.ResetBindings(false);
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(string.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                //throw;
            }
        }
        public static void RollBack(ref dbEntities db)
        {
            //dbContext.Entry(entity).Reload();
            //dataContext.customer.Context.Refresh(RefreshMode.StoreWins, item);
            //    public void Rollback()
            //{
            //    dataContext.Dispose();
            //    dataContext = new MyEntities(yourConnection);
            //}
            try
            {
                foreach (var entry in db.ChangeTracker.Entries())
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                        case EntityState.Deleted:
                            entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                            entry.State = EntityState.Unchanged;
                            break;
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                    }
                }
                MessageBox.Show("تم التراجع عن التعديلات", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            catch (Exception ex) { }
        }
        public static decimal ColumnSum(DataGridView dgv, int index)
        {
            decimal totalSum = 0;
            totalSum = decimal.Parse(dgv.Rows.OfType<DataGridViewRow>()
                .Sum(row => Convert.ToDecimal(row.Cells[index].Value))
                .ToString());
            return Convert.ToDecimal(totalSum.ToString());
        }
        public static void ColorizeDecimalDGV(DataGridView dgv, int index)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (decimal.Parse(dgv.Rows[i].Cells[index].FormattedValue.ToString()) < 0)
                    {
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeDecimalDGVCells(DataGridView dgv)
        {
            decimal _val;
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 2; j < dgv.Rows[i].Cells.Count; j++)
                    {
                        if (decimal.TryParse(dgv.Rows[i].Cells[j].FormattedValue.ToString(), out _val))
                            if (_val < 0)
                            {
                                dgv.Rows[i].Cells[j].Style.BackColor = Color.Tomato;
                            }
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeGain(DataGridView dgv)
        {
            decimal _val;
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    {
                        if (decimal.TryParse(dgv.Rows[i].Cells[j].FormattedValue.ToString(), out _val))
                            if (_val < 0)
                            {
                                dgv.Rows[i].Cells[j].Style.BackColor = Color.Tomato;
                            }
                            else
                            {
                                dgv.Rows[i].Cells[j].Style.BackColor = Color.LawnGreen;
                            }
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeForeColor(DataGridView dgv, int index)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    //for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    //{
                    if (dgv.Rows[i].Cells[index].FormattedValue.ToString() == "لكم")
                    {
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    //}
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeStringForeColorDGV(DataGridView dgv, int index, string _check)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    //for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    //{
                    if (dgv.Rows[i].Cells[index].FormattedValue.ToString() == _check)
                    {
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    //}
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeStringDGV(DataGridView dgv, int index, string _check)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[index].FormattedValue.ToString() == _check)
                    {
                        //dgv.Rows[i].Cells[index].Style.BackColor = System.Drawing.Color.Red;
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Tomato;
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeForeFontStringDGV(DataGridView dgv, int index, string _check)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[index].FormattedValue.ToString() == _check)
                    {
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeExchangesDGV(DataGridView dgv, int index)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[index].FormattedValue.ToString() == Utilities.ExchangeType.بيع.ToString())
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Tomato;
                    }
                    else
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LawnGreen;
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeBoolDGV(DataGridView dgv, int index, bool Factor, Color color)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (bool.Parse(dgv.Rows[i].Cells[index].FormattedValue.ToString()) == Factor)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = color;
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeBoolPayedDGV(DataGridView dgv, int index)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (!bool.Parse(dgv.Rows[i].Cells[index].FormattedValue.ToString()))
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Tomato;
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static void ColorizeCurrencyDGV(DataGridView dgv, int index)
        {
            string _val;
            const string USD = "دولار امريكي";
            const string SYP = "ليرة سورية";
            const string TL = "ليرة تركية";
            const string EUR = "يورو";
            const string SAR = "ريال سعودي";

            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                    {
                        _val = dgv.Rows[i].Cells[j].FormattedValue.ToString();
                        switch (_val)
                        {
                            case USD:
                                dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                                break;
                            case SYP:
                                dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                                break;
                            case TL:
                                dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                                break;
                            case EUR:
                                dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                                break;
                            case SAR:
                                dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Fuchsia;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        public static void dgvCheckNumericCell(DataGridViewCellValidatingEventArgs e, int cellIndex)
        {
            try
            {
                if (e.ColumnIndex == cellIndex)
                {
                    int i;
                    double d;
                    if (!int.TryParse(e.FormattedValue.ToString(), out i))
                    {
                        if (!double.TryParse(e.FormattedValue.ToString(), out d))
                        {
                            e.Cancel = true;
                            MessageBox.Show("please enter numeric");
                        }
                    }
                }
            }
            catch (Exception) { }
        }
        public static void dgvRowDelete(object sender, DataGridViewCellEventArgs e, BindingSource bs)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex].Name.ToLower().Contains("delete"))
            {
                bs.RemoveCurrent();
            }
        }
        static DateTimePicker dtp;
        static DataGridView dgv;
        public static void dgvDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }
        public static bool dgvCheckedChanged(object sender, EventArgs e, int cellIndex)
        {
            bool _checked = false;
            DataGridView dgv = (DataGridView)sender;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[cellIndex];
                if (chk.Value == chk.TrueValue || chk.Value != null)
                {
                    _checked = true;
                }
            }
            dgv.EndEdit();
            return _checked;
        }
        public static void SearchableComboBox(ComboBox _combobox)
        {
            _combobox.DropDownStyle = ComboBoxStyle.DropDown;
            _combobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            _combobox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public static string MD5(this string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                {
                    builder.Append(b.ToString("x").PadLeft(2, '0'));
                }

                return builder.ToString();
            }
        }
        //public bool Exists<T>(T entity) where T : class
        //{
        //    return this.Set<T>().Local.Any(e => e == entity);
        //}
    }
}
