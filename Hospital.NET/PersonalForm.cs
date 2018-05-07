using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.NET
{
    public partial class PersonalForm : Form
    {
        public PersonalForm()
        {
            InitializeComponent();
        }

        private void PersonalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Segur que desitja sortir de l'aplicació?", "Sortir",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show(
            "Desitja sortir de l'aplicació?",
            "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(buscarToolStripMenuItem.Text);
        }

        private void veureFitxaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(veureFitxaToolStripMenuItem.Text);
        }

        private void treureEtiquetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treureEtiquetaToolStripMenuItem.Text);
        }

        private void actesClínicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(actesClínicsToolStripMenuItem.Text);
        }

        private void buscarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(buscarNotaToolStripMenuItem.Text);
        }

        private void crearNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(crearNotaToolStripMenuItem.Text);
        }

        private void modificarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(modificarNotaToolStripMenuItem.Text);
        }

        private void eliminarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(eliminarNotaToolStripMenuItem.Text);
        }

    }
}
