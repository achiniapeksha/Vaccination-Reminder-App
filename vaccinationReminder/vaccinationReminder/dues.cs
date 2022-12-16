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
    public partial class dues : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DA8CPQ1\SQLEXPRESS; Initial Catalog=vaccinationReminder; Integrated Security=True;");
        SqlCommand cmd;

        public dues()

        {
            InitializeComponent();
        }

        public dues(string str)
        {
            InitializeComponent();
            this.lblPerson.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dues_Load(object sender, EventArgs e)
        {
            string personID = this.lblPerson.Text;

            cmd = new SqlCommand("select dues.personID,dues.vaccineID,dues.sheduleDate,dues.givenDate,vaccine.vaccine from dues inner join vaccine on dues.vaccineID = vaccine.vaccineID where personID= '" + personID + "' ", con);
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            int a = 10;

            while (reader.Read())
            {
                
                Button btnName = new Button();
                //btnName.BackColor = Color.Black;
                //btnName.ForeColor = Color.White;
                string shedule = reader.GetValue(2).ToString();
                string given = reader.GetValue(3).ToString();
                btnName.Size = new Size(500, 50);
                btnName.Font = new Font("Consolas", 12);
                btnName.TextAlign = ContentAlignment.MiddleLeft;
                btnName.Name = reader.GetValue(0).ToString();
                btnName.Location = new Point(5, a + 30);
                btnName.Text = reader.GetValue(1).ToString() +" "+ reader.GetValue(4).ToString()+"          " + shedule.Substring(0, 10) + "        " + given.Substring(0, 10);
                btnName.Click += new EventHandler(this.button_click);
                panelDues.Controls.Add(btnName);
                a = a + 50;



            }

            reader.Close();

                        
            SqlCommand cmdVaccine = new SqlCommand("select vaccineID,vaccine from vaccine ", con);
            SqlDataReader readerVaccine = cmdVaccine.ExecuteReader();
            int b = 10;
            while (readerVaccine.Read())
            {


                Button btnName = new Button();
                //btnName.BackColor = Color.Black;
                //btnName.ForeColor = Color.White;

                btnName.Size = new Size(500, 50);

                btnName.Name = personID;
                btnName.Font = new Font("Consolas", 12);
                btnName.TextAlign = ContentAlignment.MiddleLeft;
                btnName.Location = new Point(5, b + 30);
                btnName.Text = readerVaccine.GetValue(0).ToString() + " " + readerVaccine.GetValue(1).ToString();
                btnName.Click += new EventHandler(this.button_click);
                panelDues.Controls.Add(btnName);
                b = b + 50;



            }
            readerVaccine.Close();

            SqlCommand cmdPerson = new SqlCommand("select name from person where personID='"+personID+"'", con);
            SqlDataReader readerPerson = cmdPerson.ExecuteReader();
            readerPerson.Read();
            string name = readerPerson.GetValue(0).ToString();
            this.name.Text = name;
            readerPerson.Close();
            con.Close();



            



        }

        void button_click(object sender, EventArgs e) 
        {
            Button btn= sender as Button;
            //panelDues.Controls.Clear();
            vaccineDetails vaccineDetails = new vaccineDetails(btn.Name,btn.Text);
            //vaccineDetails.TopLevel = false;
            //panelDues.Controls.Add(vaccineDetails);
            vaccineDetails.Show();

         }

        private void panelDues_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            editPerson edit = new editPerson(this.lblPerson.Text);
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmdDeleteDues = new SqlCommand("delete dues where personID='" + this.lblPerson.Text + "'", con);
            SqlCommand cmdDelete = new SqlCommand("delete person where personID='" + this.lblPerson.Text + "'", con);

            if (MessageBox.Show("Do you want to delete this person details ?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                SqlDataReader readerDelete2 = cmdDeleteDues.ExecuteReader();
                readerDelete2.Close();


                SqlDataReader readerDelete = cmdDelete.ExecuteReader();
                readerDelete.Close();
                MessageBox.Show("Person Deleted.");

            }
           


            con.Close();

            
        }
    }
}
