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
            // �������������� ������ �� TextBox1 � ������������ �����.
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            // ���������� ����������.
            f = x + y;
            // �������������� ����� f � ������ � ����� ���������� � TextBox3
            textBox3.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ������� textBox1.
            textBox1.Text = "";
            // ������� textBox2.
            textBox2.Text = "";
            // ������� textBox3.
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
