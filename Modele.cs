using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    class Modele
    {
        private MySqlConnection myConnection; // objet de connexion 
        private bool connopen = false; // test si la connexion est faite 
        private bool chargement = false; // test si le chargement d'une requête est fait 
                                         // collection de DataAdapter
        private List<MySqlDataAdapter> dA = new List<MySqlDataAdapter>();

        // collection de DataTable récupérant les données correspond au DA associé
        private List<DataTable> dT = new List<DataTable>();
        public List<MySqlDataAdapter> DA
        {
            get { return dA; }
            set { dA = value; }
        }

        /// <summary>
        /// Accesseur de la collection des DataTable
        /// </summary>
        public List<DataTable> DT
        {
            get { return dT; }
            set { dT = value; }
        }
        public Modele()
        {
            // instanciation des collections des Datatable et DataAdapter
            for (int i = 0; i < 7; i++)
            {
                dA.Add(new MySqlDataAdapter());
                dT.Add(new DataTable());
            }
        }

        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }

        /// <summary>         
        /// Méthode pour se connecter à la BD         
        /// </summary> 
        public void seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD 
            string myConnectionString = "Database=2021_slamBDD31;Data Source=192.168.10.70;User Id=2021_slamBDD31; Password = P@ssw0rd;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative   
            { myConnection.Open(); connopen = true; }
            catch (Exception err)// gestion des erreurs             
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }
        /// <summary>        
        /// Méthode pour se déconnecter de la BD         
        /// </summary>   
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
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>        
        /// Méthode pout charger les données issues d'une requête dans un dataTable        
        /// </summary>        
        /// <param name="requete"></param>        
        /// <param name="DT"></param>   
        private void charger(string requete, DataTable DT, MySqlDataAdapter DA)
        {
            DA.SelectCommand = new MySqlCommand(requete, myConnection);

            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(DA);
            try
            {
                DT.Clear();
                DA.Fill(DT);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable : " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// Méthode qui permet d'ajouter un avatar avec son nom et son age 
        /// </summary> 
        /// <param name="n">nom</param>       
        /// <param name="a">age</param>         
        /// <returns></returns>   
        public void charger_donnees(string table)
        {
            chargement = false;
            if (!connopen) return;      // pour vérifier que la BD est bien ouverte
                                        // charger plusieurs tables pour afficher dans le data table vus

            if (table == "toutes")
            {
                charger("show tables;", dT[0], dA[0]);
            }

            if (table == "SLAM3_TP2_UILISATEUR")
            {
                charger("select * from SLAM3_TP2_UILISATEUR;", dT[1], dA[1]);
            }
            if (table == "SLAM3_TP2_THEME")
            {
                charger("select * from SLAM3_TP2_THEME;", dT[2], dA[2]);
            }
            if (table == "SLAM3_TP2_QCM")
            {
                charger("select * from SLAM3_TP2_QCM;", dT[3], dA[3]);
            }
            if(table == "SLAM3_TP2_QUESTIONS")
            {
                charger("select * from SLAM3_TP2_QUESTIONS;", dT[4], dA[4]);
            }
            if (table == "SLAM3_TP2_REPONSEQUESTION")
            {
                charger("select * from SLAM3_TP2_REPONSEQUESTION;", dT[5], dA[5]);
            }
            if (table == "SLAM3_TP2_REPONSEUTILISATEUR")
            {
                charger("select * from SLAM3_TP2_REPONSEUTILISATEUR;", dT[6], dA[6]);
            }

        }
    }


}