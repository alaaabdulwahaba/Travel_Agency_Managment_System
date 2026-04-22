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
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
        }

       

        private void Clients_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Client Name";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Passport Number";
            textBox3.ForeColor = Color.Gray;
            textBox6.Text = "Phone";
            textBox6.ForeColor = Color.Gray;
            textBox5.Text = "Email";
            textBox5.ForeColor = Color.Gray;

            dataGridView1.Rows.Add("yaken", "yakenahmed@gmail.com", "0911111111","LO909887");
            dataGridView1.ClearSelection();
            textBox1.Text = "🔎 Search clients";
            textBox1.ForeColor = Color.Gray;
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Client Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "Client Name";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "Passport Number")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "Passport Number")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Phone")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_Leave(object sender, EventArgs e)
        { 
            if (textBox6.Text == "Phone")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Email")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "Phone")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
