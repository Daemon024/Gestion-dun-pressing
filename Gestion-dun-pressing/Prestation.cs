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
            return GestionBDD.select("prestations");
        }

        public static void ajouter(int id, string commentaire, string dateDepot, string dateRecuperation)
        {
            string requete = string.Format("INSERT INTO prestations VALUES({0}, \"{1}\", \"{2}\", \"{3}\")", id, commentaire, dateDepot, dateRecuperation);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string commentaire, string dateDepot, string dateRecuperation)
        {
            string requete = string.Format("UPDATE prestations SET id={0}, commentaire={1}, dateDepot='{2}', dateRecuperation='{3}' WHERE id={0}", id, commentaire, dateDepot, dateRecuperation);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            GestionBDD.deleteById(id, "prestations");
        }
    }
}
