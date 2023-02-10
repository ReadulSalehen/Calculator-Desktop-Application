namespace RiadCalculator
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        double result = 0;
        String sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
        }

        private void btnSumation_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            sign = "+";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            sign = "-";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            sign = "*";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            sign = "/";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void btnEquel_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text;
            if (sign == "+")
            {
                result = num1 + num2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "-")
            {
                result = num1 - num2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = num1 * num2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "/")
            {
                result = num1 / num2;
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}