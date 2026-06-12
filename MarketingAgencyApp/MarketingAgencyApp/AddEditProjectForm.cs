using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketingAgencyApp
{
    public partial class AddEditProjectForm : Form
    {
        private string connectionString;
        private int? projectId;

        // Конструктор для ДОБАВЛЕНИЯ
        public AddEditProjectForm()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["DbConnection"].ConnectionString;
            projectId = null;
            LoadComboBoxes();
            cmbStatus.Items.AddRange(new string[] { "В работе", "Завершён", "Отменён" });
            cmbStatus.SelectedIndex = 0;
            this.Text = "Добавление проекта";
        }

        // Конструктор для РЕДАКТИРОВАНИЯ (принимает ID проекта)
        public AddEditProjectForm(int projectId) : this()
        {
            this.projectId = projectId;
            LoadProjectData();
            this.Text = "Редактирование проекта";
        }

        // Заполнение выпадающих списков клиентами и услугами
        private void LoadComboBoxes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Клиенты
                SqlDataAdapter daClients = new SqlDataAdapter(
                    "SELECT ClientID, Name FROM Clients", conn);
                DataTable dtClients = new DataTable();
                daClients.Fill(dtClients);
                cmbClient.DataSource = dtClients;
                cmbClient.DisplayMember = "Name";      // показываем название
                cmbClient.ValueMember = "ClientID";    // храним ID

                // Услуги
                SqlDataAdapter daServices = new SqlDataAdapter(
                    "SELECT ServiceID, ServiceName FROM Services", conn);
                DataTable dtServices = new DataTable();
                daServices.Fill(dtServices);
                cmbService.DataSource = dtServices;
                cmbService.DisplayMember = "ServiceName";
                cmbService.ValueMember = "ServiceID";
            }
        }

        // Загрузка данных проекта при редактировании
        private void LoadProjectData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT ClientID, ServiceID, StartDate, EndDate,
                                        Status, Budget
                                 FROM Projects
                                 WHERE ProjectID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", projectId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cmbClient.SelectedValue = reader.GetInt32(0);
                        cmbService.SelectedValue = reader.GetInt32(1);
                        dtpStart.Value = reader.GetDateTime(2);
                        dtpEnd.Value = reader.GetDateTime(3);
                        cmbStatus.Text = reader.GetString(4);
                        txtBudget.Text = reader.GetDecimal(5).ToString();
                    }
                }
            }
        }

        // Сохранение (добавление или обновление)
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue == null || cmbService.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента и услугу!");
                return;
            }

            decimal budget;
            decimal.TryParse(txtBudget.Text, out budget);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                if (projectId.HasValue)  // обновление
                {
                    cmd = new SqlCommand(
                        @"UPDATE Projects
                          SET ClientID = @client,
                              ServiceID = @service,
                              StartDate = @start,
                              EndDate = @end,
                              Status = @status,
                              Budget = @budget
                          WHERE ProjectID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", projectId.Value);
                }
                else  // добавление
                {
                    cmd = new SqlCommand(
                        @"INSERT INTO Projects (ClientID, ServiceID, StartDate, EndDate, Status, Budget)
                          VALUES (@client, @service, @start, @end, @status, @budget)", conn);
                }

                cmd.Parameters.AddWithValue("@client", cmbClient.SelectedValue);
                cmd.Parameters.AddWithValue("@service", cmbService.SelectedValue);
                cmd.Parameters.AddWithValue("@start", dtpStart.Value.Date);
                cmd.Parameters.AddWithValue("@end", dtpEnd.Value.Date);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@budget", budget);

                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}