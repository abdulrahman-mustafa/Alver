using Alver.DAL;
using Alver.Misc;
using Alver.Properties;
using System;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace Alver.UI.Configuration
{
    public partial class frmSettings : Form
    {
        //dbEntities db;
        int _baseCompanyId = 1;
        Company _company;
        byte[] _image;
        public frmSettings()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            LoadData();
            LoadPrinters();
        }

        private void LoadPrinters()
        {
            string _printerInfo;
            var printerQuery = new ManagementObjectSearcher("SELECT * from Win32_Printer");
            foreach (var printer in printerQuery.Get())
            {
                var name = printer.GetPropertyValue("Name");
                var status = printer.GetPropertyValue("Status");
                var isDefault = printer.GetPropertyValue("Default");
                var isNetworkPrinter = printer.GetPropertyValue("Network");
                _printerInfo = string.Format("{0} (Status: {1}, Default: {2}, Network: {3}",
                name, status, isDefault, isNetworkPrinter);
                printercb.Items.Add(name);
            }
            try { printernamelbl.Text = Settings.Default.BillPrinter; } catch { }
        }

        private void LoadData()
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _company = db.Companies.Find(_baseCompanyId);
                    if (_company != null)
                    {
                        titlelbl.Text = _company.Title;
                        mottolbl.Text = _company.Motto;
                        managerlbl.Text = _company.Manager;
                        managerphonetb.Text = _company.ManagerPhone;
                        accountantlbl.Text = _company.Accountant;
                        accountantphonetb.Text = _company.AccountantPhone;
                        addresslbl.Text = _company.Address;
                        emailaddresstb.Text = _company.EmailAddress;
                        logopb.Image = ControlsExtensions.byteArrayToImage(db.Images.Find(_company.LogoId.Value).ImageData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _company = db.Companies.Find(_baseCompanyId);
                    if (_company != null)
                    {
                        _company.Title = titlelbl.Text;
                        _company.Motto = mottolbl.Text;
                        _company.Manager = managerlbl.Text;
                        _company.Accountant = accountantlbl.Text;
                        _company.ManagerPhone = managerphonetb.Text;
                        _company.AccountantPhone = accountantphonetb.Text;
                        _company.Address = addresslbl.Text;
                        _company.EmailAddress = emailaddresstb.Text;
                        System.Drawing.Image _img = logopb.Image;
                        if (db.Images.Count() <= 0)
                            AddImage(_img);
                        db.Images.Find(_company.LogoId).ImageData = _img.imageToByteArray();
                        db.SaveChanges();
                        string _printerName = printercb.Text.Trim();
                        Settings.Default.BillPrinter = _printerName;
                        Settings.Default.Save();
                        MessageBox.Show("تم الحفظ بنجاح");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي");
            }
        }

        private static void AddImage(System.Drawing.Image _img)
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    DAL.Image _image = new DAL.Image();
                    _image.AlbumId = 1;
                    _image.Flag = string.Empty;
                    _image.GUID = Guid.NewGuid();
                    _image.ImageTitle = "شعار الشركة";
                    _image.LUD = DateTime.Now;
                    _image.ImageData = _img.imageToByteArray();
                    db.Set<DAL.Image>().Add(_image);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ اثناء حفظ لوغو الشركة");
            }

        }

        private void logopb_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                logopb.Image = System.Drawing.Image.FromFile(opf.FileName);
                addresslbl.Text = logopb.Image.imageToByteArray().ToString();
            }
        }
        private void companybtn_Click(object sender, EventArgs e)
        {
            CompanyTablControl.SelectedTab = companytabpage;
        }
        private void printerbtn_Click(object sender, EventArgs e)
        {
            CompanyTablControl.SelectedTab = printertabpage;
        }
    }
}
