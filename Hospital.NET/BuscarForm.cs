using DataLayer;
using ControllerLayer;
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
    public partial class BuscarForm : Form
    {

        String dni;
        String nhc;
        PacientController controller;
        PacientADO pacientado;

        //General variables
        DataSet dataList = new DataSet();


        public BuscarForm()
        {
            //We load data
            // File file = new File();
            // dataList = file.loadData("pacientes.txt");

            InitializeComponent();

            controller = new PacientController();
            pacientado = new PacientADO();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String dni = DNITextBox.Text;
            String nhc = NHCTextBox.Text;

            String res = "";

            if (dni == "" && nhc == "")
            {
                MessageBox.Show("Please provide a DNI or NHC");
                return;
            }

            if (DNITextBox.TextLength.Equals(0) != true)
            {
                findDNI();

            }

            else if (NHCTextBox.TextLength.Equals(0) != true)
            {
                findNHC();

            }

            else if (NHCTextBox.TextLength.Equals(0) == true && DNITextBox.TextLength.Equals(0) == true)
            {
                

            }


        }

        public void findDNI()
        {

            dataList = pacientado.getAll();

            if (dataList == null)
            {
                MessageBox.Show("No data found.");
            }
            else
            {

                dataGridView1.DataSource = dataList.Tables[0];

            }

        }

        public void findNHC()
        {
            

        }

    }
}
