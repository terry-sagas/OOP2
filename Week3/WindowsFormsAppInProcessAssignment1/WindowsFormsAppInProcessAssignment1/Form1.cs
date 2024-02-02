using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Terry Sagas
// 1/25/2024
// Assignment 1


namespace WindowsFormsAppInProcessAssignment1
{
    public partial class Form1 : Form
    {
        int counter = 0;
        float[] values = new float[7];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (counter == 7)
            {
                txtInput.ReadOnly = true;
            }
            else
            {
                txtInput.ReadOnly = false;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            float input = 0;
            float average = 0;
            

            if (float.TryParse(txtInput.Text, out input))
            {

                rtxtCases.Text = rtxtCases.Text + ("\n\r" + input.ToString());
                values[counter] = input;
                counter++;
                lblDay.Text = ("Day " + (counter));

                
            }

            else
            {

                MessageBox.Show("The value is not correct");


            }
            if (counter == 7)
            {
                btnEnter.Enabled = false;
                float sum = values.Sum();
                average = sum / 7;
                txtAverage.Text = ("The Average per day:" + average.ToString());
            }



        }


        private void rtxtCases_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            lblDay.Text = ("Day " + (counter + 1));
            btnEnter.Enabled = true;
            rtxtCases.Text = String.Empty;
            float[] values = new float[7];
            txtAverage.Text = String.Empty;
            txtInput.Text = String.Empty;
            



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
