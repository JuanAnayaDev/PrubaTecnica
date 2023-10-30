using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PruebaTecnicaV2.Models.DB
{
    public partial class PruebaTecnicaDBContext : DbContext
    {
        public PruebaTecnicaDBContext()
        {
        }

        public PruebaTecnicaDBContext(DbContextOptions<PruebaTecnicaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidateexperiences> candidateexperiences { get; set; }
        public virtual DbSet<Candidates> candidates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                var config = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = config.GetConnectionString("DatabaseConnectionString");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidateexperiences>(entity =>
            {
                entity.HasKey(e => e.IdCandidateExperience)
                    .HasName("PK__candidat__D9A60D657BD575CD");

                entity.ToTable("candidateexperiences");

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Salary).HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.IdCandidateNavigation)
                    .WithMany(p => p.Candidateexperiences)
                    .HasForeignKey(d => d.IdCandidate)
                    .HasConstraintName("FK__candidate__Modif__3A81B327");
            });

            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.HasKey(e => e.IdCandidate)
                    .HasName("PK__candidat__D5598973D61F13DF");

                entity.ToTable("candidates");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__candidat__A9D10534EE05F72E")
                    .IsUnique();

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
