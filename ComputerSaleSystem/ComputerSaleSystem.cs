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
    public partial class ComputerSaleSystem : Form
    {
        public ComputerSaleSystem()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegister_Click(object sender, EventArgs e)
        {
            MainPage m = new MainPage();
            m.ShowDialog();
        }

        

        private void customerreport_Click(object sender, EventArgs e)
        {
            displayuser u = new displayuser();
            u.ShowDialog();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewadmin a = new viewadmin();
            a.ShowDialog();
        }

        private void mnusupplier_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.ShowDialog();
        }
    }
}
