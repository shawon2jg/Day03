using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Total=0, TimeInYear, PrincipalAmount;
            string BankName = comboBox1.Text;
            TimeInYear = Convert.ToInt32(textBox1.Text);
            PrincipalAmount = Convert.ToInt32(textBox2.Text);
            if (BankName == "BRAC")
            {
                Total = (6*PrincipalAmount*TimeInYear)/100;
            }
            else if (BankName == "DBBL")
            {
                Total = (7 * PrincipalAmount * TimeInYear) / 100;
            }
            else if (BankName == "HSBC")
            {
                Total = (8 * PrincipalAmount * TimeInYear) / 100;
            }
            
            label5.Text = Convert.ToString(Total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
