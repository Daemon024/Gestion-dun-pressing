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
            return GestionBDD.select("produits");
        }

        public static void ajouter(int id, string type, string dateCreation)
        {
            string requete = string.Format("INSERT INTO produits VALUES({0}, \"{1}\", \"{2}\")", id, type, dateCreation);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string type)
        {
            string requete = string.Format("UPDATE produits SET id={0}, type='{1}' WHERE id={0}", id, type);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            GestionBDD.deleteById(id, "produits");
        }
    }
}
