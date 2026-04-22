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
    public partial class Apparetments : UserControl
    {
        public Apparetments()
        {
            InitializeComponent();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Appartment Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "Appartment Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            if (textBox3.Text == "Price")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

            if (textBox3.Text == "Price")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {

            if (textBox6.Text == "Price")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {

            if (textBox6.Text == "Price")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(textBox4.Text == "Description")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "Description")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Gray;
            }

        }

        private void Apparetments_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Appartment Name";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Price";
            textBox3.ForeColor = Color.Gray;
            textBox6.Text = "Location";
            textBox6.ForeColor = Color.Gray;
            textBox4.Text = "Description";
            textBox4.ForeColor = Color.Gray;
            dataGridView1.Rows.Add("Grand Plaza", "400$", "Morrocow", "A spacious apartment consisting of 3 bedrooms, a living room, 2 bathrooms, and a fully equipped kitchen. Ideal for families.");
            dataGridView1.ClearSelection();
            textBox1.Text = "🔎 Search Hotel";
            textBox1.ForeColor = Color.Gray;
        }
    }
}
