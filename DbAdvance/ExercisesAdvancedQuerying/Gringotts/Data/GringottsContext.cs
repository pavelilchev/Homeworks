namespace Gringotts.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class GringottsContext : DbContext
    {
        public GringottsContext()
            : base("name=GringottsContext")
        {
        }

        public virtual DbSet<WizzardDeposits> WizzardDeposits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.MagicWandCreator)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.DepositGroup)
                .IsUnicode(false);

            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.DepositAmount)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.DepositInterest)
                .HasPrecision(5, 2);

            modelBuilder.Entity<WizzardDeposits>()
                .Property(e => e.DepositCharge)
                .HasPrecision(8, 2);
        }
    }
}
