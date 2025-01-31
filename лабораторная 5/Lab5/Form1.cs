namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ������� ��� ���������� ����� ����� ����������� � ������������ ����������
        static int SumBetweenMinAndMax(string input)
        {
            // ����������� ������ � ������ ����� �����
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length != 10)
            {
                throw new ArgumentException("������ ������ ��������� ����� 10 �����.");
            }

            // ������� ������� ������������ � ������������� ���������
            int minIndex = Array.IndexOf(numbers, numbers.Min());
            int maxIndex = Array.IndexOf(numbers, numbers.Max());

            // ���������� ������� ��� ������������
            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            // ��������� �������� ����� ����������� � ������������
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static int MaxSequenceLength(string input)
        {
            // ����������� ������ � ������ ����� �����
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 0)
            {
                throw new ArgumentException("������ �� ������ ���� ������.");
            }

            int maxLength = 1; // ����������� ����� ������������������
            int currentLength = 1;

            // �������� �� ������� � ���� ������������������
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
