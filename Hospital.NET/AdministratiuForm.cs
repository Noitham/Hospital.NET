using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.NET
{
    public partial class AdministratiuForm : Form
    {

        List<Pacient> dataList = new List<Pacient>();
        List<Pacient> dataList2 = new List<Pacient>();

        public AdministratiuForm()
        {

            //File file = new File();
            //dataList2 = file.loadData("pacientes.txt");
            InitializeComponent();

        }


        private void tabPage5_Click(object sender, EventArgs e)
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

        private void buscarToolStripButton_Click(object sender, EventArgs e)
        {
            BuscarForm fm = new BuscarForm();
            fm.ShowDialog();
        }


        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            AgregarForm newPacient = new AgregarForm();

            if (newPacient.ShowDialog() == DialogResult.OK) { }

            string[] newData = newPacient.getData();//We take the data from NewPacient form
                                                    //If name is not empty, we take the data

            if (!newData[0].Equals("") && !newData[1].Equals("") && !newData[2].Equals("") && !newData[3].Equals("") && !newData[4].Equals("") && !newData[5].Equals(""))
            {
                //We create a new Product and we save it on our list
                Pacient pacient = new Pacient(newData[0], newData[1], newData[2], newData[3], newData[4], newData[5]);
                dataList.Add(pacient);

                try
                {
                    StreamWriter writer = new StreamWriter("pacientes.txt");
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        writer.Write(newData[0]);
                        writer.Write(":");
                        writer.Write(newData[1]);
                        writer.Write(":");
                        writer.Write(newData[2]);
                        writer.Write(":");
                        writer.Write(newData[3]);
                        writer.Write(":");
                        writer.Write(newData[4]);
                        writer.Write(":");
                        writer.Write(newData[5]);
                        writer.WriteLine();
                    }
                    writer.Dispose();
                    writer.Close();

                    MessageBox.Show("Paciente añadido correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No hay ningún archivo abierto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No data introduced");
            }

        }
    }
}
