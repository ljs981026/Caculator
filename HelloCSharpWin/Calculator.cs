using System.Windows.Forms;
namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        // 값을 담을 Result 변수와 새로운 숫자 입력시 판별할 isNewNum 불변수 생성
        public int Result = 0;
        public bool isNewNum = true;
        public Calculator()
        {
            InitializeComponent();
        }
        // 1 클릭 이벤트
        private void NumButton1_Click(object sender, EventArgs e)
        {
            SetNum(NumButton1.Text);           
        }
        // 2 클릭 이벤트
        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum(NumButton2.Text);
        }
        // if => isNewNum이 true이면 매개변수 num을 NumScreen에 출력하고 isNewNum을 false로 변경
        // elseif => NumScreen에 출력 값이 0이면 num을 NumScreen에 출력 
        // else => NumScreen 출력값에 num 추가
        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text += num;
            }
        }
        // + 클릭 이벤트
        // Result에 num값을 더해서 저장해주고 isNewNum을 true로 변경
        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result += num;
            NumScreen.Text = Result.ToString();
            isNewNum = true;
        }
    }
}