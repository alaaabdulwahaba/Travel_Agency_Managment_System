using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency_Managment_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

     
       

           




        public void LoadUserControl(UserControl uc)
        {
            contentPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(uc);
        }
        private void AdminDashboardcs_Load(object sender, EventArgs e)
        {

            AdminDash home = new AdminDash();
            home.Dock = DockStyle.Fill;

            // عرض HomeControl داخل Panel
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(home);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Clients());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AdminDash());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Apparetments());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new booking());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadUserControl(new trip());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new hotels());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new Usermanegment());
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Rooms());
        }
    }
}
