using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MyForm : Form
    {
        private string buffer;
        private delegate double Operation(double a, double b);
        private Operation operation;
        bool operationIsSet;
        bool newSession;

        public MyForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (newSession)
            { 
                result.Text = "0";
                newSession = false;
            }
            if ((result.Text == "0") && (button.Text != ","))
            {
                result.Text = button.Text;
            }
            else
            {
                if ((button.Text != ",") || (button.Text == "," && !result.Text.Contains(",")))
                    result.Text += button.Text;
            }
            result.Refresh();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            buffer = "0";
            result.Text = "0";
            operationIsSet = false;
            newSession = true;
            result.Refresh();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (operationIsSet)
            {
                buffer = operation(double.Parse(buffer), double.Parse(result.Text)).ToString();
            }
            else
            {
                buffer = result.Text;
                operationIsSet = true;
            }
            newSession = false;
            result.Text = "0";
            operation = Operations.Add;
            result.Refresh();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (operationIsSet)
            {
                buffer = operation(double.Parse(buffer), double.Parse(result.Text)).ToString();
            }
            else
            {
                buffer = result.Text;
                operationIsSet = true;
            }
            newSession = false;
            result.Text = "0";
            operation = Operations.Minus;
            result.Refresh();
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            if (operationIsSet)
            {
                buffer = operation(double.Parse(buffer), double.Parse(result.Text)).ToString();
            }
            else
            {
                buffer = result.Text;
                operationIsSet = true;
            }
            newSession = false;
            result.Text = "0";
            operation = Operations.Multiply;
            result.Refresh();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (operationIsSet)
            {
                buffer = operation(double.Parse(buffer), double.Parse(result.Text)).ToString();
            }
            else
            {
                buffer = result.Text;
                operationIsSet = true;
            }
            newSession = false;
            result.Text = "0";
            operation = Operations.Divide;
            result.Refresh();
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (operationIsSet)
            {
                buffer = operation(double.Parse(buffer), double.Parse(result.Text)).ToString();
            }
            result.Text = buffer;
            operationIsSet = false;
            newSession = true;
            result.Refresh();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            int width = (control.Width - 40) / 4;
            int heigth = (control.Height - 115) / 5;

            equalBtn.Width = control.Width - 25;
            equalBtn.Height = heigth;
            equalBtn.Location = new Point(5, 50 + (heigth + 5) * 4);

            result.Width = control.Width - 10;
            result.Location = new Point(5, 5);

            btnCE.Width = width; btnCE.Height = heigth;
            btnCE.Location = new Point(5, 50 + (heigth + 5) * 3);

            btn0.Width = width; btn0.Height = heigth;
            btn0.Location = new Point(5 + 5 + width, 50 + (heigth + 5) * 3);

            dotBtn.Width = width; dotBtn.Height = heigth;
            dotBtn.Location = new Point(5 + (5 + width) * 2, 50 + (heigth + 5) * 3);

            divideBtn.Width = width; divideBtn.Height = heigth;
            divideBtn.Location = new Point(5 + (5 + width) * 3, 50 + (heigth + 5) * 3);

            btn1.Width = width; btn1.Height = heigth;
            btn1.Location = new Point(5, 50 + (heigth + 5)*2);

            btn2.Width = width; btn2.Height = heigth;
            btn2.Location = new Point(5 + (5 + width) * 1, 50 + (heigth + 5) * 2);

            btn3.Width = width; btn3.Height = heigth;
            btn3.Location = new Point(5 + (5 + width) * 2, 50 + (heigth + 5) * 2);

            multiplyBtn.Width = width; multiplyBtn.Height = heigth;
            multiplyBtn.Location = new Point(5 + (5 + width) * 3, 50 + (heigth + 5) * 2);

            btn4.Width = width; btn4.Height = heigth;
            btn4.Location = new Point(5, 50 + heigth + 5);

            btn5.Width = width; btn5.Height = heigth;
            btn5.Location = new Point(5 + 5 + width, 50 + heigth + 5);

            btn6.Width = width; btn6.Height = heigth;
            btn6.Location = new Point(5 + (5 + width) * 2, 50 + heigth + 5);

            minusBtn.Width = width; minusBtn.Height = heigth;
            minusBtn.Location = new Point(5 + (5 + width) * 3, 50 + heigth + 5);

            btn7.Width = width; btn7.Height = heigth;
            btn7.Location = new Point(5,50);

            btn8.Width = width; btn8.Height = heigth;
            btn8.Location = new Point(5 + 5 + width, 50);

            btn9.Width = width; btn9.Height = heigth;
            btn9.Location = new Point(5 + (5 + width)*2, 50);

            plusBtn.Width = width; plusBtn.Height = heigth;
            plusBtn.Location = new Point(5 + (5 + width) * 3, 50);

        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            buffer = "";
            result.Text = "0";
            operationIsSet = false;
            newSession = true;
            result.Refresh();

            Form1_Resize(sender, e);
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= '0' && e.KeyValue <= '9') || e.KeyValue == 188)
            {
                if (newSession)
                {
                    result.Text = "0";
                    newSession = false;
                }
                if ((result.Text == "0") && (e.KeyValue != 188))
                {
                    result.Text = (e.KeyValue - '0').ToString();
                }
                else
                {
                    if (e.KeyValue == 188 && !result.Text.Contains(","))
                        result.Text += ',';
                    else
                        result.Text += (e.KeyValue - '0');
                }
                result.Refresh();
            }
        }
    }
}
