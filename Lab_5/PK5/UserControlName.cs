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

namespace PK5.FolderforModel
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Fill (Table_Motorbike Motorbike)
        {
            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHoursepowerData.Text = Motorbike.Horsepower.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");
        }

        private void UserControlName_Load(object sender, EventArgs e)
        {

        }
    }
}
