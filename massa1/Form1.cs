using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace massa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double funt = 0.453592;
        double gr = 0.001;
        double tonn = 1000;
        double x;
        double z;

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
if (this.radioButton1.Checked)
            {
                x = Convert.ToDouble(textBox3.Text);
                z =  gr * x;
                textBox1.Text = z.ToString();
            }


            else if (this.radioButton2.Checked)
            {
                x = Convert.ToDouble(textBox3.Text);
                z = funt * x;
                textBox1.Text = z.ToString();

            }

            else if (this.radioButton3.Checked)
            {
                x = Convert.ToDouble(textBox3.Text);
                z = tonn * x;
                textBox1.Text = z.ToString();

            }
        }
    }
}
