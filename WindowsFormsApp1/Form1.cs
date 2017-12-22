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
        public Form1()
        {
            InitializeComponent();
        }

        string skladnikPierwszy= null;
        decimal a, b,wynik;
        char rodzajDzialania='0';
       

        private void button0_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '0';
            textBox1.Text += '0';
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '9';
            textBox1.Text += '9';

        }

        private void button8_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '8';
            textBox1.Text += '8';

        }

        private void button7_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '7';
            textBox1.Text += '7';

        }

        private void button6_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '6';
            textBox1.Text += '6';

        }

        private void button5_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '5';
            textBox1.Text += '5';

        }

        private void button4_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '4';
            textBox1.Text += '4';

        }

        private void button3_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '3';
            textBox1.Text += '3';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '2';
            textBox1.Text += '2';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            skladnikPierwszy += '1';
            textBox1.Text += '1';
        }

        

        private void plus_Click(object sender, EventArgs e)
        {
            if (rodzajDzialania == '=')
                rodzajDzialania = '+';
            
            
            a = Convert.ToDecimal(skladnikPierwszy);
            wynik = WykonajDzialanie(wynik, a);
            rodzajDzialania = '+';
            skladnikPierwszy =null;
            textBox1.Text += '+';
            a = 0;

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (rodzajDzialania == '=')
                 rodzajDzialania = '-';

            a = Convert.ToDecimal(skladnikPierwszy);
            wynik = WykonajDzialanie(wynik,a);
            rodzajDzialania = '-';
            skladnikPierwszy = null;
            textBox1.Text += '-';
            a = 0;
        }

        private void times_Click(object sender, EventArgs e)
        {
            if (rodzajDzialania == '=')
            {
                rodzajDzialania = '*';
                skladnikPierwszy = "1";
            }

            a = Convert.ToDecimal(skladnikPierwszy);
            wynik = WykonajDzialanie(wynik, a);
            rodzajDzialania = '*';
            skladnikPierwszy = null;
            textBox1.Text += 'x';
            
        }

        private void equals_Click(object sender, EventArgs e)
        {
            textBox1.Text+="=";
            a = Convert.ToDecimal(skladnikPierwszy);
            
            wynik = WykonajDzialanie(wynik, a);
            skladnikPierwszy = "0";
            //a = 0;
            rodzajDzialania = '=';
            textBox1.Text += wynik.ToString();
                   
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            skladnikPierwszy = null;
            a = 0;
            wynik = 0;
            rodzajDzialania = '0';
        }

        private decimal WykonajDzialanie(decimal a,decimal b)
        {
            
            switch (rodzajDzialania)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '0':
                    return b;
                case '=':
                    return a;
            }
            return 0;
        }

    }
}
