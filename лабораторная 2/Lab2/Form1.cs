namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ������� ��� ���������� 3*sin(2^x) + 0.35*x^3 - 3.8
        private double CalculateF(double x)
        {
            return 3 * Math.Sin(Math.Pow(2, x)) + 0.35 * Math.Pow(x, 3) - 3.8;
        }

        // ������� ��� ���������� ln(x) - x + 1.8
        private double CalculateG(double x)
        {
            return Math.Log(x) - x + 1.8;
        }

        // ������� ��� ���������� ������� ����� �������� ��������������� ���� �����
        private double CalculateGeometricMeanFraction(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("��� ����� ������ ���� ��������������.");
            }

            double geometricMean = Math.Pow(a * b * c, 1.0 / 3.0); // ������� ��������������
            return geometricMean - Math.Floor(geometricMean); // ������� �����
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);


            textBox_result.Text = "�������:" + Environment.NewLine;
            textBox_result.Text += "X = " + x.ToString() + Environment.NewLine;
            textBox_result.Text += "��������� g = " + CalculateG(x);
            //textBox2.Text = "��������� f = " + CalculateF(x);
        }
    }

    }
