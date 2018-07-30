namespace EntityFrameworkPart2CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Quarks : DbContext
    {
        public Quarks()
            : base("name=Quarks")
        {
        }

        public virtual DbSet<CUSTOMER> CUSTOMERS { get; set; }
        public virtual DbSet<TRANSACTION> TRANSACTIONS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.LAST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_AMOUNT)
                .HasPrecision(19, 4)
                .HasColumnType("money");

            modelBuilder.Entity<TRANSACTION>()
                .HasKey(e => e.TRANSACTION_ID);
        }
    }
}
