using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            if (listBox1.SelectedIndex == -1)
            {
                textBox2.Text = "Выберите функцию";
                return;
            }

            double x;
            if (!double.TryParse(textBox1.Text, out x))
            {
                textBox2.Text = "Ошибка ввода x";
                return;
            }

            string function = listBox1.SelectedItem.ToString();
            double result = 0;

            switch (function)
            {
                case "Тангенс":
                    result = Math.Tan(x);
                    break;

                case "Синус":
                    result = Math.Sin(x);
                    break;

                case "Логарифм":
                    if (x <= 0)
                    {
                        textBox2.Text = "x должен быть > 0";
                        return;
                    }
                    result = Math.Log(x);
                    break;

                default:
                    textBox2.Text = "Ошибка";
                    return;
            }

            textBox2.Text = result.ToString("F4");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}