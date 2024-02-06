using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int size = 0;
        float[] salesArray;
        int dayNumber = 1;
        float totalSales = 0;
        float averageSales = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private bool IsValidInt(string num)
        {
            int temp = 0;
            if (int.TryParse(num, out temp))
            {
                return true;
            }
            return false;
        }
        private bool IsValidFloat(string num)
        {
            float temp = 0;
            if (float.TryParse(num, out temp))
            {
                return true;
            }
            return false;
        }
        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else
                {
                    ClearAllTextBoxes(ctrl);
                }
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            float salesInput = 0;

            
            if (IsValidInt(txtDayInput.Text) && IsValidFloat(txtSalesInput.Text) && int.Parse(txtDayInput.Text) > 0)
            {
                
                
                if (salesArray == null)
                {
                    size = int.Parse(txtDayInput.Text);
                    salesArray = new float[size];
                }

                
                if (txtSales.Text != "")
                {
                    txtSales.Text += "\r\n";
                }
                txtSales.Text += txtSalesInput.Text;

                
                salesInput = float.Parse(txtSalesInput.Text);
                salesArray[dayNumber - 1] = salesInput;
                dayNumber++;
                txtDayInput.Enabled = false;
                txtSalesInput.Text = "";
                
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

            if (dayNumber == (size+1))
            {
                btnEnter.Enabled = false;
                btnSum.Enabled = true;
                btnAverage.Enabled = true;
                totalSales = salesArray.Sum();
                averageSales = totalSales / (size);


            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Sum: " + totalSales.ToString();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Average: " + averageSales.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            size = 0;
            float[] salesArray = null;
            dayNumber = 1;
            totalSales = 0;
            averageSales = 0;
            btnEnter.Enabled = true;
            btnSum.Enabled = false;
            btnAverage.Enabled = false;
            txtDayInput.Enabled = true;
            ClearAllTextBoxes(this);
        }

        private void txtDayInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
