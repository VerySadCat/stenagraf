namespace Lab_IBZI_4
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<STATUSES> STATUSES { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<STATUSES>()
                .Property(e => e.nameStat)
                .IsFixedLength();

            modelBuilder.Entity<STATUSES>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.STATUSES)
                .WillCascadeOnDelete(false);
        }
    }
}
