using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RksmTwo.CalculatorService;

namespace RksmTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CalculatorSoapClient client = new CalculatorSoapClient();
        private void ResultBtn_Click(object sender, EventArgs e)
        {
            int numberOne = Convert.ToInt32(numberOneTextBox.Text);
            int numberTwo = Convert.ToInt32(numberTwoTextBox.Text);

            switch(operatorComboBox.Text)
            {
                case "+":
                    {
                        MessageBox.Show(client.Add(numberOne, numberTwo).ToString());
                        break;
                    }
                case "-":
                    {
                        MessageBox.Show(client.Subtract(numberOne, numberTwo).ToString());
                        break;
                    }
                case "*":
                    {
                        MessageBox.Show(client.Multiply(numberOne, numberTwo).ToString());
                        break;
                    }
                case "/":
                    {
                        MessageBox.Show(client.Divide(numberOne, numberTwo).ToString());
                        break;
                    }
                default:
                    {
                        MessageBox.Show("не выбран оператор");
                        break;
                    }
            }

        }
    }
}
