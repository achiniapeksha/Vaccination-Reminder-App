using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace vaccinationReminder
{
    public partial class Form1 : Form
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
       

        List<Panel> listPanel = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            home home = new home();
            home.TopLevel = false;
            panelMain.Controls.Add(home);
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panelMain.Controls.Clear();
            settings settings = new settings();
            settings.TopLevel = false;
            panelMain.Controls.Add(settings);
            settings.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            help help = new help();
            help.TopLevel = false;
            panelMain.Controls.Add(help);
            help.Show();
        }

      

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listPanel.Add(panelMain);
            panelMain.Controls.Clear();
            home home = new home();
            home.TopLevel = false;
            panelMain.Controls.Add(home);
            home.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            dues dues = new dues();
            dues.TopLevel = false;
            panelMain.Controls.Add(dues);
            dues.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            about about = new about();
            about.TopLevel = false;
            panelMain.Controls.Add(about);
            about.Show();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddChild_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnSettings_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnAddChild_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnAddChild_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
