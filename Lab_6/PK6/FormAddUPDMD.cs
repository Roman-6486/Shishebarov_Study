using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PK6.ModelEF;

namespace PK6
{
    public partial class FormAddUPDMD : Form
    {
        public FormAddUPDMD()
        {
            InitializeComponent();
        }
        private string Pic_Name;
        private List<Motorbike> vsMotorbike = FormShowMot.DB.Motorbike.ToList();

        private void FormAddUPDMD_Load(object sender, EventArgs e)
        {
            List<string> dictMarka = new List<string>();
            foreach (Motorbike TB in vsMotorbike)
                dictMarka.Add(TB.Brand);
            dictMarka = dictMarka.Distinct().ToList();
            comboBoxMarka.DataSource = dictMarka;
        }

        private void buttonAddU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxMarka.Text) || String.IsNullOrEmpty(textBoxModel.Text))
            {
                MessageBox.Show("Заполните все поля Модель и Марка!");
                return;
            }

            try
            {
                Convert.ToInt32(textBoxMilega.Text);
                Convert.ToInt32(textBoxHoursepower.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В полях Л/С и Пробег, могут быть только целочисленные данные");
                return;
            }

            try
            {
                Convert.ToInt32(textBoxPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В поле Цена, могут быть только целочисленные данные");
                return;
            }

            if (!File.Exists(Pic_Name))
            {
                MessageBox.Show("Невозможно найти файл");
                return;
            }

            File.Copy(Pic_Name, $@"Pictures\{FLplus1()}{Path.GetExtension(Pic_Name)}"); 

            Motorbike NMotorbike = new Motorbike();

            NMotorbike.ID = FLplus1();
            NMotorbike.Brand = comboBoxMarka.Text;
            NMotorbike.Model = textBoxModel.Text;
            NMotorbike.Price = Convert.ToInt32(textBoxPrice.Text);
            NMotorbike.Horsepower = Convert.ToInt32(textBoxHoursepower.Text);
            NMotorbike.Milega = Convert.ToInt32(textBoxMilega.Text);
            NMotorbike.Picture = $@"{FLplus1()}{Path.GetExtension(Pic_Name)}";

            try
            {
                FormShowMot.DB.Motorbike.Add(NMotorbike);
                FormShowMot.DB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Всё готово - закрыть
            MessageBox.Show("Данные успешно добавлены!");
            FormShowMot form = new FormShowMot();
            form.Visible = true;
            this.Close();

            // Выбран первый варинт - TextBox не воспринимается

            // Очистка всех полей
            /*foreach (TextBox textBox in this.Controls.OfType<TextBox>())
                textBox.Text = null;
            comboBoxMarka.SelectedIndex = 0;
            pictureBox1.Image = null;
            Pic_Name = null;*/
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            DialogResult result = openFileDialog.ShowDialog();
            if (DialogResult.OK == result)
            {
                Pic_Name = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormShowMot form = new FormShowMot();
            form.Visible = true;
            this.Close();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }

        private int FLplus1() // Find Last Plus One Находит последний ID и прибавляет 1
        {
            int max = 0;
            foreach (Motorbike TB in vsMotorbike)
                if (max < TB.ID) max = TB.ID;
            return ++max;
        }
    }
}
