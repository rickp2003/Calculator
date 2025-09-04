namespace Calculator
{
    public partial class calculatorMainForm : Form
    {
        public calculatorMainForm()
        {
            InitializeComponent();
        }

        double firstNum, secondNum;
        string option;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "+";
            option = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "-";
            option = "-";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "*";
            option = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "/";
            option = "/";
        }

        private void btnIs_Click(object sender, EventArgs e)
        {
            string input = txtTotal.Text.Replace(',', '.'); 
            int operatorIndex = -1;

            if (option == "+") operatorIndex = input.IndexOf('+');
            else if (option == "-") operatorIndex = input.IndexOf('-');
            else if (option == "*") operatorIndex = input.IndexOf('*');
            else if (option == "/") operatorIndex = input.IndexOf('/');

            if (operatorIndex > 0)
            {
                string firstPart = input.Substring(0, operatorIndex);
                string secondPart = input.Substring(operatorIndex + 1);

                if (double.TryParse(firstPart, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out firstNum) &&
                    double.TryParse(secondPart, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out secondNum))
                {
                    double calcResult = 0;
                    switch (option)
                    {
                        case "+":
                            calcResult = firstNum + secondNum;
                            txtTotal.Text = calcResult.ToString();
                            break;
                        case "-":
                            calcResult = firstNum - secondNum;
                            txtTotal.Text = calcResult.ToString();
                            break;
                        case "*":
                            calcResult = firstNum * secondNum;
                            txtTotal.Text = calcResult.ToString();
                            break;
                        case "/":
                            if (secondNum == 0)
                            {
                                txtTotal.Text = "Error";
                            }
                            else
                            {
                                calcResult = firstNum / secondNum;
                                txtTotal.Text = calcResult.ToString();
                            }
                            break;
                    }
                }
                else
                {
                    txtTotal.Text = "Error";
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            option = "";
            firstNum = 0;
            secondNum = 0;
        }
    }
}
