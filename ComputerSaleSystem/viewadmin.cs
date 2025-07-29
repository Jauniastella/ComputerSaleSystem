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
    public partial class viewadmin : Form
    {
        ComputerSaleDBTableAdapters.EmployeeTableAdapter eds = new ComputerSaleDBTableAdapters.EmployeeTableAdapter();
        public viewadmin()
        {
            InitializeComponent();
        }

        private void lbldisplay_Load(object sender, EventArgs e)
        {
            dgvDisplayEmployee.DataSource = eds.GetData();
        }
    }
}
