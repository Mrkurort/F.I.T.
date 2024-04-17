using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string con = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = F.I.T; Integrated Security = SSPI";
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            if(login.Text == "Admin" && password.Text == "4321")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }

        }
    }
}
