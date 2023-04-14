using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Wizard_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double num, R = 0;
        int ok, k = 0,change=0;
        string input = string.Empty;
        string input2=string.Empty;
        char operation = 'a';
        private int prim(double n)
        {
            if (n <= 1)
                return 0;
            int c = (int)n;
            if (c != n)
                return 0;
            for(int i=2;i*i<=n;i++)
            {
                if (n % i == 0)
                    return 0;
            }
            return 1;
        }
        public int putere(double n)
        {
            int c = (int)n;
            if(c!=n)
            {
                return 0;
            }
            if (n % 5 != 0)
                return 0;
            else
                return 1 + putere(n / 5);
        }

        public int rezolvare(double n)
        {
            int c = (int)n;
            if (c != n)
            {
                return 0;
            }
            if (n <= 0)
                return 0;
            if (n % 5 == 0)
            {
                return putere(n) + rezolvare(n - 5);
            }
            else
                return rezolvare(n - 1);
        } 
        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
            num = Convert.ToDouble(input);
        }

        private void digit_Click(object sender, EventArgs e)
        {
            if(ok==0)
            {
                input += ".";
                ok++;
            }
            else
            {
                //do nothin
            }
        }

        private void switcheroo_Click(object sender, EventArgs e)
        {
            if(change%2==0)
            {
                input2+="-";
                input2+=input;
                num=Convert.ToDouble(input2);
                textBox1.Text=input2;
                input=input2;
                change++;
                input2=string.Empty;
            }
            else
            {
                input2=input.Substring(1);
                textBox1.Text=input2;
                change++;
                input=input2;
                num=Convert.ToDouble(input);
                input2 = string.Empty;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(operation=='a'&&k==0)
            {
                operation = '+';
                k++;
            }
            Motherboard();
            operation='+';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if(operation=='a'&&k==0)
            {
                operation = '-';
                k++;
            }
            Motherboard();
            operation = '-';
        }

        private void times_Click(object sender, EventArgs e)
        {
            if (operation == 'a' && num == 0)
            {
                num = 1;
            }
            if (operation == 'a' && k == 0)
            {
                operation = '*';
                k++;
            }
           
            Motherboard();
            operation = '*';
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (operation == 'a' && num == 0)
            {
                num = 1;
            }
            if (operation == 'a' && k == 0)
            {
                operation = '/';
                k++;
            }
           
            Motherboard();
            operation = '/';
        }
        public void Motherboard()
        {
            if (operation == '+')
            {
                if (input == string.Empty)
                {
                    input += "0";
                }

                R += num;
                num = 0;
                textBox1.Text = R.ToString();
                input = string.Empty;
                change = 0;

            }
            else
                if (operation == '-')
                {
                    if (input == string.Empty)
                    {
                        input += "0";
                    }

                    R -= num;
                    num = 0;
                    textBox1.Text = R.ToString();
                    input = string.Empty;
                    change = 0;
                }
                else
                    if (operation == '*')
                    {
                        if (input == string.Empty)
                        {
                            input += "1";
                        }
                        if (R == 0)
                        {
                            R = 1;
                        }
                        R *= num;
                        num = 1;
                        textBox1.Text = R.ToString();
                        input = string.Empty;
                        change = 0;
                    }
                    else
                        if (operation == '/')
                        {
                            if (input == string.Empty)
                            {
                                input += "1";
                            }
                            if (R == 0)
                            {
                                R = Convert.ToDouble(input);
                            }
                            if (num == 0)
                            {
                                textBox1.Text = "can't do that";
                            }
                            else
                            {
                                R /= num;
                                textBox1.Text = R.ToString();
                            }
                            num = 1;
                            input = string.Empty;
                            change = 0;
                        }
                        else
                            if (operation == 'a'&&k==0)
                            {
                                R = num;
                            }

        }

        private void equal_Click(object sender, EventArgs e)
        {
            Motherboard();
            if (prim(R)==1)
            {
                this.textBox2.BackColor = Color.Green;
                this.textBox2.Text = "DA!";
            }
            else
            {
                this.textBox2.Text = "NU!";
                this.textBox2.BackColor = Color.Red;
            }
            int c = (int)R;
            if (c == 0)
                this.textBox3.Text = "0";
            else
            {
                if(c!=R)
                {
                    this.textBox3.Text = "numarul are zecimale";
                }
                else
                {
                    int m;
                    m = c % 9;
                    if (m == 0)
                        this.textBox3.Text = "9";
                    else
                        this.textBox3.Text = Convert.ToString(m);
                }
                int p = rezolvare(R);
                this.textBox4.Text = Convert.ToString(p);
            }
            this.textBox5.Text = Convert.ToString(R);
            operation = 'a';
            num = 0;
            k=0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            R = 0;
            num = 0;
            operation = 'a';
            k = 0;
        }

        private void ClearEverything_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox2.BackColor = Color.Cyan;
            this.textBox4.Text = "";
            this.textBox3.Text = "";
            this.textBox5.Text = "";
            this.input = string.Empty;
            R = 0;
            num = 0;
            operation = 'a';
            k = 0;
        }

        private void question1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un numar prim este un numar care are ca si divizori pe 1 si pe el insusi","Explicatie");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var quiz = new Form2();
            quiz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cifra de control a lui n reprezinta calcularea sumei cifrelor numarului n, apoi calcularea sumei cifrelor a primei sume, repetandu-se operatiunea pana cand suma obtinuta este mai mica ca 10. De exemplu: n=47, suma cifrelor = 11, 11>10 deci se repeta operatia, suma cifrelor sumei obtinute =2, 2<10 deci cifra de control al numarului n este 2", "Explicatie");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("n!=1*2*3*...*n;Acest algoritm calculeaza in cati de 0 se va termina n!       !!ATENTIE!! Daca n are zecimale se va afisa 0", "Explicatie");
        }


    }
}
