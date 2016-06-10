using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_dun_pressing
{
    public static class Commande
    {
        public static DataTable commandes()
        {
            return GestionBDD.selectPerso("CALL recuperer_commandes()");
        }

        public static void ajouter(string commentaire, string dateCreation, string dateDepot, string dateRecuperation, int pretRecuperation, int prestation, int client, int employe)
        {
            string requete = string.Format("INSERT INTO Commandes VALUES(\"\", \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\")", commentaire, dateCreation, dateDepot, dateRecuperation, pretRecuperation, prestation, client, employe);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string commentaire, string dateCreation, string dateDepot, string dateRecuperation, int pretRecuperation)
        {
            string requete = string.Format("UPDATE Commandes SET id={0}, commentaire='{1}', dateCreation='{2}', dateDepot='{3}', dateRecuperation='{4}', pretPourRecuperation='{5}' WHERE id='{0}'", id, commentaire, dateCreation, dateDepot, dateRecuperation, pretRecuperation);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            string requete = string.Format("DELETE FROM Commandes WHERE id='{0}', prestations_id='{1}'", id);
            GestionBDD.executeRequest(requete);
        }
    }
}
