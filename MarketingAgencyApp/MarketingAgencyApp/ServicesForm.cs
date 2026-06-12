using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketingAgencyApp
{
    public partial class ServicesForm : Form
    {
        private string connectionString;

        public ServicesForm()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            LoadServices();
        }

        private void LoadServices()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Services", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvServices.DataSource = dt;
                if (dgvServices.Columns["ServiceID"] != null)
                    dgvServices.Columns["ServiceID"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditServiceForm frm = new AddEditServiceForm();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadServices();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow == null) return;
            int serviceId = Convert.ToInt32(dgvServices.CurrentRow.Cells["ServiceID"].Value);
            string name = dgvServices.CurrentRow.Cells["ServiceName"].Value.ToString();
            string desc = dgvServices.CurrentRow.Cells["Description"].Value?.ToString() ?? "";
            decimal price = Convert.ToDecimal(dgvServices.CurrentRow.Cells["Price"].Value ?? 0);
            AddEditServiceForm frm = new AddEditServiceForm(serviceId, name, desc, price);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadServices();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow == null) return;
            if (MessageBox.Show("Удалить услугу и все проекты с ней?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int serviceId = Convert.ToInt32(dgvServices.CurrentRow.Cells["ServiceID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Services WHERE ServiceID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", serviceId);
                    cmd.ExecuteNonQuery();
                }
                LoadServices();
            }
        }
    }
}