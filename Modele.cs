using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace QCM
{
    public class Modele
    {
        private MySqlConnection myConnection;// objet de connexion
        private bool connopen = false;// test si la connexion est faite
        private bool chargement = false;// test si le chargement d'une requête est fait
        public Modele()
        {

        }
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public DataTable DT1 { get => dT1; set => dT1 = value; }
        public DataTable DT2 { get => dT1; set => dT1 = value; }

        ///<summary>
        /// Méthode pour se connecter à la BD
        ///</summary>
        public void seconnecter()
        {
            //paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Database=2021_slamBDD24;Data Source=192.168.10.70;UserID=2021_slamBDD24; Password=P@ssw0rd;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd :" + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }
        ///<summary>
        /// Méthode pour se déconnecter de la BD
        ///</summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd:" + err, "PBS déconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private DataTable dT1 = new DataTable();
        /// <summary>
        /// Méthode pour charger les données issues d'une requête dans un dataTable
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="DT1"></param>

        private DataTable dT2 = new DataTable();
        /// <summary>
        /// Méthode pour charger les données issues d'une requête dans un dataTable
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="DT2"></param>
        public void charger(string requete, DataTable dT1)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;

            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT1.Load(reader);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement DataTable:" + err, "Problemes table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }

        }
        public void charger_donnees(string table)
        {
            if (table == "SLAM3_TP2_UTILISATEUR") charger("select * from SLAM3_TP2_UTILISATEUR;", dT1);
            if (table == "SLAM3_TP2_ADMINISTRATEUR") charger("select * from SLAM3_TP2_ADMINISTRATEUR;", dT2);

        }

    }
}