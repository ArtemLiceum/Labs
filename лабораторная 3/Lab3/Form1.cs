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

            int firstDigit = number / 1000;         // Первая цифра
            int secondDigit = (number / 100) % 10;  // Вторая цифра
            int thirdDigit = (number / 10) % 10;    // Третья цифра
            int fourthDigit = number % 10;          // Четвертая цифра

            return (firstDigit + fourthDigit) == (secondDigit * thirdDigit);
        }

        static string Task2(int number)
        {
            int firstDigit = number / 10; // Старшая цифра
            int secondDigit = number % 10; // Младшая цифра

            // Словари для названий цифр
            string[] russianNames = { "ноль", "один", "два" };
            string[] englishNames = { "zero", "one", "two" };

            // Проверка условия: старшая цифра больше младшей
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
