using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace muratkale.Data.EFModelContext
{
    public partial class EFContext : DbContext
    {
        public virtual DbSet<ArticleStickerNew> ArticleStickerNew { get; set; }
        public virtual DbSet<Sticker> Sticker { get; set; }
        public virtual DbSet<StickerInsert> StickerInsert { get; set; }
        public virtual DbSet<StickerInsertApi> StickerInsertApi { get; set; }
        public virtual DbSet<StickerVaryant> StickerVaryant { get; set; }
        public virtual DbSet<XmlStickersNew> XmlStickersNew { get; set; }
        public virtual DbSet<XmlStickerVaryantsNew> XmlStickerVaryantsNew { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sticker>(entity =>
            {
                entity.HasIndex(e => new { e.StickerNameNonTrChar, e.IsDeleted, e.IsSiteWideDisabled })
                    .HasName("IX_Sticker_All");

                entity.Property(e => e.ClickLink).IsUnicode(false);

                entity.Property(e => e.StickerName).IsUnicode(false);

                entity.Property(e => e.StickerNameNonTrChar).IsUnicode(false);
            });

            modelBuilder.Entity<XmlStickersNew>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.H1).IsUnicode(false);

                entity.Property(e => e.StickerNameNonTrChar).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.Topic).IsUnicode(false);
            });

            modelBuilder.Entity<XmlStickerVaryantsNew>(entity =>
            {
                entity.Property(e => e.VaryantName).IsUnicode(false);

                entity.Property(e => e.VaryantUrl).IsUnicode(false);
            });
        }
    }
}
