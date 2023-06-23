using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


#nullable disable

namespace Storage
{
    public partial class datingsiteContext : DbContext
    {
        public datingsiteContext()
        {
        }

        public datingsiteContext(DbContextOptions<datingsiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Profil> Profils { get; set; }
        public virtual DbSet<Rejection> Rejections { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;uid=root;pwd=root;database=datingsite", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Profil>(entity =>
            {
                entity.ToTable("profil");

                entity.HasIndex(e => e.IdUser, "user_idx");

                entity.Property(e => e.Email).HasMaxLength(45);

                entity.Property(e => e.Imie).HasMaxLength(45);

                entity.Property(e => e.Nazwisko).HasMaxLength(45);

                entity.Property(e => e.Photo).HasColumnType("blob");

                entity.Property(e => e.Telefon).HasMaxLength(45);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Profils)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user");
            });

            modelBuilder.Entity<Rejection>(entity =>
            {
                entity.ToTable("rejections");

                entity.HasIndex(e => e.Rejected, "drgdrg_idx");

                entity.HasIndex(e => e.Rejectee, "esrgsd_idx");

                entity.HasOne(d => d.RejectedNavigation)
                    .WithMany(p => p.RejectionRejectedNavigations)
                    .HasForeignKey(d => d.Rejected)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("drgdrg");

                entity.HasOne(d => d.RejecteeNavigation)
                    .WithMany(p => p.RejectionRejecteeNavigations)
                    .HasForeignKey(d => d.Rejectee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("esrgsd");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Haslo).HasMaxLength(45);

                entity.Property(e => e.Login).HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
