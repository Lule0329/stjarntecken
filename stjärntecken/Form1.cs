using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stjärntecken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string månad = comboBox1.GetItemText(comboBox1.SelectedItem);
            int dag = int.Parse(textBox1.Text);

            if (månad == "Mars")
            {
                if (dag >= 1 && dag <= 19)
                {
                    MessageBox.Show("Fiskarna");
                }
                else if (dag >= 20 && dag <= 31)
                {
                    MessageBox.Show("Väduren");
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
            }
            else if (månad == "April")
            {
                if (dag >= 1 && dag <= 19)
                {
                    MessageBox.Show("Väduren");
                }
                else if (dag >= 20 && dag <= 30)
                {
                    MessageBox.Show("Oxen");
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
            }
            else if (månad == "Maj")
            {
                if (dag >= 1 && dag <= 20)
                {
                    MessageBox.Show("Oxen");
                }
                else if (dag >= 21 && dag <= 31)
                {
                    MessageBox.Show("Tvillingarna");
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
            }
            else if (månad == "Juni")
            {
                if (dag > 1 && dag <= 20)
                {
                    MessageBox.Show("Tvillingarna");
                }
                else if (dag >= 21 && dag <= 30)
                {
                    MessageBox.Show("Kräftan");
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
            }
            else if (månad == "Juli")
            {
                if (dag >= 1 && dag <= 21)
                {
                    MessageBox.Show("Kräftan");
                }
                else if (dag >= 22 && dag <= 31)
                {
                    MessageBox.Show("Lejonet");
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
            }
            else if (månad == "Augusti")
            {
                if (dag >= 1 && dag <= 22)
                {
                    MessageBox.Show("Lejonet");
                }
                else if (dag >= 23 && dag <= 30)
                {
                    MessageBox.Show("Jungfrun");
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
            }
        }
    }
}
