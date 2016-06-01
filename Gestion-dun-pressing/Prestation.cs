using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_dun_pressing
{
    public static class Prestation
    {
        public static DataTable prestations()
        {
            return GestionBDD.select("Prestations");
        }

        public static void ajouter(string nom, int produit_id)
        {
            string requete = string.Format("INSERT INTO Prestations VALUES(\"\", \"{0}\", \"{1}\")", nom, produit_id);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string nom, int produit_id)
        {
            string requete = string.Format("UPDATE Prestations SET id={0}, nom={1} WHERE id={0} AND produit_id={2}", id, nom, produit_id);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            GestionBDD.deleteById(id, "Prestations");
        }
    }
}
