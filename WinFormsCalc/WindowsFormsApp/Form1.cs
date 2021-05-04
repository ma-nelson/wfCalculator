using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private double value = 0;
        private string operation = "";
        bool opertionPressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((results.Text == "0") || (opertionPressed))
            {
                results.Clear();
            }
           

            opertionPressed = false;
            results.Text += button.Text;

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            results.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(results.Text);
            opertionPressed = true;
            operation_Symbol.Text = value + " " + operation;

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operation_Symbol.Text = "";

            switch (operation) 
            {
                case "+":
                    results.Text = (value + Double.Parse(results.Text)).ToString();
                    break;

                case "-":
                    results.Text = (value - Double.Parse(results.Text)).ToString();
                    break;

                case "*":
                    results.Text = (value * Double.Parse(results.Text)).ToString();
                    break;

                case "/":
                    results.Text = (value / Double.Parse(results.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            results.Text = "0";
            value = 0;
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (results.Text.Contains("-")) 
            {
                results.Text = results.Text.Remove(0, 1);
            }
            else
            {
                results.Text = "-" + results.Text;
            }

        }
    }
}
