using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form1 : Form
    {

        public static double prviBroj, drugiBroj, rezultat;
        public static string txt = "", num1 = "", num2 = "", msg = "";
        public static char idk = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        void print(string msg)
        {
            label1.Text = msg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt += "2";
            msg += "2";
            print(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt += "3";
            msg += "3";
            print(msg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt += "4";
            msg += "4";
            print(msg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt += "5";
            msg += "5";
            print(msg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt += "6";
            msg += "6";
            print(msg);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt += "7";
            msg += "7";
            print(msg);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt += "8";
            msg += "8";
            print(msg);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt += "9";
            msg += "9";
            print(msg);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(idk == ' ')
            {
                MessageBox.Show("Greska");
            }
            else
            {
                switch (idk)
                {
                    case '/':
                        num2 = txt;
                        drugiBroj = Convert.ToDouble(num2);
                        rezultat = Math.Round(prviBroj / drugiBroj);
                        break;
                    case '*':
                        num2 = txt;
                        drugiBroj = Convert.ToDouble(num2);
                        rezultat = prviBroj * drugiBroj;
                        break;
                    case '-':
                        num2 = txt;
                        drugiBroj = Convert.ToDouble(num2);
                        rezultat = prviBroj - drugiBroj;
                        break;
                    case '+':
                        num2 = txt;
                        drugiBroj = Convert.ToDouble(num2);
                        rezultat = prviBroj + drugiBroj;
                        break;
                }
                msg += "= " + rezultat;
                print(msg);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txt == "")
            {
                MessageBox.Show("Greska");

            }
            else
            {
                if (num1 == "")
                {
                    num1 = txt;
                    txt = "";
                    prviBroj = Convert.ToDouble(num1);
                    msg += "*";
                    print(msg);
                    idk = '*';
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txt == "")
            {
                MessageBox.Show("Greska");

            }
            else
            {
                if (num1 == "")
                {
                    num1 = txt;
                    txt = "";
                    prviBroj = Convert.ToDouble(num1);
                    msg += "-";
                    print(msg);
                    idk = '-';
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txt == "")
            {
                MessageBox.Show("Greska");

            }
            else
            {
                if (num1 == "")
                {
                    num1 = txt;
                    txt = "";
                    prviBroj = Convert.ToDouble(num1);
                    msg += "+";
                    print(msg);
                    idk = '+';
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt = "";
            msg = "";
            num1 = "";
            num2 = "";
            idk = ' ';
            print(msg);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt += "0";
            msg += "0";
            print(msg);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt += ".";
            msg += ".";
            print(msg);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(txt == "")
            {
                MessageBox.Show("Greska");
                
            }
            else
            {
                if (num1 == "")
                {
                    num1 = txt;
                    txt = "";
                    prviBroj = Convert.ToDouble(num1);
                    msg += "/";
                    print(msg);
                    idk = '/';
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt += "1";
            msg += "1";
            print(msg);
        }
    }
}
