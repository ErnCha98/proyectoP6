namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Materiales_Detalle
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idMaterialesEncabezado { get; set; }

        public int idMateriales { get; set; }

        public int cantidad { get; set; }

        public int precio { get; set; }

        public virtual Materiales Materiales { get; set; }

        public virtual Materiales_Encabezado Materiales_Encabezado { get; set; }
    }
}
