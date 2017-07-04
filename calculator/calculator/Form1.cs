﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void buttonClick(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            ICalculator calculator = CalculatorFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument, secondArgument);

            textBox3.Text = result.ToString();
            
        }
        private void buttonClickOneArg(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
           
            ICanculator2 calculator = Factory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument);

            textBox3.Text = result.ToString();

        }
    }
}
