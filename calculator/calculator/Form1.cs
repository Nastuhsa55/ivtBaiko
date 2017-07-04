using System;
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
            double first_argument = Convert.ToDouble(textBox1.Text);
            double second_argument = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "button1":
                    result = first_argument + second_argument;
                    break;
                case "button2":
                    result = first_argument - second_argument;
                    break;
                case "button3":
                    result = first_argument * second_argument;
                    break;
                case "button4":
                    result = first_argument / second_argument;
                    break;
                default:
                    throw new Exception ();

            }
            textBox3.Text = result.ToString();
            
        }
    }
}
