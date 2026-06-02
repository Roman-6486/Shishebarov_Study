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
    public partial class FormShowMot : Form
    {
        public FormShowMot()
        {
            InitializeComponent();
        }

        public static ModelDB DB = new ModelDB();

        private void FormShowMot_Load(object sender, EventArgs e)
        {
            motorbikeBindingSource1.DataSource = DB.Motorbike.ToList();

            if (DB.Motorbike.ToList().Count == 0) return;
            int ID = (int)dataGridViewMot.CurrentRow.Cells[0].Value;
            pictureBox1.Image = Image.FromFile($@"Pictures\{DB.Motorbike.Find(ID).Picture}");

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddUPDMD form = new FormAddUPDMD();
            this.Visible = false;
            form.Show();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (DB.Motorbike.ToList().Count == 0)
            {            
                MessageBox.Show("Данные отсутствуют!");
                return;
            }

            Motorbike CurrentMoto = DB.Motorbike.Find((int)dataGridViewMot.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show(
                $@"Вы действительно хотите удалить объект с ID - {CurrentMoto.ID}",
                "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DB.Motorbike.Remove(CurrentMoto);
                    DB.SaveChanges();
                    File.Delete($@"Pictures\{CurrentMoto.Picture}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    motorbikeBindingSource1.DataSource = DB.Motorbike.ToList();
                    pictureBox1.Image = null;
                }
            }
        }

        private void dataGridViewMot_Click(object sender, EventArgs e)
        {
            if (DB.Motorbike.ToList().Count == 0 ) return;
            int ID = (int)dataGridViewMot.CurrentRow.Cells[0].Value;
            pictureBox1.Image = Image.FromFile($@"Pictures\{DB.Motorbike.Find(ID).Picture}");               
        }
    }
}
