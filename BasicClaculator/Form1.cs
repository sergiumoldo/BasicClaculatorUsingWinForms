using System.Data;
using System.Linq.Expressions;

namespace BasicClaculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "7";
            }
            else
            {
                Display.Text += "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "8";
            }
            else
            {
                Display.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "9";
            }
            else
            {
                Display.Text += "9";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "6";
            }
            else
            {
                Display.Text += "6";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "5";
            }
            else
            {
                Display.Text += "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "4";
            }
            else
            {
                Display.Text += "4";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "1";
            }
            else
            {
                Display.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "2";
            }
            else
            {
                Display.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
                Display.Text += "3";
            }
            else
            {
                Display.Text += "3";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text += "0";
            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                Display.Text += "00";
            }
            else
            {
                Display.Text = "0";
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains("."))
            {
                Display.Text += ".";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
            {
                Display.Text = "0";
            }

        }

        private void buttonCC_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            CalcBox.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            if (Display.Text != "0")
            {
                if (Display.Text.Length == 1)
                {
                    Display.Text = "0";
                }
                else
                {
                    var str = Display.Text.Substring(0, Display.Text.Length - 1);
                    Display.Text = str;
                }
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            var displayValue = Display.Text;
            CalcBox.Text += displayValue + "+";

            Display.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            var displayValue = Display.Text;
            CalcBox.Text += displayValue + "/";

            Display.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            var displayValue = Display.Text;
            CalcBox.Text += displayValue + "*";

            Display.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            var displayValue = Display.Text;
            CalcBox.Text += displayValue + "-";

            Display.Text = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            var str = CalcBox.Text + Display.Text;

            DataTable table = new DataTable();
            double result = Convert.ToDouble(table.Compute(str, ""));

            var resultDisplay = result.ToString();
            if (resultDisplay == "∞")
            {
                Display.Text = "0";
                CalcBox.Text = "";
            }
            else
            {
                Display.Text = resultDisplay;
                CalcBox.Text = "";
            }
        }
    }
}