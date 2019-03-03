namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Materiales_Encabezado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materiales_Encabezado()
        {
            Materiales_Detalle = new HashSet<Materiales_Detalle>();
        }

        public int id { get; set; }

        public int idCentroAcopio { get; set; }

        public int idUsuario { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime fecha { get; set; }

        public int? total { get; set; }

        public virtual Centro_Acopio Centro_Acopio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materiales_Detalle> Materiales_Detalle { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
