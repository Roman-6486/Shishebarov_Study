namespace PK6
{
    partial class FormAddUPDMD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonAddU = new System.Windows.Forms.Button();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelLC = new System.Windows.Forms.Label();
            this.labelRun = new System.Windows.Forms.Label();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxHoursepower = new System.Windows.Forms.TextBox();
            this.textBoxMilega = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(12, 12);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(126, 35);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "Назад";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddU
            // 
            this.buttonAddU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddU.Location = new System.Drawing.Point(627, 352);
            this.buttonAddU.Name = "buttonAddU";
            this.buttonAddU.Size = new System.Drawing.Size(138, 43);
            this.buttonAddU.TabIndex = 1;
            this.buttonAddU.Text = "Добавить";
            this.buttonAddU.UseVisualStyleBackColor = true;
            this.buttonAddU.Click += new System.EventHandler(this.buttonAddU_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(135, 132);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(325, 20);
            this.textBoxModel.TabIndex = 3;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(12, 126);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(92, 26);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Модель";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(530, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMarka.Location = new System.Drawing.Point(27, 171);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(77, 26);
            this.labelMarka.TabIndex = 6;
            this.labelMarka.Text = "Марка";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(40, 211);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(64, 26);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Цена";
            // 
            // labelLC
            // 
            this.labelLC.AutoSize = true;
            this.labelLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLC.Location = new System.Drawing.Point(54, 255);
            this.labelLC.Name = "labelLC";
            this.labelLC.Size = new System.Drawing.Size(50, 26);
            this.labelLC.TabIndex = 8;
            this.labelLC.Text = "Л/С";
            // 
            // labelRun
            // 
            this.labelRun.AutoSize = true;
            this.labelRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRun.Location = new System.Drawing.Point(19, 294);
            this.labelRun.Name = "labelRun";
            this.labelRun.Size = new System.Drawing.Size(85, 26);
            this.labelRun.TabIndex = 9;
            this.labelRun.Text = "Пробег";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(135, 171);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(325, 21);
            this.comboBoxMarka.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(135, 217);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(325, 20);
            this.textBoxPrice.TabIndex = 11;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxHoursepower
            // 
            this.textBoxHoursepower.Location = new System.Drawing.Point(135, 261);
            this.textBoxHoursepower.Name = "textBoxHoursepower";
            this.textBoxHoursepower.Size = new System.Drawing.Size(325, 20);
            this.textBoxHoursepower.TabIndex = 12;
            this.textBoxHoursepower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBoxMilega
            // 
            this.textBoxMilega.Location = new System.Drawing.Point(135, 300);
            this.textBoxMilega.Name = "textBoxMilega";
            this.textBoxMilega.Size = new System.Drawing.Size(325, 20);
            this.textBoxMilega.TabIndex = 13;
            this.textBoxMilega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // FormAddUPDMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMilega);
            this.Controls.Add(this.textBoxHoursepower);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.labelRun);
            this.Controls.Add(this.labelLC);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.buttonAddU);
            this.Controls.Add(this.buttonLeft);
            this.Name = "FormAddUPDMD";
            this.Text = "FormAddUPDMD";
            this.Load += new System.EventHandler(this.FormAddUPDMD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonAddU;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelLC;
        private System.Windows.Forms.Label labelRun;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxHoursepower;
        private System.Windows.Forms.TextBox textBoxMilega;
    }
}