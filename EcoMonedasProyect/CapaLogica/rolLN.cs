
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CapaDatos;

namespace CapaLogica
{
   public class rolLN
    {
        public static IQueryable ListaRoles()
        {
            var db = new ContextEcomonedas();
            IQueryable query = db.Rol;
            return query;
        }
    }
}
