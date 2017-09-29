using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07TwoNumberSum
{
    public partial class TwoNumbersSum : Form
    {
        public TwoNumbersSum()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = double.Parse(this.box1.Text);
                double secondNum = double.Parse(this.box2.Text);
                double sum = firstNum + secondNum;
                resultBox.Text = sum.ToString();
            }
            catch (Exception)
            {
                resultBox.Text = "error";
            }

        }
    }
}
