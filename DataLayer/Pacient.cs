using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Pacient
    {
        private int id_pacient;
        private string nom, cognoms, adreça, poblacio, dni, nhc;

        public Pacient(int id_pacient, string nom, string cognoms, string adreça, string poblacio, string dni, string nhc)
        {
            this.id_pacient = id_pacient;
            this.nom = nom;
            this.cognoms = cognoms;
            this.adreça = adreça;
            this.poblacio = poblacio;
            this.dni = dni;
            this.nhc = nhc;
        }

        public Pacient(string nom, string cognoms, string adreça, string poblacio, string dni, string nhc)
        {
            this.nom = nom;
            this.cognoms = cognoms;
            this.adreça = adreça;
            this.poblacio = poblacio;
            this.dni = dni;
            this.nhc = nhc;
        }


        public int Id_pacient
        {
            get
            {
                return id_pacient;
            }

            set
            {
                id_pacient = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Cognoms
        {
            get
            {
                return cognoms;
            }

            set
            {
                cognoms = value;
            }
        }

        public string Adreça
        {
            get
            {
                return adreça;
            }

            set
            {
                adreça = value;
            }
        }

        public string Poblacio
        {
            get
            {
                return poblacio;
            }

            set
            {
                poblacio = value;
            }
        }

        public string DNI
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string NHC
        {
            get
            {
                return nhc;
            }

            set
            {
                nhc = value;
            }
        }

    }
}
