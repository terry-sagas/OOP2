using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_W2C2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            if (!float.TryParse(txtNum1.Text, out num1) )
            {
                MessageBox.Show("Value of 'First Number' is not correct");
                txtNum1.BackColor = Color.Red;
                return;
            }
            float num2 = 0;
            if (!float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Value of 'Second Number' is not correct");
                txtNum2.BackColor = Color.Red;
                return;
            }
            float result = 0;

            //num1 = float.Parse(txtNum1.Text);
            //num2 = float.Parse(txtNum2.Text);

            if (rbtnAdd.Checked)
            {
                txtCalc.Text = "";
                result = num1 + num2;
                txtCalc.Text = result.ToString();

            }
            if (rbtnSub.Checked)
            {
                txtCalc.Text = "";
                result = num1 - num2;
                txtCalc.Text = result.ToString();

            }
            if (rbtnMul.Checked)
            {
                txtCalc.Text = "";
                result = num1 * num2;
                txtCalc.Text = result.ToString();

            }
            if (rbtnDivide.Checked)
            {
                txtCalc.Text = "";
                result = num1 / num2;
                txtCalc.Text = result.ToString();


            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCalc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
