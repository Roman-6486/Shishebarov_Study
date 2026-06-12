using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketingAgencyApp
{
    public partial class AddEditClientForm : Form
    {
        private string connectionString;
        private int? clientId;

        // Конструктор для добавления
        public AddEditClientForm()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["DbConnection"].ConnectionString;
            clientId = null;
            this.Text = "Добавление клиента";
        }

        // Конструктор для редактирования
        public AddEditClientForm(int id, string name, string contact) : this()
        {
            clientId = id;
            txtName.Text = name;
            txtContact.Text = contact;
            this.Text = "Редактирование клиента";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название клиента!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd;
                    if (clientId.HasValue)  // обновление
                    {
                        cmd = new SqlCommand(
                            "UPDATE Clients SET Name=@name, ContactInfo=@contact WHERE ClientID=@id", conn);
                        cmd.Parameters.AddWithValue("@id", clientId.Value);
                    }
                    else  // добавление
                    {
                        cmd = new SqlCommand(
                            "INSERT INTO Clients (Name, ContactInfo) VALUES (@name, @contact)", conn);
                    }
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Сохранение прошло успешно!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}