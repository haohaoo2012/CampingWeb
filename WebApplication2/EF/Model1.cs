namespace WebApplication2.EF
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

        public virtual DbSet<login> logins { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<login>()
                .Property(e => e.user)
                .IsFixedLength();

            modelBuilder.Entity<login>()
                .Property(e => e.pass)
                .IsFixedLength();
        }
    }
}
