using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_dun_pressing
{
    public static class Produit
    {
        public static DataTable produits()
        {
            return GestionBDD.select("Produits");
        }

        public static void ajouter(string nom)
        {
            string requete = string.Format("INSERT INTO Produits VALUES(\"\", \"{0}\")", nom);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string nom)
        {
            string requete = string.Format("UPDATE Produits SET id={0}, nom='{1}' WHERE id={0}", id, nom);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            GestionBDD.deleteById(id, "Produits");
        }
    }
}
