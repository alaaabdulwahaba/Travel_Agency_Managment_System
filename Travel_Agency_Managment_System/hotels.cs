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
    public partial class hotels : UserControl
    {
        public hotels()
        {
            InitializeComponent();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Hotel Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "Hotel Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void hotels_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Hotel Name";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Price";
            textBox3.ForeColor = Color.Gray;
            textBox6.Text = "Location";
            textBox6.ForeColor = Color.Gray;
            dataGridView1.Rows.Add("Movambic", "350$", "Mecca");
            dataGridView1.ClearSelection();
            textBox1.Text = "🔎 Search Hotel";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

            if (textBox3.Text == "Price")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "Price")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Gray;
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
                textBox6.ForeColor = Color.Gray;
            }
        }
    }
}
