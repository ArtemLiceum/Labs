namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double CalculateSum(int x, int n)
        {
            double totalSum = 0;

            // Внешняя сумма: ∑(k^3 * innerSum) для k от 1 до n
            for (int k = 1; k <= n; k++)
            {
                double innerSum = 0;

                // Внутренняя сумма: ∑((k-1)^2 + x) для n от 1 до 15
                for (int m = 1; m <= 15; m++) // Используем m вместо n, чтобы избежать путаницы
                {
                    innerSum += Math.Pow(k - 1, 2) + x;
                }

                // Внешняя сумма: k^3 * innerSum
                totalSum += Math.Pow(k, 3) * innerSum;
            }

            return totalSum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            textBox3.Text = CalculateSum(x, n).ToString();
        }
    }
}
