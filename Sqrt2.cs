namespace Sqrt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
            }

            if(d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("Дискриминант равен нулю. Корень равен "+x+".");
            }

            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                MessageBox.Show("Дискриминант равен :" + d + " .Первый корень равен :" + x1 + " .Второй корень равен :" + x2);
}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
