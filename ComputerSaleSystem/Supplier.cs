using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComputerSaleSystem
{
    public partial class Supplier : Form
    {
        ComputerSaleDBTableAdapters.SupplierTableAdapter sds = new ComputerSaleDBTableAdapters.SupplierTableAdapter();
        public Supplier()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            ofdsupplierimage.InitialDirectory = @"C;\";
            ofdsupplierimage.Title = "Browse Image Files";
            ofdsupplierimage.Filter = "PNG File(*.png) | *.png | JPEG File (*.jpg)|*.jpg";
            ofdsupplierimage.FilterIndex = 1;
            ofdsupplierimage.ShowDialog();
            picSupImage.Text = ofdsupplierimage.FileName;
            Image newImage = Image.FromFile(ofdsupplierimage.FileName);
            picSupImage.Image = newImage;
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MemoryStream ms1 = new MemoryStream();
            picSupImage.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            int data=sds.InsertSupplier(txtSupName.Text, txtEmail.Text, txtPhNo.Text, txtAddress.Text);
            if (data>0)
            {
                MessageBox.Show("Supplier Save Success", "Supplier Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            int a = 1;
        }
    }
}
