namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, f;
            // Преобразование текста из TextBox1 в вещественное число.
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            // Вычисление результата.
            f = x + y;
            // Преобразование числа f в строку и вывод результата в TextBox3
            textBox3.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Очищаем textBox1.
            textBox1.Text = "";
            // Очищаем textBox2.
            textBox2.Text = "";
            // Очищаем textBox3.
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
