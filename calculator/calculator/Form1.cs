using System;
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
                try
                {
                    double firstArgument = Convert.ToDouble(textBox1.Text);
                    double secondArgument = Convert.ToDouble(textBox2.Text);
                    ICalculator calculator = CalculatorFactory.CreateCalculator(((Button) sender).Name);
                    double result = calculator.Calculate(firstArgument, secondArgument);

                    textBox3.Text = result.ToString();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error" + exc.Message);
                }
            }

            private void buttonClickOneArg(object sender, EventArgs e)
            {
                try
                {
                    double firstArgument = Convert.ToDouble(textBox1.Text);

                    ICanculator2 calculator = Factory.CreateCalculator(((Button) sender).Name);
                    double result = calculator.Calculate(firstArgument);

                    textBox3.Text = result.ToString();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error" + exc.Message); 
                }
        }


       
    }
}
