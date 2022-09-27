namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand = string.Empty;
        string operand1 = string.Empty;
        char operation;
        double result = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "1";
            this.button13.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "0";
            this.button13.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "2";
            this.button13.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '+';
            input = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "3";
            this.button13.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "6";
            this.button13.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "5";
            this.button13.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "4";
            this.button13.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '*';
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '/';
            input = string.Empty;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            operand = input;
            operation = '%';
            input = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '-';
            input = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "7";
            this.button13.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "8";
            this.button13.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += "9";
            this.button13.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            this.input = string.Empty;
            this.operand = string.Empty;
            this.operand1 = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            double num1, num2;
            double.TryParse(operand, out num1);
            double.TryParse(operand1, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                button13.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                button13.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                button13.Text = result.ToString();
            }

            else if (operation == '%') {
                result = num1 % num2;
                button13.Text = result.ToString();

            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    button13.Text = result.ToString();
                }
                else
                {
                    button13.Text = "undefined";
                }

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.button13.Text = "";
            input += ".";
            this.button13.Text += input;
        }

       
    }
}