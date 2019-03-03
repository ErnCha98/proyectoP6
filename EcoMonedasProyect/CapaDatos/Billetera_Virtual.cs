namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Billetera_Virtual
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUsuario { get; set; }

        public int idMateriales_Encabezado { get; set; }

        public int? totalEcomonedas { get; set; }

        public int? totalEcomonedasCanjeadas { get; set; }

        public int? totalGeneradas { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
