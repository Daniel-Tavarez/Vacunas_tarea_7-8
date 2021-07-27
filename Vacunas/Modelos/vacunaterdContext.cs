using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vacunas.Modelos
{
    public partial class vacunaterdContext : DbContext
    {
        public vacunaterdContext()
        {
        }

        public vacunaterdContext(DbContextOptions<vacunaterdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dosis> Dosis { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<VacunasClase> VacunasClase { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;uid=root;pwd=mysql;database=vacunaterd;convert zero datetime=True", x => x.ServerVersion("10.4.19-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dosis>(entity =>
            {
                entity.ToTable("dosis");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CedulaPersona)
                    .IsRequired()
                    .HasColumnName("Cedula_persona")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.ProvinciaId)
                    .HasColumnName("Provincia_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VacunaId)
                    .HasColumnName("Vacuna_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PRIMARY");

                entity.ToTable("personas");

                entity.Property(e => e.Cedula)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ProvinciaId)
                    .HasColumnName("Provincia_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.ToTable("provincias");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<VacunasClase>(entity =>
            {
                entity.ToTable("vacunas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DiasEntreDosis)
                    .HasColumnName("Dias_entre_dosis")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DosisNecesarias)
                    .HasColumnName("Dosis_necesarias")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
