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
    public partial class MainPage : Form
    {
        ComputerSaleDBTableAdapters.CustomerTableAdapter cds = new ComputerSaleDBTableAdapters.CustomerTableAdapter();
        ComputerSaleDBTableAdapters.EmployeeTableAdapter eds = new ComputerSaleDBTableAdapters.EmployeeTableAdapter();
        public static string admName, uName, psw, descrpt;
        public static string cName, cEmail, cPhone, cAddress;
        public MainPage()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnClsfrmAdm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSavefrmAdm_Click(object sender, EventArgs e)
        {   
            if (textBox1.Text=="")
            {
                MessageBox.Show("Please Enter Admin Name", "Admin Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter User Name", "Admin Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter Your Password", "Admin Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter Description", "Admin Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
            else
            {
               
                admName = textBox1.Text;
                uName = textBox2.Text;
                psw = textBox3.Text;
                descrpt = textBox4.Text;
                string role = "Admin";
                // MessageBox.Show("Admin Name: " + admName + "\n" + "User Name: " + uName + "\n" + "Password: " + psw + "\n" + "Description: " + descrpt + "\n", "Registration Process ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                eds.Insert(admName, uName, psw, role, descrpt);
                MessageBox.Show("Admin Save Success", "Register Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                //textBox1.Text = "";
                //textBox1.Focus();
                //this.Hide();
                //displayuser d = new displayuser();
                //d.ShowDialog(); 
            }
          
        }

        private void SavefrmC_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox8.Focus();
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Please Enter Email", "Customer Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Focus();
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
            }
           
            cName = textBox8.Text;
            cEmail = textBox7.Text;
            cPhone = textBox6.Text;
            cAddress = textBox5.Text;
            //MessageBox.Show("Customer Name :" + cName + "\n" + "Customer Email :" + cEmail + "\n"+ "Customer Phone :" + cPhone +"\n" + "Customer Address" + cAddress +"\n", "Customer Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            cds.Insert(cName, cEmail, cPhone, cAddress);
            MessageBox.Show("Customer Save Success", "Register Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //textBox8.Clear();
            //textBox7.Clear();
            //textBox6.Clear();
            //textBox5.Clear();
            //textBox8.Focus();
            //this.Hide();
            //displayuser d = new displayuser();
            //d.ShowDialog();




        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
