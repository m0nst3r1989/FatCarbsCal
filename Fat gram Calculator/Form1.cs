using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat_gram_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double fatConvertor(double fatGrams)
        {
            return fatGrams * 9;
        }

        private double carbConvertor(double carbGrams)
        {
            return carbGrams * 4;
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            double calFat, fatGrams, calCarbs, carbsGrams;

            if (double.TryParse(fatGramsText.Text, out fatGrams))
            {
                calFat = fatGrams * 9;

                calFrmFat.Text = calFat.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter a valid number from fat Grams");
            }
            if (double.TryParse(carbsGramsText.Text, out carbsGrams))
            {
                calCarbs = carbsGrams * 4;

                calFrmCarbs.Text = calCarbs.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter number from Carbs Grams");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fatGramsText.Text = "";
            carbsGramsText.Text = "";
            calFrmCarbs.Text = "";
            calFrmFat.Text = "";
            fatGramsText.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
