namespace EntityFrameWork
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DepartmentModel : DbContext
    {
        public DepartmentModel()
            : base("name=DepartmentDBContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.FIRSTnnam)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.LastNAme)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .HasMany(e => e.Departments)
                .WithOptional(e => e.EMPLOYEE)
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}
