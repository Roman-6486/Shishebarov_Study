using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PK5.FolderforModel; // добавляем созд папку из проекта для более удобного использования


namespace PK5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static ModelDB DB = new ModelDB();

        List<Table_Motorbike> Motorbikes = DB.Motorbike.ToList(); // Из бд таблица берётся

        int AccNumber = 0; // на каком эл сейчас находимся

        private void Loading() // пераоначальная (обычная) загрузка эл UserControlName
        {
            userControlName1.Fill(Motorbikes[AccNumber]); // заполнение 1 и 2-о User Control
            userControlName2.Fill(Motorbikes[AccNumber + 1]);
        }

        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
                AccNumber++; // Листать вправо
            else if ((Incr == false && 0 <= AccNumber - 1))
                AccNumber--; // Листать влево
            else
                return; // Если проверка не пройдена - выход из метода

            Loading();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true); // перемотка вперёд
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false); // перемотка назад
        }

        private void userControlName1_Load(object sender, EventArgs e)
        {

        }

    }
}
