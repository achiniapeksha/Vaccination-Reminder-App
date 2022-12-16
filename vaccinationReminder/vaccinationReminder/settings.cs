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
    public partial class settings : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DA8CPQ1\SQLEXPRESS; Initial Catalog=vaccinationReminder; Integrated Security=True;");
        SqlCommand cmd;

        string currentTime;
        string messageTime;
        string currentDate;
        string messageDate;
        string sheduleDate;
        string vaccine;
        string person;
        public settings()
        {
            InitializeComponent();
            cmd = new SqlCommand("select personID,vaccineID,sheduleDate,givenDate from dues", con);
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            sheduleDate = reader.GetValue(2).ToString();
            vaccine = reader.GetValue(1).ToString();
            person = reader.GetValue(0).ToString();
            con.Close();


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            MessageBox.Show("Saved settings.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToShortTimeString();
            currentDate = DateTime.Now.ToShortDateString();

        }

        private void settings_Load(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select vaccineID,vaccine from vaccine where vaccineID='"+vaccine+"'", con);
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            
            string vaccineName = reader.GetValue(1).ToString();
            reader.Close();
            con.Close();


            SqlCommand cmdPerson = new SqlCommand("select name from person where personID='" + person + "'", con);
            SqlDataReader readerPerson;
            con.Open();
            readerPerson = cmdPerson.ExecuteReader();
            readerPerson.Read();

            string personName = readerPerson.GetValue(0).ToString();
            readerPerson.Close();
            con.Close();

            messageTime = maskedTextBox1.Text + " " + comboBox1.Text;
            messageDate = sheduleDate.Substring(0, 10);
            if (currentTime == messageTime && currentDate==messageDate && checkBox1.CheckState == CheckState.Checked)
            {
                timer2.Stop();
                MessageBox.Show(personName+" has to get "+vaccineName+" vaccine in "+messageDate);
                notifyIcon1.ShowBalloonTip(1000, "Important", "jbj", ToolTipIcon.Info);
                //this.Hide();
                
            }
            
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addVaccine newVaccine = new addVaccine();
            newVaccine.Show();
        }
    }
}
