using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ASI.Basecode.Data.Models;
using System.Threading.Tasks;
using System.Threading;

namespace ASI.Basecode.Data
{
    public partial class AyohaDbContext : DbContext
    {
        public AyohaDbContext()
        {
        }

        public AyohaDbContext(DbContextOptions<AyohaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleTag> ArticleTags { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketAgentAssignment> TicketAgentAssignments { get; set; }
        public virtual DbSet<TicketAgentFeedback> TicketAgentFeedbacks { get; set; }
        public virtual DbSet<TicketAttachment> TicketAttachments { get; set; }
        public virtual DbSet<TicketReminder> TicketReminders { get; set; }
        public virtual DbSet<TicketUpdate> TicketUpdates { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-IK9CJIE\\SQLEXPRESS; Database=AyohaDb; Trusted_Connection=True; MultipleActiveResultSets=true;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(80);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ArticleTag>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.Tag });

                entity.Property(e => e.Tag).HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alias).HasMaxLength(30);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TicketAgentAssignment>(entity =>
            {
                entity.HasIndex(e => new { e.TicketId, e.UserId }, "IX_TicketId_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssignedOn).HasColumnType("datetime");

                entity.Property(e => e.RemovedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TicketAgentFeedback>(entity =>
            {
                entity.ToTable("TicketAgentFeedback");

                entity.HasIndex(e => new { e.TicketId, e.AgentId }, "IX_TicketAgentFeedback_TicketIdAgentId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TicketAttachment>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_TicketAttachments_TicketId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TicketReminder>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_TicketReminders_TicketIdUserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TicketUpdate>(entity =>
            {
                entity.HasIndex(e => e.TicketId, "IX_TicketAssignments_TicketId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
