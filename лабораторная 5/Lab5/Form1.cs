namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функция для вычисления суммы между минимальным и максимальным элементами
        static int SumBetweenMinAndMax(string input)
        {
            // Преобразуем строку в массив целых чисел
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length != 10)
            {
                throw new ArgumentException("Массив должен содержать ровно 10 чисел.");
            }

            // Находим индексы минимального и максимального элементов
            int minIndex = Array.IndexOf(numbers, numbers.Min());
            int maxIndex = Array.IndexOf(numbers, numbers.Max());

            // Определяем границы для суммирования
            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            // Суммируем элементы между минимальным и максимальным
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static int MaxSequenceLength(string input)
        {
            // Преобразуем строку в массив целых чисел
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым.");
            }

            int maxLength = 1; // Минимальная длина последовательности
            int currentLength = 1;

            // Проходим по массиву и ищем последовательности
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            textBox2.Text = MaxSequenceLength(input).ToString();
        }
    }
}
