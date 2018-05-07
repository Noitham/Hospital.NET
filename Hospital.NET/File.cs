using DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.NET
{
    class File
    {
        List<Pacient> ListaPacients = new List<Pacient>();
        string[] reading;
        Pacient pacient;

        public File()
        {
        }

        public List<Pacient> loadData(String ruta)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string nom = "", cognoms = "", adreça = "", poblacio = "", dni = "", nhc = "";

                        reading = line.Split(':');
                        nom = reading[0];
                        cognoms = reading[1];
                        adreça = reading[2];
                        poblacio = reading[3];
                        dni = reading[4];
                        nhc = reading[5];

                        //Creo los usuarios con los datos del fichero y los guardo en el List
                        pacient = new Pacient(nom, cognoms, adreça, poblacio, dni, nhc);
                        ListaPacients.Add(pacient);
                    }
                    sr.Close();
                    return ListaPacients;
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }

    }
}
