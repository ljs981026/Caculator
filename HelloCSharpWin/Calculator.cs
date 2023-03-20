using System.Windows.Forms;
namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Sum1.Text);
            int number2 = Convert.ToInt32(Sum2.Text);
            int sum = number1 + number2;

            SumResult.Text = Add(number1, number2).ToString()+", " +sum.ToString()+", "+Add2(number1, number2).ToString();
        }
        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add2(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        //public void Flush(Number1);
        //public void Flush(Number2);
        //public void Flush(Number1, Number2);
        //public void Flush();
    }
}