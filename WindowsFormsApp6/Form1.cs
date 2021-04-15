using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float curent = CheckCurrency(comboBox1.Text);
            float needed = CheckCurrency(comboBox2.Text);
            double tryPars;
            if (CheckErrorecurrency(curent, needed) && Double.TryParse(textBox1.Text,out tryPars))
            {
                float coefficient = CalculateCoefficient(needed, curent);
                textBox2.Text = Convert.ToString(Math.Round((float)tryPars * coefficient, 2));
            }
            if(!Double.TryParse(textBox1.Text, out tryPars))
            {
                MessageBox.Show("Произошла ошибка ввода суми");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        class ratio
        {
            public float dolar = (float)1.2;
            public float grn = 30;
            public float eu = 1;
        }
        public float CheckCurrency(string currency)
        {
            ratio number = new ratio();
            if(currency == "$")
            {
                return number.dolar;
            }
            if (currency == "Грн.")
            {
                return number.grn;
            }
            if (currency == "Євро.")
            {
                return number.eu;
            }
            return (float)-1.0;
        }
        public float CalculateCoefficient(float division, float divider)
        {
            return (float)division / (float)divider;
        }
        public bool CheckErrorecurrency(float currency1, float currency2)
        {
            if(currency1 < 0 || currency2 < 0)
            {
                MessageBox.Show("Произошла ошибка ввода валют");
                return false;
            }
            return true;
        }

    }
}
