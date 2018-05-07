using ControllerLayer;
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
    public partial class Login : Form
    {
        String user;
        String password;
        UserController controller;

        public Login()
        {
            InitializeComponent();
            controller = new UserController();
        }


        //buttonLogin Click event
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            user = nameTextBox.Text;
            password = passwordTextBox.Text;

            if (user == "" || password == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }
            try
            {
                String res = controller.checkTypeOfUser(user, password);
                bool validated = false;
                int cont = 0;

                try
                {

                    if (res.Equals("Administrador"))
                    {

                        cont = 1;
                        this.Hide();
                        MessageBox.Show(
                        "Benvingut " + nameTextBox.Text + "\nT'has registrat correctament" +
                        "\n\nHo lamentem, aquesta secció està en construcció",
                        "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                        this.Close();


                    }
                    else if (res.Equals("Direccio"))
                    {

                        cont = 1;
                        this.Hide();
                        MessageBox.Show(
                        "Benvingut " + nameTextBox.Text + "\nT'has registrat correctament" +
                        "\n\nHo lamentem, aquesta secció està en construcció",
                        "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                        this.Close();

                    }
                    else if (res.Equals("PersonalSanitari"))
                    {

                        cont = 1;
                        this.Hide();
                        PersonalForm fm = new PersonalForm();
                        fm.ShowDialog();
                        validated = true;
                        this.Close();

                    }
                    else if (res.Equals("Administratiu"))
                    {

                        cont = 1;
                        this.Hide();
                        AdministratiuForm fm = new AdministratiuForm();
                        fm.ShowDialog();
                        validated = true;
                        this.Close();

                    }


                    if (validated == false)
                    {
                        if (cont == 0)
                        {

                            MessageBox.Show("Wrong password");
                            cont++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}




