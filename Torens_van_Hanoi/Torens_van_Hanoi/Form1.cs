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
            double number = Int32.Parse(grindTextBox.Text);
            {
                number = Math.Pow(2, number) -1;
            }

            resultLabel.Text = Int32.TryParse(number);
        }
    }


}
