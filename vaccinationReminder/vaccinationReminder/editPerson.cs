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
    public partial class editPerson : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DA8CPQ1\SQLEXPRESS; Initial Catalog=vaccinationReminder; Integrated Security=True;");
        SqlCommand cmd;
        public editPerson()
        {
            InitializeComponent();
        }
        public editPerson(string str)
        {
            InitializeComponent();
            this.label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update person set name='" + this.textBox1.Text + "' where personID = " + this.label1.Text + " ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editPerson_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select name from person where personID = " + this.label1.Text + " ", con);
            con.Open();
            SqlDataReader readerPerson = cmd.ExecuteReader();
            readerPerson.Read();
            this.textBox1.Text = readerPerson.GetValue(0).ToString();
            readerPerson.Close();
            con.Close();

       }
    }
}
