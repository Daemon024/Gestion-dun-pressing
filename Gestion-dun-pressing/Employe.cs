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
    }
}
