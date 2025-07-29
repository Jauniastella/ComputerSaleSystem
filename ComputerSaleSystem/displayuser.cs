using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerSaleSystem
{

    public partial class displayuser : Form
    {
        ComputerSaleDBTableAdapters.CustomerTableAdapter cds = new ComputerSaleDBTableAdapters.CustomerTableAdapter();
        public displayuser()
        {
            InitializeComponent();
        }

        private void displayuser_Load(object sender, EventArgs e)
        {
            //if (MainPage.admName=="")
            //{
            //    lbldisplay.Text = "Customer Name: " + MainPage.cName;
            //}

            // lbldisplay.Text = "Admin Name: " + MainPage.admName;

            dgvDisplayCustomer.DataSource = cds.GetData();

        }
    }
}
