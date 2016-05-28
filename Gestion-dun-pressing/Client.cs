using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_dun_pressing
{
    public static class Client
    {
        public static DataTable clients()
        {
            return GestionBDD.select("clients");
        }

        public static void ajouter(int id, string nom, string prenom, string adresse, string codePostal, string ville, string email, string dateCreation, string tel, string motDePasse, string token, string dateModification)
        {
            string requete = string.Format("INSERT INTO clients VALUES({0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", \"{10}\", \"{11}\")", id, nom, prenom, adresse, codePostal, ville, email, dateCreation, tel, motDePasse, token, dateModification);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string nom, string prenom, string adresse, string codePostal, string ville, string email, string dateCreation, string tel, string motDePasse, string token, string dateModification)
        {
            string requete = string.Format("UPDATE clients SET id={0}, nom='{1}', prenom='{2}', adresse='{3}', codepostal='{4}', ville='{5}', email='{6}', created_at='{7}', tel='{8}', password='{9}', remember_token='{10}', updated_at='{11}' WHERE id={0}", id, nom, prenom, adresse, codePostal, ville, email, dateCreation, tel, motDePasse, token, dateModification);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            GestionBDD.deleteById(id, "clients");
        }
    }
}
