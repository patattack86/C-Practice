using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerfom = "";
        bool isOperationPerormed = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void btn_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerormed))
                textBox_Result.Text = String.Empty;

            isOperationPerormed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
            
        }

        private void opt_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerfom = button.Text;
                label_operation.Text = resultValue + " " + operationPerfom;
                isOperationPerormed = true;
            }
            else
            {
               operationPerfom = button.Text;
               resultValue = Double.Parse(textBox_Result.Text);
               label_operation.Text = resultValue + " " + operationPerfom;
               isOperationPerormed = true;
            }
        }



        private void buttonClearEntery_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerfom)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}

        #endregion
