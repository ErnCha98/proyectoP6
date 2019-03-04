
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class administradoresLN
    {

        public static IQueryable ListaAdministradores()
        {
            var db = new ContextEcomonedas();
            IQueryable query = db.Administradores;
            return query;
        }
        public bool AgregarAdmistrador(string nombre,
           string idRol,
           int estado,
           string contrasena ,
           string id = ""
          )
        {
            ContextEcomonedas db = new ContextEcomonedas();
            var miElemento = new Administradores();
            int idElemento = 0;
            bool esNumero = int.TryParse(id, out idElemento);

            if (esNumero || idElemento > 0)
            {
                // Buscar Elemento en la BD
                miElemento = db.Administradores.
                    Where(p => p.id == idElemento).
                    First<Administradores>();

            }
            miElemento.nombre = nombre;
            miElemento.idRol = Convert.ToInt32(idRol);
            miElemento.contrasena = contrasena;
            miElemento.estado = estado;

            if (id.Equals("") || !esNumero)
            { // Agregar Elemento a la BD
                db.Administradores.Add(miElemento);

            }
            db.SaveChanges();

            // Confirmar acción
            return true;
        }
        public static Administradores obtenerAdministrador(int id)
        {
            ContextEcomonedas db = new ContextEcomonedas();
            Administradores prod = db.Administradores.
                    Where(p => p.id == id).
                    First<Administradores>();
            return prod;
        }
    }
}
