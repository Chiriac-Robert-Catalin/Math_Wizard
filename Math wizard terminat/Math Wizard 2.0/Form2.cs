using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Math_Wizard_2._0
{
    public partial class Form2 : Form
    {
        
        Random Randomizer = new Random();
        int AddL, AddR,DifL,DifR,ML,MR,CutL,CutR,TL;
        public Form2()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }
        public void StartTheQuizEasy()
        {
            AddL = Randomizer.Next(51);
            AddR = Randomizer.Next(51);
            SumL.Text = AddL.ToString();
            SumR.Text = AddR.ToString();
            DifL = Randomizer.Next(1, 101);
            DifR = Randomizer.Next(1, DifL);
            MinL.Text = DifL.ToString();
            MinR.Text = DifR.ToString();
            Min.Value = 0;
            Sum.Value = 0;
            Pro.Value = 0;
            Div.Value = 0;
            ML = Randomizer.Next(2, 11);
            MR = Randomizer.Next(2, 11);
            ProL.Text = ML.ToString();
            ProR.Text = MR.ToString();
            CutR = Randomizer.Next(2, 11);
            CutL = CutR * Randomizer.Next(2, 11);
            DivL.Text = CutL.ToString();
            DivR.Text = CutR.ToString();
            TL = 30;
            TimeLeft.Text = "30 seconds";
            timer1.Start();
            button2.Enabled = false;
            button3.Enabled = false;
            BackColor = Color.Green;
        }
        public void StartTheQuizMedium()
        {
            AddL = Randomizer.Next(51);
            AddR = Randomizer.Next(51);
            SumL.Text = AddL.ToString();
            SumR.Text = AddR.ToString();
            DifL = Randomizer.Next(1, 101);
            DifR = Randomizer.Next(1, DifL);
            MinL.Text = DifL.ToString();
            MinR.Text = DifR.ToString();
            Min.Value = 0;
            Sum.Value = 0;
            Pro.Value = 0;
            Div.Value = 0;
            ML = Randomizer.Next(2, 11);
            MR = Randomizer.Next(2, 11);
            ProL.Text = ML.ToString();
            ProR.Text = MR.ToString();
            CutR = Randomizer.Next(2, 11);
            CutL = CutR * Randomizer.Next(2, 11);
            DivL.Text = CutL.ToString();
            DivR.Text = CutR.ToString();
            TL = 20;
            TimeLeft.Text = "20 seconds";
            timer2.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            BackColor = Color.Yellow;
        }
        public void StartTheQuizHard()
        {
            AddL = Randomizer.Next(51);
            AddR = Randomizer.Next(51);
            SumL.Text = AddL.ToString();
            SumR.Text = AddR.ToString();
            DifL = Randomizer.Next(1, 101);
            DifR = Randomizer.Next(1, DifL);
            MinL.Text = DifL.ToString();
            MinR.Text = DifR.ToString();
            Min.Value = 0;
            Sum.Value = 0;
            Pro.Value = 0;
            Div.Value = 0;
            ML = Randomizer.Next(2, 11);
            MR = Randomizer.Next(2, 11);
            ProL.Text = ML.ToString();
            ProR.Text = MR.ToString();
            CutR = Randomizer.Next(2, 11);
            CutL = CutR * Randomizer.Next(2, 11);
            DivL.Text = CutL.ToString();
            DivR.Text = CutR.ToString();
            TL = 10;
            TimeLeft.Text = "10 seconds";
            timer3.Start();
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            BackColor = Color.Red;
        }
        private bool CTA()
        {
            if ((AddR + AddL == Sum.Value) && (DifL-DifR==Min.Value)&&(ML*MR==Pro.Value)&&(CutL/CutR==Div.Value))
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuizEasy();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            TimeLeft.BackColor = Color.White;
            TimeLeft.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CTA())
            {
                timer1.Stop();
                MessageBox.Show("Ai castigat prajitura cu menta!", "Felicitari");
                button1.Enabled = true;
                button2.Enabled = true;
                
                Reward1.Text = "Ai castigat prajitura cu menta!";
            }
            if(TL>0)
            {
                if (TL <= 10)
                {
                    TimeLeft.BackColor = Color.DarkRed;
                    TimeLeft.ForeColor = Color.White;
                }
                TL = TL - 1;
                
                TimeLeft.Text = TL + " secunde";
            }
            else
            {
                timer1.Stop();
                TimeLeft.Text = "S-a terminat! -_-";
                MessageBox.Show("Nu ai terminat la timp!", "Pe bune?");
                Sum.Value = AddL + AddR;
                Min.Value = DifL - DifR;
                Pro.Value = ML * MR;
                Div.Value = CutL / CutR;
                button1.Enabled = true;
                
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown raspuns = sender as NumericUpDown;
            if(raspuns!=null)
            {
                int lengthOfAnswer = raspuns.Value.ToString().Length;
                raspuns.Select(0, lengthOfAnswer);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartTheQuizMedium();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            TimeLeft.BackColor = Color.White;
            TimeLeft.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartTheQuizHard();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            TimeLeft.BackColor = Color.White;
            TimeLeft.ForeColor = Color.Black;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CTA())
            {
                timer2.Stop();
                MessageBox.Show("Ai castigat prajitura cu zmeura!", "Felicitari");
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                
                Reward2.Text = "Ai castigat prajitura cu zmeura!";
            }
            if (TL > 0)
            {
                if (TL <= 10)
                {
                    TimeLeft.BackColor = Color.DarkRed;
                    TimeLeft.ForeColor = Color.White;
                }
                TL = TL - 1;
                
                TimeLeft.Text = TL + " secunde";
            }
            else
            {
                timer2.Stop();
                TimeLeft.Text = "S-a terminat! -_-";
                MessageBox.Show("Nu ai terminat la timp! Ai incercat modul Usor?", "Ghinion");
                Sum.Value = AddL + AddR;
                Min.Value = DifL - DifR;
                Pro.Value = ML * MR;
                Div.Value = CutL / CutR;
                button1.Enabled = true;
                button2.Enabled = true;
                
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (CTA())
            {
                timer3.Stop();
                MessageBox.Show("Ai castigat prajitura cu ciocolata!", "Felicitari");
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                Reward3.Text = "Ai castigat prajitura cu ciocolata!";
                Reward4.Text = "Felicitari! Ai castigat toate prajiturile!";
                Reward4ish.Text = "Astfel vei primi premiul cel mare,";
                Reward4ish2.Text="PRAJITURA  AURIE!";
            }
            if (TL > 0)
            {
                if (TL <= 10)
                {
                    TimeLeft.BackColor = Color.DarkRed;
                    TimeLeft.ForeColor = Color.White;
                }
                TL = TL - 1;
                
                TimeLeft.Text = TL + " secunde";
            }
            else
            {
                timer3.Stop();
                TimeLeft.Text = "S-a terminat! -_-";
                MessageBox.Show("Nu ai terminat la timp! Ai incercat modul Mediu?", "Aproape...");
                Sum.Value = AddL + AddR;
                Min.Value = DifL - DifR;
                Pro.Value = ML * MR;
                Div.Value = CutL / CutR;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
}
