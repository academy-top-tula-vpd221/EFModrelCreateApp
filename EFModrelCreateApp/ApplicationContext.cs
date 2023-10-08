using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFModrelCreateApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;

        //public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=data_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Ignore<Address>();
            //modelBuilder.Entity<Employee>().Ignore(e => e.Age);
            //modelBuilder.Entity<Address>().Property("Id").HasField("myid");
            //modelBuilder.Entity<Address>().Property("City").HasField("mycity");

            //modelBuilder.Entity<Address>().ToTable("Cities");
            //modelBuilder.Entity<Address>().Property(a => a.Id).HasColumnName("GlobalId");
            //modelBuilder.Entity<Address>().Property(a => a.City).HasColumnName("TitleCity");

            //modelBuilder.Entity<Company>().Property(c => c.Title).IsRequired();

            //modelBuilder.Entity<Employee>()
            //            .HasIndex(e => new { e.Name, e.Age })
            //            .HasDatabaseName("Name_Age_Index");

            //modelBuilder.Entity<Company>()
            //            .Property(c => c.Activity)
            //            .HasDefaultValue(true);

            //modelBuilder.Entity<Employee>()
            //            .Property(e => e.Name)
            //            .HasComputedColumnSql("LastName + ' ' + FirstName");

            //modelBuilder.Entity<Employee>()
            //            .ToTable(t => t.HasCheckConstraint("Age", "Age > 0 AND Age < 120")
            //                            .HasName("Age_Check"));

            //modelBuilder.Entity<Employee>()
            //            .Property(e => e.Password)
            //            .HasMaxLength(10);

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.Entity<Company>(CompanyConfigure);

        }

        public void CompanyConfigure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(c => c.Title).IsRequired();
        }
    }

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasIndex(e => e.Name);
            builder.ToTable(t => t.HasCheckConstraint("Age", "Age > 0 AND Age < 120")
                                  .HasName("Age_Check"));
            //builder.HasData(
            //    new Employee() { Name = "Bob"}
            //    );
        }
    }

    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
        }
    }

}
