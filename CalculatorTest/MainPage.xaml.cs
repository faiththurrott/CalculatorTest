namespace CalculatorTest;

class Calculator
{
    public static double GetNum(string numText)
    {
        double dNumTemp = 0;

        if (numText != null)
        {
            if (double.TryParse(numText, out dNumTemp))
            {
                return dNumTemp; //correct return num,
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
    }
}
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void entryNum1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void entryNum2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            // double dNum1 = Convert.ToDouble(entryNum1.Text);
            // double dNum2 = Convert.ToDouble(entryNum2.Text);
            double dNum1 = Calculator.GetNum(entryNum1.Text);
            double dNum2 = Calculator.GetNum(entryNum2.Text);

            double dAnswer = dNum1 + dNum2;
            txtAnswer.Text = Convert.ToString(dAnswer);
        }

        private void btnSubtract_Clicked(object sender, EventArgs e)
        {
            double dNum1 = Calculator.GetNum(entryNum1.Text);
            double dNum2 = Calculator.GetNum(entryNum2.Text);

            double dAnswer = dNum1 - dNum2;
            txtAnswer.Text = Convert.ToString(dAnswer);
    }

        private void btnMultiply_Clicked(object sender, EventArgs e)
        {
            double dNum1 = Calculator.GetNum(entryNum1.Text);
            double dNum2 = Calculator.GetNum(entryNum2.Text);

            double dAnswer = dNum1 * dNum2;
            txtAnswer.Text = Convert.ToString(dAnswer);
    }

        private void btnDivide_Clicked(object sender, EventArgs e)
        {
            double dNum1 = Calculator.GetNum(entryNum1.Text);
            double dNum2 = Calculator.GetNum(entryNum2.Text);

            double dAnswer = dNum1 / dNum2;
            txtAnswer.Text = Convert.ToString(dAnswer);
    }
    }

