using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torens_van_Hanoi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int a = 0;


        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NYI!!!");
        }


        private void amoutButton_Click(object sender, EventArgs e)
        {
            double number;
            ulong result = 0;
            number = double.Parse(grindPowerTextBox.Text);


            result = (ulong)Math.Pow(2, number) - 1;


            resultLabel.Text = result.ToString();
        }



        private void plusPowerGrindButton_Click(object sender, EventArgs e)
        {
            a++;
            grindPowerTextBox.Text = a.ToString();
        }

        private void minusPowerGrindButton_Click(object sender, EventArgs e)
        {
            a--;
            grindPowerTextBox.Text = a.ToString();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }



        //bas

        private void buttonRecursie_Click(object sender, EventArgs e)

        {
            ulong discs;
            bool gelukt = ulong.TryParse(grindPowerTextBox.Text, out discs);
            double seconden = double.Parse(grindPowerTextBox.Text);
            double input = double.Parse(grindPowerTextBox.Text);

            if (discs <= 64 && discs >= 1)

            {

                if (!gelukt)
                {

                }

                else
                {
                    ulong result = count(0, 1, discs);
                    resultLabel.Text = string.Format("Recursie: voor {0} schijven heb je {1} stappen nodig.", discs, result);
                    seconden = Math.Pow(2, input) - 1;
                    ulong seconds = result % 60;
                    ulong minutes = result / 60 % 60;
                    ulong hours = result / 60 / 60 % 24;
                    ulong days = result / 24 / 60 / 60 % 7;
                    ulong weeks = result / 7 / 24 / 60 / 60 % 4;
                    ulong months = result / 4 / 7 / 24 / 60 / 60 % 12;
                    ulong years = result / 12 / 4 / 7 / 24 / 60 / 60 % 10;
                    ulong decenia = result / 10 / 12 / 4 / 7 / 24 / 60 / 60 % 100;
                    ulong centuries = result / 100 / 10 / 12 / 4 / 7 / 24 / 60 / 60;
                    labelEeuwen.Text = centuries.ToString() + " eeuwen ";
                    labelDecenia.Text = decenia.ToString() + " decenia ";
                    labelJaren.Text = years.ToString() + " jaren ";
                    labelMaanden.Text = months.ToString() + " maanden ";
                    labelWeken.Text = weeks.ToString() + " weken ";
                    labelDagen.Text = days.ToString() + " dagen ";
                    labelUren.Text = hours.ToString() + " uren ";
                    labelMinuten.Text = minutes.ToString() + " minuten ";
                    labelSeconden.Text = seconds.ToString() + " seconden ";
                }
            }

            else
            {
                MessageBox.Show("Je hebt geen geldige input opgegeven");
            }
        }

        static ulong count(ulong zetten, ulong currentDisk, ulong schijven)
        {
            if (currentDisk > schijven)
            {
                return zetten;
            }
            else
            {
                zetten = zetten * 2 + 1;
                ulong resultaat = count(zetten, currentDisk + 1, schijven);

                return resultaat;

                //en nu de tijd


            }


        }

        private void forLoopButton_Click(object sender, EventArgs e)
        {
            try
            {
                ulong powerInt = ulong.Parse(grindPowerTextBox.Text);
                ulong numberInt = 2;
                ulong resultInt = 1;

                if (powerInt > 64)
                {
                    MessageBox.Show("het aantal schijven mag niet meer dan 64 zijn");
                }

                else
                {
                    try
                    {

                        for (ulong i = 0; i < powerInt; i++)
                        {
                            resultInt *= numberInt;
                        }

                        resultInt--;
                        resultLabel.Text = "Aantal te zetten stappen: " + resultInt.ToString();
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Vul een positief getal in!");
                    }
                }
            }

            catch
            {
                MessageBox.Show("Vul een getal in!");
            }
            
        }

        private void grindPowerTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
