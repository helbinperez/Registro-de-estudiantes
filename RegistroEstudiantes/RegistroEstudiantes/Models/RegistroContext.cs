using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegistroEstudiantes.Models
{
    public partial class RegistroContext : DbContext
    {
        public RegistroContext()
        {
        }

        public RegistroContext(DbContextOptions<RegistroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RSFHOUK\\SQLEXPRESS;Initial Catalog=Registro;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.IdEstudiante)
                    .HasName("PK__Estudian__BE32832D19C69EEA");

                entity.Property(e => e.IdEstudiante)
                    .HasColumnName("Id_estudiante")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Carrera)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
