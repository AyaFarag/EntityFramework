using CodeFirstApp.Migrations;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("data source=.;initial catalog=codefirstdb2025;integrated security=True;MultipleActiveResultSets=True;TrustServerCertificate=True")
                ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var allEntities = modelBuilder.Model.GetEntityTypes();

            //foreach (var entity in allEntities)
            //{
            //    entity.AddProperty("CreatedDate", typeof(DateTime));
            //    entity.AddProperty("UpdatedDate", typeof(DateTime));
            //}
            //Write Fluent API configurations here
            //modelBuilder.HasDefaultSchema("Admin");

            //modelBuilder.Entity<User>().Property(a => a.Id).IsRequired();

            //modelBuilder.Entity<CourseStudent>().HasKey(a => new { a.courseId , a.studentId });



            //modelBuilder.Entity<User>()
            //    .HasIndex(a => a.Email);

            //modelBuilder.Entity<User>()
            //    .Property(a => a.Age)
            //    .HasDefaultValue(18);
            //modelBuilder.Entity<User>().Property(a => a.Email).IsRequired(false);

            //modelBuilder.Entity<Grade>().Property(a=>a.Name).HasMaxLength(50)
            //    .IsRequired().IsUnicode();

            //modelBuilder.Entity<Address>()
            //    .Ignore(d => d.State)
            //    .Property(c => c.Country)
            //    .HasDefaultValue("Egypt");

            //modelBuilder.Entity<Category>()

            //    .ToTable("Brand");
            //modelBuilder.Entity<Category>()
            //    .Property(c => c.Name).HasColumnName("CatName");

            //---------------------------------------------------------------

            //modelBuilder.Entity<Student>()
            //        .HasOne(a => a.Address)
            //        .WithOne(a => a.Student)
            //        .HasForeignKey<Address>(a => a.Student_id)
            //        .OnDelete(DeleteBehavior.NoAction);


            //modelBuilder.Entity<Grade>()
            //    .HasMany(s => s.Students)
            //    .WithOne(g => g.Grade)
            //    .HasForeignKey(g=>g.Grade_id)
            //    .OnDelete(DeleteBehavior.NoAction);


            //modelBuilder.Entity<Student>()
            //    .HasOne(g=>g.Grade)
            //    .WithMany(s=>s.Students)
            //    .HasForeignKey(g=>g.Grade_id) 
            //    .OnDelete(DeleteBehavior.NoAction);


            //modelBuilder.Entity<CourseStudent>()
            //    .HasOne(s=>s.student)
            //    .WithMany(cs=>cs.courseStudents)
            //    .HasForeignKey(f=>f.studentId)
            //    .OnDelete(DeleteBehavior.Cascade);


            //modelBuilder.Entity<CourseStudent>()
            //    .HasOne(c=>c.Course)
            //    .WithMany(cs=>cs.courseStudents)
            //    .HasForeignKey (f=>f.courseId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Student>()
            //    .HasMany<Course>()
            //    .WithMany(s => s.Students)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "StudentCourse", // Name of the pivot table
            //        join => join
            //            .HasOne<Course>()
            //            .WithMany()
            //            .HasForeignKey("CourseId")
            //            .OnDelete(DeleteBehavior.Cascade),
            //        join => join
            //            .HasOne<Student>()
            //            .WithMany()
            //            .HasForeignKey("StudentId")
            //            .OnDelete(DeleteBehavior.NoAction));












        }


        // DBSet property
        public DbSet<User> users { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<CourseStudent> courseStudents { get; set; }
        public DbSet<Category> categories { get; set; }




    }
}
