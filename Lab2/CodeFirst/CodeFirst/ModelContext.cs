namespace CodeFirst
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }


        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Cover> Covers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                  .ToTable("Department")
                  .HasKey(d => d.Id)
                  .Property(d => d.Name)
                  .IsRequired()
                  .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .ToTable("Employee")
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.samar)
                .WithRequired(e => e.department)
                .HasForeignKey(e => e.Fk_DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.employees)
                .WithMany(e => e.books)
                .Map(e => e.ToTable("Employee_books")
                .MapLeftKey("Fk_EmployeeId").MapRightKey("FK_bookId"));

            modelBuilder.Entity<City>()
                .HasOptional(b => b.Book)
                .WithRequired(c => c.City);


            modelBuilder.Entity<Cover>()
                .ToTable("Cover")
                .Property(c => c.Code)
                .HasMaxLength(50)
                .IsRequired();



            modelBuilder.Entity<Cover>()
                .HasRequired(b => b.Book)
                .WithRequiredPrincipal(c => c.Cover)
                .WillCascadeOnDelete(false); 



        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}