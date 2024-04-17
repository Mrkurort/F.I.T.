using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT
{
    public partial class ClientsUC : UserControl
    {
        public ClientsUC()
        {
            InitializeComponent();

            guna2DateTimePicker1.Enabled = false;
        }

        public Label labelID 
        {
            get { return label10; }
            set { label10 = value; }
        }

        public Label Age
        {
            get { return label11; }
            set { label11 = value; }
        }

        public Label labelClub
        {
            get { return label12; }
            set { label12 = value; }
        }

        public Guna2TextBox TBFIO
        {
            get { return guna2TextBox1; }
            set { guna2TextBox1 = value; }
        }

        public Guna2TextBox TBTel
        {
            get { return guna2TextBox2; }
            set { guna2TextBox2 = value; }
        }

        public Guna2TextBox TBProg
        {
            get { return guna2TextBox3; }
            set { guna2TextBox3 = value; }
        }

        public Guna2TextBox TBTren
        {
            get { return guna2TextBox4; }
            set { guna2TextBox4 = value; }
        }

        public Guna2TextBox TBCompplex
        {
            get { return guna2TextBox5; }
            set { guna2TextBox5 = value; }
        }

        public Guna2DateTimePicker DTab
        {
            get { return guna2DateTimePicker1; }
            set { guna2DateTimePicker1 = value; }
        }

        private void ClientsUC_Load(object sender, EventArgs e)
        {
            if(label12.Text == "Нет")
            {
                label12.ForeColor = Color.Red;
            }
            else
            {
                label12.ForeColor = Color.Green;
            }
        }
    }
}
