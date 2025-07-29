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
    public partial class LoginForm : Form
    {
        ComputerSaleDBTableAdapters.EmployeeTableAdapter eds = new ComputerSaleDBTableAdapters.EmployeeTableAdapter();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage m = new MainPage();
            m.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Pls Enter User Name","Login Form",MessageBoxButtons.OKCancel);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Pls Enter User Password", "Login Form", MessageBoxButtons.OKCancel);
                textBox2.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                String UserName, Password;
                UserName = textBox1.Text;
                Password = textBox2.Text;
                dt = eds.CheckEmployee(UserName, Password);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ComputerSaleSystem c = new ComputerSaleSystem();
                    c.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Data");
                }
            }
        }

    }
    }

