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
            return GestionBDD.select("employes");
        }

        public static void ajouter(string nom, string prenom, string motDePasse, string dateArrivee, string typeContrat, int salaire)
        {
            string requete = string.Format("INSERT INTO employes VALUES(\"\", \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\")", nom, prenom, motDePasse, dateArrivee, typeContrat, salaire);
            GestionBDD.executeRequest(requete);
        }

        public static void modifier(int id, string nom, string prenom, string motDePasse, string typeContrat, int salaire)
        {
            string requete = string.Format("UPDATE employes SET id={0}, nomEmploye='{1}', prenomEmploye='{2}', password='{3}', typeContrat='{4}', salaire='{5}' WHERE id={0}", id, nom, prenom, motDePasse, typeContrat, salaire);
            GestionBDD.executeRequest(requete);
        }

        public static void supprimer(int id)
        {
            GestionBDD.deleteById(id, "employes");
        }
    }
}
