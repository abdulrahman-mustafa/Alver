using Alver.DAL;
using Alver.MISC;
using Alver.Properties;
using Alver.UI.Accounts;
using Alver.UI.Accounts.AccountsPayments;
using Alver.UI.Accounts.Transactions;
using Alver.UI.Accounts.Transfers;
using Alver.UI.Accounts.Withdraws;
using Alver.UI.Bills;
using Alver.UI.Configuration;
using Alver.UI.Exchange;
using Alver.UI.Funds;
using Alver.UI.Funds.Transactions;
using Alver.UI.Items;
using Alver.UI.Items.Transactions;
using Alver.UI.Payments.Deposites;
using Alver.UI.Payments.Expenses;
using Alver.UI.Payments.Loans;
using Alver.UI.Users;
using Alver.UI.Utilities;
using System;
using System.Windows.Forms;

namespace Alver.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void InitInfo()
        {
            User _user = Properties.Settings.Default.LoggedInUser;
            if (_user != null)
            {
                usernameLabel.Text = _user.FullName;
            }
            databasenamelbl.Text = (new dbEntities(0)).Database.Connection.Database;
            if (new dbEntities(0).Companies.Find(1) != null)
            {
                companytitlelbl.Text = (new dbEntities(0)).Companies.Find(1).Title;
                addresslbl.Text = (new dbEntities(0)).Companies.Find(1).Address;
                phonelbl.Text = (new dbEntities(0)).Companies.Find(1).ManagerPhone;
                runtimeslbl.Text = Settings.Default.RunTimes.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("يجب اضافة شركة قبل البدء بالعمل ");
                (new frmSettings()).ShowDialog();
                timer1.Start();
                InitInfo();
            }
            clocklbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.LoggedInUser.FullName.ToString());
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.Show();
        }

        private void addExpensebtn_Click(object sender, EventArgs e)
        {
            frmExpense frm = new frmExpense(null);
            frm.Show();
        }

        private void viewExpensesbtn_Click(object sender, EventArgs e)
        {
            frmExpenses frm = new frmExpenses();
            frm.Show();
        }

        private void expensesCategoriesbtn_Click(object sender, EventArgs e)
        {
            frmExpensessCategory frm = new frmExpensessCategory();
            frm.Show();
        }

        private void addLoanbtn_Click(object sender, EventArgs e)
        {
            frmLoan frm = new frmLoan(null);
            frm.Show();
        }

        private void viewLoansbtn_Click(object sender, EventArgs e)
        {
            frmLoans frm = new frmLoans(null);
            frm.Show();
        }

        private void addDepositebtn_Click(object sender, EventArgs e)
        {
            frmDeposite frm = new frmDeposite(null);
            frm.Show();
        }

        private void viewDepositesbtn_Click(object sender, EventArgs e)
        {
            frmDeposites frm = new frmDeposites(null);
            frm.Show();
        }

        private void addclientbtn_Click(object sender, EventArgs e)
        {
            frmAddAccount frm = new frmAddAccount();
            frm.Show();
        }

        private void clientsbtn_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts(null);
            frm.Show();
        }

        private void إضافةدفعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment(null);
            frm.Show();
        }

        private void عرضالدفعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments(null);
            frm.Show();
        }

        private void clientoverviewbtn_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            frm.Show();
        }

        private void cutbtn_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer(null);
            frm.Show();
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            frmTransferFunds frm = new frmTransferFunds(null);
            frm.Show();
        }

        private void إضافةحركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdraw frm = new frmWithdraw(null);
            frm.Show();
        }

        private void عرضالحركاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdraws frm = new frmWithdraws();
            frm.Show();
        }

        private void عرضالعملياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransfers frm = new frmTransfers();
            frm.Show();
        }

        private void عرضالحركاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRefunds frm = new frmRefunds(null);
            frm.Show();
        }

        private void كشفحسابتفصيليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFundTransactions frm = new frmFundTransactions();
            frm.Show();
        }

        private void إضافةحركةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRefund frm = new frmRefund(null);
            frm.Show();
        }

        private void floatingfundsbtn_Click(object sender, EventArgs e)
        {
            //frmFloatingFunds frm = new frmFloatingFunds();
            //frm.Show();
            frmFunds frm = new frmFunds();
            frm.Show();
        }

        private void sellbillbtn_Click(object sender, EventArgs e)
        {
            frmSell frm = new frmSell();
            frm.Show();
        }

        private void تصنيفاتالموادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemCategory frm = new frmItemCategory();
            frm.Show();
        }

        private void إضافةمادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.ShowDialog();
        }

        private void الواحداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemUnit frm = new frmItemUnit();
            frm.Show();
        }

        private void عرضالموادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItems frm = new UI.Accounts.frmItems(null);
            frm.Show();
        }

        private void إضافةعملياتصرافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExchange frm = new frmExchange();
            frm.Show();
        }

        private void نشرةالأسعارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrenciesBulletin frm = new frmCurrenciesBulletin();
            frm.Show();
        }

        private void كشفحسابمادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemTransactions frm = new frmItemTransactions();
            frm.Show();
        }

        private void OpenLoginForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
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

        private void أخذنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DatabaseFuncs.BKDB();
                //DatabaseFuncs.BackupDatabase();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void استرجاعنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DatabaseFuncs.RestoreDatabase();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            this.Close();
            t.Start();
        }

        private void buybillbtn_Click(object sender, EventArgs e)
        {
            //frmPurchase frm = new frmPurchase();
            frmPurchase frm = new frmPurchase();
            frm.Show();
        }

        private void تصنيفاتالوكلاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountsGroups frm = new frmAccountsGroups();
            frm.Show();
        }

        private void تسعيرالموادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPricingItems frm = new frmPricingItems();
            frm.Show();
        }

        private void BodysplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void مطابقاتالوكلاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountsOverview frm = new frmAccountsOverview();
            frm.Show();
        }

        private void كمياتالموادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemsOverview frm = new frmItemsOverview();
            frm.Show();
        }

        private void إعدادتالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.Show();
        }

        private void مساعدإعدادقاعدةالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _msg = "هذه نافذة تتطلب خبير قواعد بيانات للتعامل معها بشكل صحيح، وإلا قد تفقد جميع بياناتك. هل تريد الاستمرار؟؟؟!";
            DialogResult _ConfirmationDialog = MessageBox.Show(_msg, "تأكيد!!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign);
            if (_ConfirmationDialog == DialogResult.Yes)
            {
                frmDBTools frm = new frmDBTools();
                frm.Show();
            }
        }

        private void billmanagementbtn_Click(object sender, EventArgs e)
        {
            frmBillMangement frm = new frmBillMangement();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mainmenustrip.ForeColor = System.Drawing.Color.WhiteSmoke;
            timer1.Start();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Default.AskForBKUP)
            {
                string _msg = "هل تريد اخذ نسخة احتياطية للبيانات قبل الخروج من البرنامج؟";
                DialogResult _ConfirmationDialog = MessageBox.Show(_msg, "تأكيد!!!!",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign);
                if (_ConfirmationDialog == DialogResult.Yes)
                {
                    أخذنسخةاحتياطيةToolStripMenuItem_Click(null, null);
                }
                e.Cancel = (_ConfirmationDialog == DialogResult.Cancel);
            }
        }

        private void كشفحركةالمادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemMovements frm = new frmItemMovements();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                InitInfo();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            POS frm = new POS();
            frm.Show();
        }

        private void حولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void HeadersplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}