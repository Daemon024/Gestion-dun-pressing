using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_dun_pressing
{
    public static class Employe
    {
        public static DataTable employes()
        {
            return GestionBDD.select("Employes");
        }

        public static void ajouter(string nom, string prenom, string dateArrivee, string typeContrat, int salaire)
        {
            string requete = string.Format("INSERT INTO Employes VALUES(\"\", \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\")", nom, prenom, dateArrivee, typeContrat, salaire);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string nom, string prenom, string typeContrat, int salaire)
        {
            string requete = string.Format("UPDATE Employes SET id={0}, nomEmploye='{1}', prenomEmploye='{2}', typeContrat='{3}', salaire='{4}' WHERE id={0}", id, nom, prenom, typeContrat, salaire);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            GestionBDD.deleteById(id, "Employes");
        }
    }
}
