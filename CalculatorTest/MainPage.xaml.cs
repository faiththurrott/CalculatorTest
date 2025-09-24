

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
    public string correctText1;
    public string correctText2;
    private void entryNum1_TextChanged(object sender, TextChangedEventArgs e)
    {
        double dNumTemp = 0;
        if (double.TryParse(entryNum1.Text, out dNumTemp))
        {
            correctText1 = entryNum1.Text;
        }
        else
        { 
            entryNum1.CursorPosition=correctText1.Length;
            int selectionLength = e.NewTextValue.Length - correctText1.Length;
            if(selectionLength > 0)
            {
                entryNum1.SelectionLength = selectionLength;
            }
        }

    }

        private void entryNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double dNumTemp = 0;
        if (double.TryParse(entryNum2.Text, out dNumTemp))
        {
            correctText2 = entryNum2.Text;
        }
        else
        {
            entryNum2.CursorPosition = correctText2.Length;
            int selectionLength = e.NewTextValue.Length - correctText2.Length;
            if(selectionLength > 0)
            {
                entryNum2.SelectionLength = selectionLength;
            }
        }
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

    private void btnRoot_Clicked(object sender, EventArgs e)
    {

    }
}
