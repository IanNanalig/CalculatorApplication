using static CalculatorApplication.Calculator;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private Calculator cal;

        private double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new Calculator();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtBoxInput1.Text);
                num2 = Convert.ToDouble(txtBoxInput2.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            double result = 0;
            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    result = cal.GetSum(num1, num2);
                    break;

                case "-":
                    result = cal.GetDifference(num1, num2);
                    break;

                case "*":
                    result = cal.GetProduct(num1, num2);
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = cal.GetQuotient(num1, num2);
                    break;

                default:
                    MessageBox.Show("Please select an operator.");
                    return;
            }
            lblDisplayTotal.Text = result.ToString();
        }
    }
}
