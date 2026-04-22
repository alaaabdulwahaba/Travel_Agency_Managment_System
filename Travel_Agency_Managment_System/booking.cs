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
    public partial class booking : UserControl
    {
        public booking()
        {
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
              
        {
            cmbFilterStatus.Items.AddRange(new String[] { "Trip", "Hotel", "Apartment" });
            dataGridView1.Rows.Add("Aya nasser", "UI6406", "16/6/2026", "5","Trip","Cash,Paid", "2500$");
            dataGridView1.ClearSelection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button5_Click(object sender, EventArgs e)
        {

            AddBooking frm = new AddBooking();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
