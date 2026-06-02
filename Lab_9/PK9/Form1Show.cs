using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PK9.ModelEF;

namespace PK9
{
    public partial class Form1Show : Form
    {
        public Form1Show()
        {
            InitializeComponent();
        }

        private void Form1Show_Load(object sender, EventArgs e)
        {
            ModelEF model = new ModelEF();
            dataGridView1.DataSource = model.Student.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2AddData form2 = new Form2AddData();
            form2.Show();
            Hide();
        }
    }
}
