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
    public partial class Usermanegment : UserControl
    {
        public Usermanegment()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usermanegment_Load(object sender, EventArgs e)
        {

            textBox2.Text = "User Name";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Role";
            textBox3.ForeColor = Color.Gray;
            textBox6.Text = "Phone Number";
            textBox6.ForeColor = Color.Gray;
            textBox1.Text = "🔎 Search user";
            textBox1.ForeColor = Color.Gray;

            dataGridView1.Rows.Add("Alaa", "Admin", "0912222222");
            dataGridView1.ClearSelection();

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "User Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "User Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "Role")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Role")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "Phone Number")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Phone Number")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
    }
}
