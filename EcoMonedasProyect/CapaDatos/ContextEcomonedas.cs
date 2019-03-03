namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextEcomonedas : DbContext
    {
        public ContextEcomonedas()
            : base("name=ContextEcomonedas")
        {
        }

        public virtual DbSet<Administradores> Administradores { get; set; }
        public virtual DbSet<Billetera_Virtual> Billetera_Virtual { get; set; }
        public virtual DbSet<Centro_Acopio> Centro_Acopio { get; set; }
        public virtual DbSet<Cupones_canje> Cupones_canje { get; set; }
        public virtual DbSet<Cupones_Enca> Cupones_Enca { get; set; }
        public virtual DbSet<Materiales> Materiales { get; set; }
        public virtual DbSet<Materiales_Detalle> Materiales_Detalle { get; set; }
        public virtual DbSet<Materiales_Encabezado> Materiales_Encabezado { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administradores>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Administradores>()
                .HasOptional(e => e.Centro_Acopio)
                .WithRequired(e => e.Administradores);

            modelBuilder.Entity<Centro_Acopio>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Centro_Acopio>()
                .Property(e => e.provincia)
                .IsUnicode(false);

            modelBuilder.Entity<Centro_Acopio>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Centro_Acopio>()
                .Property(e => e.horario)
                .IsUnicode(false);

            modelBuilder.Entity<Centro_Acopio>()
                .Property(e => e.telefono)
                .HasPrecision(12, 0);

            modelBuilder.Entity<Centro_Acopio>()
                .HasMany(e => e.Materiales_Encabezado)
                .WithRequired(e => e.Centro_Acopio)
                .HasForeignKey(e => e.idCentroAcopio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cupones_canje>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cupones_canje>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cupones_canje>()
                .HasMany(e => e.Cupones_Enca)
                .WithRequired(e => e.Cupones_canje)
                .HasForeignKey(e => e.idCupones_canje)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materiales>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Materiales>()
                .HasMany(e => e.Materiales_Detalle)
                .WithRequired(e => e.Materiales)
                .HasForeignKey(e => e.idMateriales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materiales_Encabezado>()
                .HasMany(e => e.Materiales_Detalle)
                .WithRequired(e => e.Materiales_Encabezado)
                .HasForeignKey(e => e.idMaterialesEncabezado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Administradores)
                .WithRequired(e => e.Rol)
                .HasForeignKey(e => e.idRol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.telefono)
                .HasPrecision(12, 0);

            modelBuilder.Entity<Usuarios>()
                .HasOptional(e => e.Billetera_Virtual)
                .WithRequired(e => e.Usuarios);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Cupones_Enca)
                .WithRequired(e => e.Usuarios)
                .HasForeignKey(e => e.idUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Materiales_Encabezado)
                .WithRequired(e => e.Usuarios)
                .HasForeignKey(e => e.idUsuario)
                .WillCascadeOnDelete(false);
        }
    }
}
