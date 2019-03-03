namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            Cupones_Enca = new HashSet<Cupones_Enca>();
            Materiales_Encabezado = new HashSet<Materiales_Encabezado>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        public DateTime? fechaNacimiento { get; set; }

        [StringLength(10)]
        public string contrasena { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? telefono { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? estado { get; set; }

        public virtual Billetera_Virtual Billetera_Virtual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cupones_Enca> Cupones_Enca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materiales_Encabezado> Materiales_Encabezado { get; set; }
    }
}
