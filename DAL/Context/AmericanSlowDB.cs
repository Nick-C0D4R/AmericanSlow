using System.Data.Entity;
using DAL.Models;

namespace DAL.Context
{
    public partial class AmericanSlowDB : DbContext
    {
        public AmericanSlowDB()
            : base("name=AmericanSlowDB")
        {
        }

        public virtual DbSet<BankTransaction> BankTransaction { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankTransaction>()
                .Property(e => e.TransactionSum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Client>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.BankTransaction)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientType>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.ClientType1)
                .HasForeignKey(e => e.ClientType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionType>()
                .HasMany(e => e.BankTransaction)
                .WithRequired(e => e.TransactionType1)
                .HasForeignKey(e => e.TransactionType)
                .WillCascadeOnDelete(false);
        }
    }
}
