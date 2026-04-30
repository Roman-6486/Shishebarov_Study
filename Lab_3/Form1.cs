using System;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;

            if (!double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Неверный формат числа в поле x: " + textBox1.Text);
                return;
            }

            if (!double.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Неверный формат числа в поле y: " + textBox2.Text);
                return;
            }

            double result = (10 * x + 15 * y) / 2.0;
            label3.Text = result.ToString();
        }
    }
}