using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Travel_Agency_Managment_System
{
    public partial class trip : UserControl
    {
        public trip()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trip_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Trip ID";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text =" Distination";
            textBox3.ForeColor = Color.Gray;
           
            textBox5.Text = "Available Seats";
            textBox5.ForeColor = Color.Gray;

            dataGridView1.Rows.Add("510D", "Istanbul", "16/6/2026", "10:00 AM", "15");
            dataGridView1.ClearSelection();
            textBox1.Text = "🔎 Search trips";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Trip ID")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "Trip ID";
                textBox2.ForeColor = Color.Gray;
            }
        }
     
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Available Seats")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "Available Seats")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Distination")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "Distination")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Gray;
            }

        }
    }
}
