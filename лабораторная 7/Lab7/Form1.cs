namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функция для вычисления суммы S
        static double CalculateSum(double x, int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += (Math.Pow(Math.Log(3), i) / Factorial(i)) * Math.Pow(x, i);
            }
            return sum;
        }

        // Рекурсивная функция для вычисления факториала
        static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }

        // Функция для преобразования строки в массив целых чисел
        static int[] ParseArray(string input)
        {
            return input.Split(' ').Select(int.Parse).ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xStart = 0.1;
            double xEnd = 1.0;
            int n = 10;
            double step = (xEnd - xStart) / 10;
            textBoxXStart.Text = xStart.ToString();
            textBoxXEnd.Text = xEnd.ToString();
            textBoxN.Text = n.ToString();
            textBoxStep.Text = step.ToString();

            for (int i = 0; i <= 10; i++)
            {
                double x = xStart + i * step;
                double y = Math.Pow(3, x);
                double s = CalculateSum(x, n);

                textBoxResult.Text += $"x = {x:F2}, Y = {y:F6}, S = {s:F6}" + Environment.NewLine;
            }


        }
    }
}
