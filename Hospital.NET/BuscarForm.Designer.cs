namespace Hospital.NET
{
    partial class BuscarForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.DNITextBox = new System.Windows.Forms.TextBox();
            this.NHCTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PACIENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COGNOMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADREÇA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POBLACIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DNITextBox
            // 
            this.DNITextBox.Location = new System.Drawing.Point(395, 45);
            this.DNITextBox.Name = "DNITextBox";
            this.DNITextBox.Size = new System.Drawing.Size(100, 20);
            this.DNITextBox.TabIndex = 22;
            // 
            // NHCTextBox
            // 
            this.NHCTextBox.Location = new System.Drawing.Point(187, 45);
            this.NHCTextBox.Name = "NHCTextBox";
            this.NHCTextBox.Size = new System.Drawing.Size(100, 20);
            this.NHCTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "NHC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PACIENT,
            this.NOM,
            this.COGNOMS,
            this.ADREÇA,
            this.POBLACIO,
            this.DNII,
            this.NHCC});
            this.dataGridView1.Location = new System.Drawing.Point(29, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // ID_PACIENT
            // 
            this.ID_PACIENT.DataPropertyName = "id_pacient";
            this.ID_PACIENT.HeaderText = "ID_PACIENT";
            this.ID_PACIENT.Name = "ID_PACIENT";
            // 
            // NOM
            // 
            this.NOM.DataPropertyName = "nom";
            this.NOM.HeaderText = "NOM";
            this.NOM.Name = "NOM";
            // 
            // COGNOMS
            // 
            this.COGNOMS.DataPropertyName = "cognoms";
            this.COGNOMS.HeaderText = "COGNOMS";
            this.COGNOMS.Name = "COGNOMS";
            // 
            // ADREÇA
            // 
            this.ADREÇA.DataPropertyName = "ADREÇA";
            this.ADREÇA.HeaderText = "ADREÇA";
            this.ADREÇA.Name = "ADREÇA";
            // 
            // POBLACIO
            // 
            this.POBLACIO.DataPropertyName = "poblacio";
            this.POBLACIO.HeaderText = "POBLACIO";
            this.POBLACIO.Name = "POBLACIO";
            // 
            // DNII
            // 
            this.DNII.DataPropertyName = "dni";
            this.DNII.HeaderText = "DNI";
            this.DNII.Name = "DNII";
            // 
            // NHCC
            // 
            this.NHCC.DataPropertyName = "nhc";
            this.NHCC.HeaderText = "NHC";
            this.NHCC.Name = "NHCC";
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DNITextBox);
            this.Controls.Add(this.NHCTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarForm";
            this.Text = "BuscarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DNITextBox;
        private System.Windows.Forms.TextBox NHCTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PACIENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn COGNOMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADREÇA;
        private System.Windows.Forms.DataGridViewTextBoxColumn POBLACIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNII;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHCC;
    }
}