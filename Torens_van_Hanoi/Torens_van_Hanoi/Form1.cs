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

        ulong recuramount;
        ulong recurResultInt = 1;
        ulong recurNumberInt = 2;

        public void recMethod(int recursion)
        {
            if (recursion <= 0)
            {
                return;
            }

            recurResultInt *= recurNumberInt;
            recMethod(recursion - 1);
        }

        private int a = 0;
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void grindTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NYI!!!");
        }

        private void playsButton_Click(object sender, EventArgs e)
        {
            try
            {
                ulong powerInt = ulong.Parse(grindTextBox.Text);
                ulong numberInt = 2;
                ulong resultInt = 1;

                for (ulong i = 0; i < powerInt; i++)
                {
                    resultInt *= numberInt;
                }

                resultInt--;
                MessageBox.Show(resultInt.ToString());
                resultLabel.Text = resultInt.ToString();
            }
            catch
            {
                MessageBox.Show("Vul een positief getal in!");
            }

        }

        private void plusGrindButton_Click(object sender, EventArgs e)
        {
            a++;
            grindTextBox.Text = a.ToString();
        }

        private void minusGrindButton_Click(object sender, EventArgs e)
        {
            a--;
            grindTextBox.Text = a.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                ulong number;
                ulong result = 0;
                number = ulong.Parse(grindPowerTextBox.Text);


                result = (ulong)Math.Pow(2, number) - 1;

                MessageBox.Show(result.ToString());
                powerLabel.Text = result.ToString();
            }
            catch(OverflowException)
            {
                MessageBox.Show("Vul een positief getal in!");
            }
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

        private void grindRecursionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recursionButton_Click(object sender, EventArgs e)
        {
            ulong recuramount = ulong.Parse(grindRecursionTextBox.Text);

            ulong grinds = ulong.Parse(grindRecursionTextBox.Text);

            recMethod((int)grinds);

            recurResultInt--;

            recursionResultLabel.Text = recurResultInt.ToString();
        }
    }


}
