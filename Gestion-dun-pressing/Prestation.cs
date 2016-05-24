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
    }
}
