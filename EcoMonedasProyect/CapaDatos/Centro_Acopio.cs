namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Centro_Acopio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Centro_Acopio()
        {
            Materiales_Encabezado = new HashSet<Materiales_Encabezado>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idAdministrador { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        [StringLength(12)]
        public string provincia { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [StringLength(20)]
        public string horario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? telefono { get; set; }

        public int? estado { get; set; }

        public virtual Administradores Administradores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materiales_Encabezado> Materiales_Encabezado { get; set; }
    }
}
