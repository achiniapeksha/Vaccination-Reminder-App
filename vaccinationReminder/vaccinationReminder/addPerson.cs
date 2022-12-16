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
    public partial class addPerson : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DA8CPQ1\SQLEXPRESS; Initial Catalog=vaccinationReminder; Integrated Security=True;");
        SqlCommand cmd;


        public addPerson()
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
            if (txtName.Text != "" && dateTimePicker1.Text != "")
            {
                cmd = new SqlCommand("insert into person(name,DOB) values('" + txtName.Text + "','" + dateTimePicker1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Person details added.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please don't put Empty.");
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
