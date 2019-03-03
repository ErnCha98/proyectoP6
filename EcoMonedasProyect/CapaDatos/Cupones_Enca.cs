namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cupones_Enca
    {
        public int id { get; set; }

        public int idCupones_canje { get; set; }

        public int idUsuario { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime fecha { get; set; }

        public int? total { get; set; }

        public int? estado { get; set; }

        public virtual Cupones_canje Cupones_canje { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
