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

        public static DataTable modifier(int id, string type, DateTime dateCreation, int prix)
        {
            string requete = string.Format("UPDATE produits SET id={0}, type='{1}', created_at='{2}', prix={3} WHERE id={0}", id, type, dateCreation, prix);
            GestionBDD.executeRequestById(requete);
            return produits();
        }

        public static DataTable supprimer(int id)
        {
            GestionBDD.deleteById(id, "produits");
            return produits();
        }
    }
}
