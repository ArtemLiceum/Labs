namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // ������� ��� �������� ������� �� ������
        static double[,] ParseMatrix(string text, int rows, int cols)
        {
            double[,] matrix = new double[rows, cols];
            string[] lines = text.Trim().Split('\n');

            for (int i = 0; i < rows; i++)
            {
                string[] numbers = lines[i].Trim().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = double.Parse(numbers[j]);
                }
            }

            return matrix;
        }

        // ������� ��� ����������� ������������� �������� � ������� ����� ����
        static void MoveMaxToTopLeft(ref double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // ������� ������� ������������� ��������
            int maxRow = 0, maxCol = 0;
            double maxValue = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            // ������������ ������
            if (maxRow != 0)
            {
                for (int j = 0; j < cols; j++)
                {
                    double temp = matrix[0, j];
                    matrix[0, j] = matrix[maxRow, j];
                    matrix[maxRow, j] = temp;
                }
            }

            // ������������ �������
            if (maxCol != 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    double temp = matrix[i, 0];
                    matrix[i, 0] = matrix[i, maxCol];
                    matrix[i, maxCol] = temp;
                }
            }
        }

        // ������� ��� ���������� ����� �� ������� ��������
        static void SortRowsByFirstElement(ref double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // ����������� ������� � ������ ����� ��� �������� ����������
            double[][] rowsArray = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                rowsArray[i] = new double[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowsArray[i][j] = matrix[i, j];
                }
            }

            // ��������� ������ �� ������� ��������
            Array.Sort(rowsArray, (a, b) => a[0].CompareTo(b[0]));

            // ���������� ��������������� ������ � �������
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowsArray[i][j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int n = int.Parse(textBox3.Text);
            int m = int.Parse(textBox4.Text);

            double[,] matrix = ParseMatrix(input, n, m);
            SortRowsByFirstElement(ref matrix);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    textBox2.Text += matrix[i, j] + " ";
                }
                textBox2.Text += Environment.NewLine;
            }
        }
    }
}
