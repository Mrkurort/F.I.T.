using Guna.UI2.WinForms;
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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        string con = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = F.I.T; Integrated Security = SSPI";

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked == true)
            {
                guna2CheckBox1.Text = "Есть";
                guna2CheckBox1.ForeColor = Color.Green;
            }
            else
            {
                guna2CheckBox1.Text = "Нет";
                guna2CheckBox1.ForeColor = Color.Red;
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection sqlConnection = new SqlConnection(con);
            string chek = $"Insert * FROM Client";

            try
            {

                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(chek, sqlConnection))
                {


                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        
                    }


                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
    
    }
}
