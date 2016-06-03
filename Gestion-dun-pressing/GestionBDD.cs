using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gestion_dun_pressing
{
    public static class GestionBDD
    {
        #region Propriétés
        private static string connexionString = "SERVER=pressingdeshalles.fr; DATABASE=bddE4; UID=admin; PASSWORD=admin134459; CONVERT ZERO DATETIME=True";
        private static MySqlConnection cnx = new MySqlConnection(connexionString);
        private static MySqlCommand cmd = new MySqlCommand();
        #endregion

        #region Méthodes et fonctions

        #region Connexion
        public static void connexion()
        {
            try // S'il n'y a pas d'erreur on se connecte et on affiche le message de réussite
            {
                cnx.Open();
            }
            catch (Exception ex) // S'il y a une erreur, on affiche l'erreur et on quitte l'application
            {
                MessageBox.Show("Connexion échouée, plus d'informations : \n" + ex);
                Environment.Exit(1);
            }
        }
        #endregion

        #region Déconnexion
        public static void deconnexion()
        {
            try // S'il n'y a pas d'erreur on se déconnecte et on affiche le message de réussite
            {
                cnx.Close();
                MessageBox.Show("Déconnexion réussie");
            }
            catch (Exception ex) // S'il y a une erreur, on affiche l'erreur et on quitte l'application
            {
                MessageBox.Show("Déconnexion impossible, plus d'information : \n" + ex);
                Environment.Exit(1);
            }
        }
        #endregion

        #region Select
        public static DataTable select(string table)
        {
            string requete = "SELECT * FROM " + table; // On crée notre requete
            DataTable mesDonnees = new DataTable(); // On crée notre dataTable qui contiendra les donnéees
            MySqlDataAdapter adapter = new MySqlDataAdapter(requete, connexionString); // On crée un Adapter
            adapter.Fill(mesDonnees); // On fait passer les données dans le dataTable

            return mesDonnees;
        }
        #endregion

        #region Select Perso
        public static DataTable selectPerso(string requete)
        {
            DataTable mesDonnees = new DataTable(); // On crée notre dataTable qui contiendra les donnéees

            MySqlDataAdapter adapter = new MySqlDataAdapter(requete, connexionString); // On crée un Adapter
            adapter.Fill(mesDonnees); // On fait passer les données dans le dataTable

            return mesDonnees;
        }
        #endregion

        #region Request
        public static void executeRequest(string requete)
        {
            cmd = new MySqlCommand(requete, cnx); // On crée notre commande MySQL
            try
            {
                cmd.ExecuteNonQuery(); // On exécute notre commande MySQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite, plus d'information :\n" + ex);
            }
        }
        #endregion

        #region Delete By ID
        public static void deleteById(int id, string table)
        {
            string requete = "DELETE FROM " + table + " WHERE id=" + Convert.ToString(id); // On crée notre requete
            cmd = new MySqlCommand(requete, cnx); // On crée notre commande MySQL
            try
            {
                cmd.ExecuteNonQuery(); // On exécute notre commande MySQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite, pour plus d'information :\n" + ex);
            }
        }
        #endregion

        #endregion
    }
}
