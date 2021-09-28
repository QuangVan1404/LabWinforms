using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Phim.DB
{
    public partial class PHIMMODEL : DbContext
    {
        public PHIMMODEL()
            : base("name=PHIMMODEL")
        {
        }

        public virtual DbSet<LOAIPHIM> LOAIPHIMs { get; set; }
        public virtual DbSet<PHIM> PHIMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOAIPHIM>()
                .Property(e => e.MaLP)
                .IsUnicode(false);

            modelBuilder.Entity<PHIM>()
                .Property(e => e.MaPH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIM>()
                .Property(e => e.MaLP)
                .IsUnicode(false);
        }
    }
}
