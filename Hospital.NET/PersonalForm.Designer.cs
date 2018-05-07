namespace Hospital.NET
{
    partial class PersonalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veureFitxaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treureEtiquetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actesClínicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientsToolStripMenuItem,
            this.notesToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientsToolStripMenuItem
            // 
            this.pacientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.veureFitxaToolStripMenuItem,
            this.treureEtiquetaToolStripMenuItem,
            this.actesClínicsToolStripMenuItem});
            this.pacientsToolStripMenuItem.Name = "pacientsToolStripMenuItem";
            this.pacientsToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.pacientsToolStripMenuItem.Text = "&Pacients";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // veureFitxaToolStripMenuItem
            // 
            this.veureFitxaToolStripMenuItem.Name = "veureFitxaToolStripMenuItem";
            this.veureFitxaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.veureFitxaToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.veureFitxaToolStripMenuItem.Text = "Veure fitxa";
            this.veureFitxaToolStripMenuItem.Click += new System.EventHandler(this.veureFitxaToolStripMenuItem_Click);
            // 
            // treureEtiquetaToolStripMenuItem
            // 
            this.treureEtiquetaToolStripMenuItem.Name = "treureEtiquetaToolStripMenuItem";
            this.treureEtiquetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.treureEtiquetaToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.treureEtiquetaToolStripMenuItem.Text = "Treure etiqueta";
            this.treureEtiquetaToolStripMenuItem.Click += new System.EventHandler(this.treureEtiquetaToolStripMenuItem_Click);
            // 
            // actesClínicsToolStripMenuItem
            // 
            this.actesClínicsToolStripMenuItem.Name = "actesClínicsToolStripMenuItem";
            this.actesClínicsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.actesClínicsToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.actesClínicsToolStripMenuItem.Text = "Actes clínics";
            this.actesClínicsToolStripMenuItem.Click += new System.EventHandler(this.actesClínicsToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarNotaToolStripMenuItem,
            this.crearNotaToolStripMenuItem,
            this.modificarNotaToolStripMenuItem,
            this.eliminarNotaToolStripMenuItem});
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.notesToolStripMenuItem.Text = "&Notes";
            // 
            // buscarNotaToolStripMenuItem
            // 
            this.buscarNotaToolStripMenuItem.Name = "buscarNotaToolStripMenuItem";
            this.buscarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.buscarNotaToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.buscarNotaToolStripMenuItem.Text = "Buscar nota";
            this.buscarNotaToolStripMenuItem.Click += new System.EventHandler(this.buscarNotaToolStripMenuItem_Click);
            // 
            // crearNotaToolStripMenuItem
            // 
            this.crearNotaToolStripMenuItem.Name = "crearNotaToolStripMenuItem";
            this.crearNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.crearNotaToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.crearNotaToolStripMenuItem.Text = "Crear nota";
            this.crearNotaToolStripMenuItem.Click += new System.EventHandler(this.crearNotaToolStripMenuItem_Click);
            // 
            // modificarNotaToolStripMenuItem
            // 
            this.modificarNotaToolStripMenuItem.Name = "modificarNotaToolStripMenuItem";
            this.modificarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modificarNotaToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.modificarNotaToolStripMenuItem.Text = "Modificar nota";
            this.modificarNotaToolStripMenuItem.Click += new System.EventHandler(this.modificarNotaToolStripMenuItem_Click);
            // 
            // eliminarNotaToolStripMenuItem
            // 
            this.eliminarNotaToolStripMenuItem.Name = "eliminarNotaToolStripMenuItem";
            this.eliminarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarNotaToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.eliminarNotaToolStripMenuItem.Text = "Eliminar nota";
            this.eliminarNotaToolStripMenuItem.Click += new System.EventHandler(this.eliminarNotaToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.sortirToolStripMenuItem.Text = "&Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veureFitxaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treureEtiquetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actesClínicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
    }
}