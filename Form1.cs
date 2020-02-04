using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomaciZadatak6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_maxWeight.Text == "" || textBox_speed.Text == "" || textBox_weight.Text == "")
            {
                MessageBox.Show("Molim Vas, popunite prazna polja", "Greška!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Int32.Parse(textBox_id.Text);
                int weight = Int32.Parse(textBox_weight.Text);
                int speed = Int32.Parse(textBox_speed.Text);
                int maxW = Int32.Parse(textBox_maxWeight.Text);

                listBox1.Items.Add(new Kamion(id, weight, speed, maxW));
            }
            
        }

        private void add_plane_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_speed.Text == "" || textBox_weight.Text == "" || textBox_maxHeight.Text == "" || textBox_wings.Text == "")
            {
                MessageBox.Show("Molim Vas, popunite prazna polja", "Greška!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Int32.Parse(textBox_id.Text);
                int weight = Int32.Parse(textBox_weight.Text);
                int speed = Int32.Parse(textBox_speed.Text);
                int raspon = Int32.Parse(textBox_wings.Text);
                int maxH = Int32.Parse(textBox_maxHeight.Text);

                listBox1.Items.Add(new Avion(id, weight, speed, raspon, maxH));
            }
        }

        private void add_car_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_passingers.Text == "" || textBox_speed.Text == "" || textBox_weight.Text == "")
            {
                MessageBox.Show("Molim Vas, popunite prazna polja", "Greška!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Int32.Parse(textBox_id.Text);
                int weight = Int32.Parse(textBox_weight.Text);
                int speed = Int32.Parse(textBox_speed.Text);
                int people = Int32.Parse(textBox_passingers.Text);

                listBox1.Items.Add(new Automobil(id, weight, speed, people));
            }
        }
    }
}
