namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool CheckCondition(int number)
        {

            int firstDigit = number / 1000;         // ������ �����
            int secondDigit = (number / 100) % 10;  // ������ �����
            int thirdDigit = (number / 10) % 10;    // ������ �����
            int fourthDigit = number % 10;          // ��������� �����

            return (firstDigit + fourthDigit) == (secondDigit * thirdDigit);
        }

        static string Task2(int number)
        {
            int firstDigit = number / 10; // ������� �����
            int secondDigit = number % 10; // ������� �����

            // ������� ��� �������� ����
            string[] russianNames = { "����", "����", "���" };
            string[] englishNames = { "zero", "one", "two" };

            // �������� �������: ������� ����� ������ �������
            if (firstDigit > secondDigit)
            {
                return $"{russianNames[firstDigit]}, {russianNames[secondDigit]}";
            }
            else
            {
                return $"{englishNames[firstDigit]}, {englishNames[secondDigit]}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            textBox2.Text = Task2(x).ToString(); 
        }
    }
}
