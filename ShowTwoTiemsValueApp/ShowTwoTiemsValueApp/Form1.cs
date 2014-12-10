using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTwoTiemsValueApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateNumberInTwoTimes_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(aNumberTextBox.Text);
            double showResult = GetDouble(aNumber);
            showResultTextBox.Text = showResult.ToString();
        }

        private double GetDouble(double aNumber)
        {
            double result = 2*aNumber;
            return result;
        }
    }
}
