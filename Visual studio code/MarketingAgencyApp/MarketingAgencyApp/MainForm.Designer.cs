namespace MarketingAgencyApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(0, 0);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.Size = new System.Drawing.Size(717, 117);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellDoubleClick);
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddProject.Location = new System.Drawing.Point(0, 116);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(178, 33);
            this.btnAddProject.TabIndex = 1;
            this.btnAddProject.Text = "Добавить проект";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(176, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClients.Location = new System.Drawing.Point(355, 116);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(181, 33);
            this.btnClients.TabIndex = 3;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServices.Location = new System.Drawing.Point(533, 116);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(184, 33);
            this.btnServices.TabIndex = 4;
            this.btnServices.Text = "Услуги";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 147);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.dgvProjects);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnServices;
    }
}

