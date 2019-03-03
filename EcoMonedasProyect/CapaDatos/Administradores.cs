namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administradores
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(20)]
        public string contrasena { get; set; }

        public int idRol { get; set; }

        public int? estado { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Centro_Acopio Centro_Acopio { get; set; }
    }
}
