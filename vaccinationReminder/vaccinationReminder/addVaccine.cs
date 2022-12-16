using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vaccinationReminder
{
    public partial class addVaccine : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DA8CPQ1\SQLEXPRESS; Initial Catalog=vaccinationReminder; Integrated Security=True;");
        SqlCommand cmd;


        public addVaccine()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            con.Open();

            if (txtVaccine.Text != "")
            {
                cmd = new SqlCommand("insert into vaccine(vaccine) values('" + txtVaccine.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vaccine details added.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Give the New vaccine name.");
            }
            con.Close();
        }

        private void addPerson_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
