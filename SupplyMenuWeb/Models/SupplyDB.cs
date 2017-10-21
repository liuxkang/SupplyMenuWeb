namespace SupplyMenuWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SupplyDB : DbContext
    {
        public SupplyDB()
            : base("name=SupplyDB")
        {
        }

        public virtual DbSet<Supply> Supplies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supply>()
                .Property(e => e.SupplyName)
                .IsFixedLength();

            modelBuilder.Entity<Supply>()
                .Property(e => e.SupplyType)
                .IsFixedLength();

            modelBuilder.Entity<Supply>()
                .Property(e => e.Dw)
                .IsFixedLength();

            modelBuilder.Entity<Supply>()
                .Property(e => e.Remarks)
                .IsFixedLength();
        }
    }
}
