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

        public static DataTable modifier(int id, string type, DateTime dateCreation)
        {
            string requete = string.Format("UPDATE produits SET id={0}, type='{1}', created_at='{2}' WHERE id={0}", id, type, dateCreation);
            GestionBDD.editById(requete);
            return produits();
        }

        public static DataTable supprimer(int id)
        {
            GestionBDD.deleteById(id, "produits");
            return produits();
        }
    }
}
