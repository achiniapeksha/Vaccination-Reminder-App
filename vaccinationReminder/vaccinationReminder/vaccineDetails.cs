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
    public partial class vaccineDetails : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DA8CPQ1\SQLEXPRESS; Initial Catalog=vaccinationReminder; Integrated Security=True;");
        SqlCommand cmd;
        SqlCommand cmdDues;

        public vaccineDetails()
        {
            InitializeComponent();
        }
        public vaccineDetails(string str,string vaccineID)
        {
            InitializeComponent();
            this.vaccine.Text = str;
            this.lblVaccineID.Text = vaccineID;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void vaccineDetails_Load(object sender, EventArgs e)
        {
            string vaccineID = this.lblVaccineID.Text.Substring(0, 4);
            int personID = int.Parse(this.vaccine.Text);

            cmd = new SqlCommand("select vaccine from vaccine where vaccineID='"+int.Parse(vaccineID)+"' ",con);
            cmdDues = new SqlCommand("select sheduleDate,givenDate,hospital,fee,note from dues where vaccineID='" + int.Parse(vaccineID) + "' and personID='" + personID + "' ", con);

            con.Open();


            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.vaccineName.Text = reader.GetValue(0).ToString();
            reader.Close();


            SqlDataReader readerDues = cmdDues.ExecuteReader();
            if (readerDues.Read())
            {
                this.sheduleDate.Text = readerDues.GetValue(0).ToString();
                this.givenDate.Text = readerDues.GetValue(1).ToString();
                this.hospital.Text = readerDues.GetValue(2).ToString();
                this.fee.Text = readerDues.GetValue(3).ToString();
                this.note.Text = readerDues.GetValue(4).ToString();
            }
            else
            {
                this.sheduleDate.Text = "";
                this.givenDate.Text = "";
                
            }
            readerDues.Close();

            con.Close();



        }


        private void button1_Click(object sender, EventArgs e)
        {
            int personID = int.Parse(this.vaccine.Text);
            string vaccineID = this.lblVaccineID.Text.Substring(0,4);
            decimal fee = decimal.Parse(this.fee.Text);
            SqlCommand cmdInsert = new SqlCommand("insert into dues(personID,vaccineID) values('" + personID + "' , '" + int.Parse(vaccineID) + "')  ", con);
            cmd = new SqlCommand("update dues set sheduleDate='" + this.sheduleDate.Text + "' , givenDate= '" + this.givenDate.Text + "',hospital='" + this.hospital.Text + "' , fee= '" + fee + "', note= '" + this.note.Text + "'  where personID like " + personID + " and vaccineID like " + int.Parse(vaccineID) + "  ", con);
            //SqlCommand cmdVaccine = new SqlCommand("update vaccine set   where vaccineID like " + int.Parse(vaccineID) + "  ", con);

            con.Open();

            try
            {
                cmdInsert.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                //cmdVaccine.ExecuteNonQuery();
            }
            catch {
                cmd.ExecuteNonQuery();
                //cmdVaccine.ExecuteNonQuery();
            }
            MessageBox.Show("Updated Vaccine Details.");

            //hospital= , fee= , note=
            con.Close();
            this.Close();
        }

        private void fee_Click(object sender, EventArgs e)
        {
            
        }

        private void lblVaccineID_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmdDeleteDues = new SqlCommand("delete dues where personID= '" + this.vaccine.Text + "' and vaccineID='" + this.lblVaccineID.Text.Substring(0, 4) + "'", con);

            if (MessageBox.Show("Do you want to delete this vaccine details ?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlDataReader readerDelete2 = cmdDeleteDues.ExecuteReader();
                readerDelete2.Close();
                MessageBox.Show("Vaccine Details Deleted.");

            }
            con.Close();
        }
    }
}
