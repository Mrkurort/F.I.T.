using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FIT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string con = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = F.I.T; Integrated Security = SSPI";

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            string chek = $"SELECT * FROM Client";

            try
            {

                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(chek, sqlConnection))
                {
                    

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        ClientsUC cuc = new ClientsUC();

                        cuc.labelID.Text = Convert.ToString(reader.GetInt32(0));
                        cuc.TBFIO.Text = reader.GetString(1);
                        cuc.Age.Text = Convert.ToString(reader.GetInt32(2));
                        cuc.TBTel.Text = reader.GetString(3);
                        cuc.TBProg.Text = reader.GetString(4);
                        cuc.TBTren.Text = reader.GetString(5);
                        cuc.TBCompplex.Text = reader.GetString(6);
                        cuc.labelClub.Text = reader.GetString(7);
                        cuc.DTab.Value = reader.GetDateTime(8);

                        flowLayoutPanel1.Controls.Add(cuc);
                    }


                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
