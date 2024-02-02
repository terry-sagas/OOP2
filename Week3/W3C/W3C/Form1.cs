using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float result = 0;
            if (!float.TryParse(txtFnum.Text, out num1))
            {
                MessageBox.Show("Value of 'First Number' is not correct");
                txtFnum.BackColor = Color.Red;
                return;
            }
            if (!float.TryParse(txtSnum.Text, out num2))
            {
                MessageBox.Show("Value of 'Second Number' is not correct");
                txtSnum.BackColor = Color.Red;
                return;
            }
            txtFnum.BackColor = Color.White;
            txtSnum.BackColor = Color.White;

            output.Text = "";
            result = num1 + num2;
            output.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float result = 0;
            if (!float.TryParse(txtFnum.Text, out num1))
            {
                MessageBox.Show("Value of 'First Number' is not correct");
                txtFnum.BackColor = Color.Red;
                return;
            }
            if (!float.TryParse(txtSnum.Text, out num2))
            {
                MessageBox.Show("Value of 'Second Number' is not correct");
                txtSnum.BackColor = Color.Red;
                return;
            }
            txtFnum.BackColor = Color.White;
            txtSnum.BackColor = Color.White;

            output.Text = "";
            result = num1 * num2;
            output.Text = result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFnum.Text = "";
            txtFnum.Text = "";
            output.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
