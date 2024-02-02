using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1W4C1_Example
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        int dayNumber = 1;
        float totalSales = 0;
        
        private void btnEnter_Click(object sender, EventArgs e)
        {


            int value = 0;
            if (int.TryParse(txtInput.Text, out value)){
                totalSales += value;
                if(txtHistory.Text != "")
                {
                    txtHistory.Text += "\r\n";
                }
                txtHistory.Text += txtInput.Text;

                dayNumber++;
                txtInput.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

            
            if (dayNumber > 7)
            {
                float avg = totalSales / 7;
                txtOutput.Text = avg.ToString();
                txtDayNumber.Text = "";
            }
            else
            {
                txtDayNumber.Text = dayNumber.ToString();
            }

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDayNumber.Text = dayNumber.ToString();
        }
    }
}
