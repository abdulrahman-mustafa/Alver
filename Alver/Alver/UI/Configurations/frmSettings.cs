using Alver.DAL;
using Alver.Misc;
using System;
using System.Linq;
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
                        logopb.Image = Extensions.byteArrayToImage(db.Images.Find(_company.LogoId.Value).ImageData);
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
    }
}
