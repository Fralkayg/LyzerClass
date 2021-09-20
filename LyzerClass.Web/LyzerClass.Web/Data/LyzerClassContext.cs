using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LyzerClass.Web.Data
{
    public partial class LyzerClassContext : DbContext
    {
        public LyzerClassContext()
        {
        }

        public LyzerClassContext(DbContextOptions<LyzerClassContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignatura> Asignatura { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Colegio> Colegio { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Encuesta> Encuesta { get; set; }
        public virtual DbSet<HorarioAsignatura> HorarioAsignatura { get; set; }
        public virtual DbSet<TipoAsignatura> TipoAsignatura { get; set; }
        public virtual DbSet<Video> Video { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=LyzerClass;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.HasKey(e => e.Idasignatura)
                    .IsClustered(false);

                entity.ToTable("ASIGNATURA");

                entity.HasIndex(e => e.Idcurso)
                    .HasName("CURSO_TIENE_ASIGNATURA_FK");

                entity.HasIndex(e => e.Iddocente)
                    .HasName("DOCENTE_DICTA_ASIGNATURA_FK");

                entity.HasIndex(e => e.Idtipoasignatura)
                    .HasName("ASIGNATURA_TIENE_TIPO_FK");

                entity.Property(e => e.Idasignatura).HasColumnName("IDASIGNATURA");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idcurso).HasColumnName("IDCURSO");

                entity.Property(e => e.Iddocente).HasColumnName("IDDOCENTE");

                entity.Property(e => e.Idtipoasignatura).HasColumnName("IDTIPOASIGNATURA");

                entity.HasOne(d => d.IdcursoNavigation)
                    .WithMany(p => p.Asignatura)
                    .HasForeignKey(d => d.Idcurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIGNATU_CURSO_TIE_CURSO");

                entity.HasOne(d => d.IddocenteNavigation)
                    .WithMany(p => p.Asignatura)
                    .HasForeignKey(d => d.Iddocente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIGNATU_DOCENTE_D_DOCENTE");

                entity.HasOne(d => d.IdtipoasignaturaNavigation)
                    .WithMany(p => p.Asignatura)
                    .HasForeignKey(d => d.Idtipoasignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIGNATU_ASIGNATUR_TIPO_ASI");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Colegio>(entity =>
            {
                entity.HasKey(e => e.Idcolegio)
                    .IsClustered(false);

                entity.ToTable("COLEGIO");

                entity.Property(e => e.Idcolegio).HasColumnName("IDCOLEGIO");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Idcurso)
                    .IsClustered(false);

                entity.ToTable("CURSO");

                entity.HasIndex(e => e.Idcolegio)
                    .HasName("COLEGIO_TIENE_CURSO_FK");

                entity.Property(e => e.Idcurso).HasColumnName("IDCURSO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idcolegio).HasColumnName("IDCOLEGIO");

                entity.Property(e => e.Paralelo)
                    .IsRequired()
                    .HasColumnName("PARALELO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcolegioNavigation)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.Idcolegio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CURSO_COLEGIO_T_COLEGIO");
            });

            modelBuilder.Entity<Director>(entity =>
            {
                entity.HasKey(e => e.Iddirector)
                    .IsClustered(false);

                entity.ToTable("DIRECTOR");

                entity.HasIndex(e => e.Idcolegio)
                    .HasName("DIRECTOR_PERTENECE_A_COLEGIO_FK");

                entity.Property(e => e.Iddirector).HasColumnName("IDDIRECTOR");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("CORREO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idcolegio).HasColumnName("IDCOLEGIO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcolegioNavigation)
                    .WithMany(p => p.Director)
                    .HasForeignKey(d => d.Idcolegio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIRECTOR_DIRECTOR__COLEGIO");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.Iddocente)
                    .IsClustered(false);

                entity.ToTable("DOCENTE");

                entity.HasIndex(e => e.Idcolegio)
                    .HasName("COLEGIO_TIENE_DOCENTE_FK");

                entity.Property(e => e.Iddocente).HasColumnName("IDDOCENTE");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("CORREO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fechanacimiento)
                    .HasColumnName("FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idcolegio).HasColumnName("IDCOLEGIO");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rut)
                    .IsRequired()
                    .HasColumnName("RUT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcolegioNavigation)
                    .WithMany(p => p.Docente)
                    .HasForeignKey(d => d.Idcolegio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCENTE_COLEGIO_T_COLEGIO");
            });

            modelBuilder.Entity<Encuesta>(entity =>
            {
                entity.HasKey(e => e.Idencuesta)
                    .IsClustered(false);

                entity.ToTable("ENCUESTA");

                entity.HasIndex(e => e.Idvideo)
                    .HasName("VIDEO_TIENE_ENCUESTA2_FK");

                entity.Property(e => e.Idencuesta).HasColumnName("IDENCUESTA");

                entity.Property(e => e.Idvideo).HasColumnName("IDVIDEO");

                entity.Property(e => e.Puntaje).HasColumnName("PUNTAJE");

                entity.HasOne(d => d.IdvideoNavigation)
                    .WithMany(p => p.Encuesta)
                    .HasForeignKey(d => d.Idvideo)
                    .HasConstraintName("FK_ENCUESTA_VIDEO_TIE_VIDEO");
            });

            modelBuilder.Entity<HorarioAsignatura>(entity =>
            {
                entity.HasKey(e => e.Idhorarioasignatura)
                    .IsClustered(false);

                entity.ToTable("HORARIO_ASIGNATURA");

                entity.HasIndex(e => e.Idasignatura)
                    .HasName("ASIGNATURA_TIENE_HORARIO_FK");

                entity.Property(e => e.Idhorarioasignatura).HasColumnName("IDHORARIOASIGNATURA");

                entity.Property(e => e.Dia)
                    .IsRequired()
                    .HasColumnName("DIA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hora)
                    .HasColumnName("HORA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idasignatura).HasColumnName("IDASIGNATURA");

                entity.HasOne(d => d.IdasignaturaNavigation)
                    .WithMany(p => p.HorarioAsignatura)
                    .HasForeignKey(d => d.Idasignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HORARIO__ASIGNATUR_ASIGNATU");
            });

            modelBuilder.Entity<TipoAsignatura>(entity =>
            {
                entity.HasKey(e => e.Idtipoasignatura)
                    .IsClustered(false);

                entity.ToTable("TIPO_ASIGNATURA");

                entity.Property(e => e.Idtipoasignatura).HasColumnName("IDTIPOASIGNATURA");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasKey(e => e.Idvideo)
                    .IsClustered(false);

                entity.ToTable("VIDEO");

                entity.HasIndex(e => e.Idencuesta)
                    .HasName("VIDEO_TIENE_ENCUESTA_FK");

                entity.HasIndex(e => e.Idhorarioasignatura)
                    .HasName("CLASE_TIENE_VIDEO_FK");

                entity.Property(e => e.Idvideo).HasColumnName("IDVIDEO");

                entity.Property(e => e.Comentariodirector)
                    .HasColumnName("COMENTARIODIRECTOR")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comentariodocente)
                    .HasColumnName("COMENTARIODOCENTE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Conclusion).HasColumnName("CONCLUSION");

                entity.Property(e => e.Desarrollo).HasColumnName("DESARROLLO");

                entity.Property(e => e.Dudas).HasColumnName("DUDAS");

                entity.Property(e => e.Idencuesta).HasColumnName("IDENCUESTA");

                entity.Property(e => e.Idhorarioasignatura).HasColumnName("IDHORARIOASIGNATURA");

                entity.Property(e => e.Introduccion).HasColumnName("INTRODUCCION");

                entity.Property(e => e.Tiempo).HasColumnName("TIEMPO");

                entity.Property(e => e.Tiemposinsilencios).HasColumnName("TIEMPOSINSILENCIOS");

                entity.Property(e => e.Tonalidad).HasColumnName("TONALIDAD");

                entity.Property(e => e.Velocidad).HasColumnName("VELOCIDAD");

                entity.Property(e => e.Volumen).HasColumnName("VOLUMEN");

                entity.HasOne(d => d.IdencuestaNavigation)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.Idencuesta)
                    .HasConstraintName("FK_VIDEO_VIDEO_TIE_ENCUESTA");

                entity.HasOne(d => d.IdhorarioasignaturaNavigation)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.Idhorarioasignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIDEO_CLASE_TIE_HORARIO_");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
