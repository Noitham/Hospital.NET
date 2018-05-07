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
    public partial class AgregarForm : Form
    {
        public AgregarForm()
        {
            InitializeComponent();
        }

        public string[] getData()
        {

            //We save the introduced data in a Array so we can use them in the Main Form
            string[] data = new string[6];

            data[0] = this.nomTextBox.Text;
            data[1] = this.cognomsTextBox.Text;
            data[2] = this.adreçaTextBox.Text;
            data[3] = this.poblacioTextBox.Text;
            data[4] = this.dniTextBox.Text;
            data[5] = this.nhcTextBox.Text;

            return data;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomTextBox.TextLength.Equals(0) != true)
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Sius plau, completi tots els camps");
            }

        }

    }
}
