using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketingAgencyApp
{
    public partial class MainForm : Form
    {
        private string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["DbConnection"].ConnectionString;
            LoadProjects();
        }

        private void LoadProjects()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM vw_ProjectDetails";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProjects.DataSource = dt;

                if (dgvProjects.Columns["ProjectID"] != null)
                    dgvProjects.Columns["ProjectID"].Visible = false;
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddEditProjectForm frm = new AddEditProjectForm();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadProjects();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProjects.CurrentRow == null) return;

            if (MessageBox.Show("Удалить выбранный проект?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int projectId = Convert.ToInt32(dgvProjects.CurrentRow.Cells["ProjectID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Projects WHERE ProjectID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", projectId);
                    cmd.ExecuteNonQuery();
                }
                LoadProjects();
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm frm = new ClientsForm();
            frm.ShowDialog();
            LoadProjects();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ServicesForm frm = new ServicesForm();
            frm.ShowDialog();
            LoadProjects();
        }

        private void dgvProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int projectId = Convert.ToInt32(dgvProjects.Rows[e.RowIndex].Cells["ProjectID"].Value);
                AddEditProjectForm frm = new AddEditProjectForm(projectId);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadProjects();
            }
        }
    }
}