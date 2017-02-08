using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();

            outputLabel.Text = "" + Form1.guesses.Count();

            for (int i = 0; i < Form1.guesses.Count(); i++)
            {
                label5.Text += "\n" + " " + Form1.guesses[i];
            }
            Form1.guesses.Sort();
            for (int i = 0; i < Form1.guesses.Count(); i++)
            {
                label6.Text += "\n" + " " + Form1.guesses[i];
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
