namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Materiales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materiales()
        {
            Materiales_Detalle = new HashSet<Materiales_Detalle>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string nombre { get; set; }

        public string ImagenPath { get; set; }

        public int? precio { get; set; }

        public int? color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materiales_Detalle> Materiales_Detalle { get; set; }
    }
}
