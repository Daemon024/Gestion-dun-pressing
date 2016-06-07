using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_dun_pressing
{
    public static class Tarif
    {
        public static DataTable tarifs()
        {
            return GestionBDD.selectPerso("CALL recuperer_tarifs()");
        }

        public static void ajouter(int tarif, int produits_id, int prestations_id)
        {
            string requete = string.Format("INSERT INTO Tarifs VALUES(\"{0}\", \"{1}\", \"{2}\")", tarif, produits_id, prestations_id);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int tarif, int produits_id, int prestations_id)
        {
            string requete = string.Format("UPDATE Tarifs SET tarif={0}, produits_id='{1}', prestations_id='{2}' WHERE produits_id='{1}', prestations_id='{2}'", tarif, produits_id, prestations_id);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int produits_id, int prestations_id)
        {
            string requete = string.Format("DELETE FROM Tarifs WHERE produits_id='{0}', prestations_id='{1}'", produits_id, prestations_id);
            GestionBDD.executeRequest(requete);
        }
    }
}
