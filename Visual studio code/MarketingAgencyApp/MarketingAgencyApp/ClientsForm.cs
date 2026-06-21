using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketingAgencyApp
{
    public partial class ClientsForm : Form
    {
        private string connectionString;

        public ClientsForm()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["DbConnection"].ConnectionString;
            LoadClients();
        }

        private void LoadClients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clients", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvClients.DataSource = dt;
                if (dgvClients.Columns["ClientID"] != null)
                    dgvClients.Columns["ClientID"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditClientForm frm = new AddEditClientForm();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadClients();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientID"].Value);
            string name = dgvClients.CurrentRow.Cells["Name"].Value.ToString();
            string contact = dgvClients.CurrentRow.Cells["ContactInfo"].Value?.ToString() ?? "";
            AddEditClientForm frm = new AddEditClientForm(clientId, name, contact);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadClients();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            if (MessageBox.Show("Удалить клиента и все его проекты?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int clientId = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Clients WHERE ClientID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", clientId);
                    cmd.ExecuteNonQuery();
                }
                LoadClients();
            }
        }
    }
}