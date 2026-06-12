using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketingAgencyApp
{
    public partial class AddEditServiceForm : Form
    {
        private string connectionString;
        private int? serviceId;

        public AddEditServiceForm()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            serviceId = null;
            this.Text = "Добавление услуги";
        }

        public AddEditServiceForm(int id, string name, string desc, decimal price) : this()
        {
            serviceId = id;
            txtServiceName.Text = name;
            txtDescription.Text = desc;
            txtPrice.Text = price.ToString();
            this.Text = "Редактирование услуги";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Введите название услуги!");
                return;
            }
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;
                if (serviceId.HasValue)
                {
                    cmd = new SqlCommand(
                        "UPDATE Services SET ServiceName=@name, Description=@desc, Price=@price WHERE ServiceID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", serviceId.Value);
                }
                else
                {
                    cmd = new SqlCommand(
                        "INSERT INTO Services (ServiceName, Description, Price) VALUES (@name, @desc, @price)", conn);
                }
                cmd.Parameters.AddWithValue("@name", txtServiceName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}