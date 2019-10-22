using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double PRT;
            try
            {

                PRT = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                PRT = 0.00;
            }
            double P2RT;
            try
            {
                P2RT = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                P2RT = 0.00;
            }
            double RT;
            RT = PRT + P2RT;
            label1.Text = "RT= " + RT;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            double PRT2;
            try
            {
                PRT2 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                PRT2 = 0.00;
            }
            double P2RT2;
            try
            {
            P2RT2 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                P2RT2 = 0.00;
            }
            double P3RT2;
            P3RT2 = double.Parse(textBox5.Text);
            double RT2;
            RT2 = PRT2 + P2RT2 + P3RT2;
            label2.Text = "RT2= " + RT2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double PRT3;
            try
            { 
            PRT3 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                PRT3 = 0.00;
            }
            double P2RT3;
            try
            {
            P2RT3 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                P2RT3 = 0.00;
            }
            double RT3;
            RT3 = PRT3 * P2RT3;
            label3.Text = "RT3= " + RT3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double PRT4;
            try
            {
            PRT4 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                PRT4 = 0.00;
            }
            double P2RT4;
            try
            {
            P2RT4 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                P2RT4 = 0.00;
            }
            double P3RT4;
            try
            {
            P3RT4 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input");
                P3RT4 = 0.00;
            }
            double RT4;
            RT4 = PRT4 * P2RT4 * P3RT4;
            label4.Text = "RT4= " + RT4;
        }
    }
}
