using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppClassWork1
{
    public partial class Form1 : Form
    {
        int dayNumber = 1;
        float totalSales = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private bool IsValidInt(string num)
        {
            int temp = 0;
            if(int.TryParse(num, out temp))
            {
                return true;
            }
            return false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            int value = 0;
            if(IsValidInt(txtDaySale.Text))
            {
                value = int.Parse(txtDaySale.Text);

                totalSales += value;

                if (txtHistory.Text != "")
                    txtHistory.Text += "\r\n";

                txtHistory.Text +=  txtDaySale.Text;

                dayNumber++;
                txtDaySale.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }


            if (dayNumber > 7)
            {
                float avg = totalSales / 7;
                txtResult.Text = "Average: " + avg.ToString();
                txtDayNumber.Text = "";
            }
            else
                txtDayNumber.Text = dayNumber.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDayNumber.Text = dayNumber.ToString();
        }
    }
}
