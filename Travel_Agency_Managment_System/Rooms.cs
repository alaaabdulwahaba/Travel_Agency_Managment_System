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
    public partial class Rooms : UserControl
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(new String[]{"single", "Double", "suite"});
            comboBox2.SelectedIndex = 0;
            dataGridView1.Rows.Add("Double", "350$", "2 Adults & 1 Child");
            dataGridView1.ClearSelection();

            textBox3.Text = "price";
            textBox3.ForeColor = Color.Gray;

            textBox5.Text = "capacity";
            textBox5.ForeColor = Color.Gray;
        }

      

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Price")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

      

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Capacity")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

       

      

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "Capacity")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Gray;
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
    }
}
