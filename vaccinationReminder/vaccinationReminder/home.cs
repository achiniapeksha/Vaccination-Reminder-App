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
using System.Runtime.InteropServices;


namespace vaccinationReminder
{
    public partial class home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nRightEllipse

        );
       


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DA8CPQ1\SQLEXPRESS; Initial Catalog=vaccinationReminder; Integrated Security=True;");
        SqlCommand cmd;

        public home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addPerson newPerson = new addPerson();
            newPerson.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelHome.Controls.Clear();
            dues dues = new dues();
            dues.TopLevel = false;
            panelHome.Controls.Add(dues);
            dues.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addPerson newPerson = new addPerson();
            newPerson.Show();

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select personID,name,DOB from person ",con);
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            
            int a = 10;
            while (reader.Read())
            {
                //TextBox txtPID = new TextBox();
                //txtPID.Text = reader.GetValue(0).ToString();

                Button btnName = new Button();
                //btnName.BackColor = Color.Black;
                //btnName.ForeColor = Color.White;
                string DOB = reader.GetValue(2).ToString();
                btnName.Size = new Size(350,50);
                btnName.Name = reader.GetValue(0).ToString();
                btnName.Font = new Font("Consolas", 12);
                btnName.TextAlign = ContentAlignment.MiddleLeft;
                btnName.Location = new Point(20, a+30);
                btnName.Text = reader.GetValue(1).ToString()+"\n"+"Date of Birth : " + DOB.Substring(0,10);
                btnName.Click += new EventHandler(this.button_click);
                panelHome.Controls.Add(btnName);
                a = a + 50;
                string name = reader.GetValue(1).ToString();

            }
           
            con.Close();
        }

        void button_click(object sender, EventArgs e) 
        { 
            Button btn= sender as Button;
            panelHome.Controls.Clear();
            dues dues = new dues(btn.Name);
            dues.TopLevel = false;
            panelHome.Controls.Add(dues);
            dues.Show();

        }

    }

   
}
