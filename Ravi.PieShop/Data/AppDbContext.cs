using Microsoft.EntityFrameworkCore;
using Ravi.PieShop.Shared.Domain;

namespace Ravi.PieShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<TimeRegistration> TimeRegistrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Countries
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "United States" },
                new Country { CountryId = 2, Name = "Canada" },
                new Country { CountryId = 3, Name = "United Kingdom" },
                new Country { CountryId = 4, Name = "Mexico" },
                new Country { CountryId = 5, Name = "Germany" },
                new Country { CountryId = 6, Name = "Japan" }
            );

            //Seed data for JobCategories
            modelBuilder.Entity<JobCategory>().HasData(
                new JobCategory
                {
                    JobCategoryId = 1,
                    JobCategoryName = "Software Engineer"
                },
                new JobCategory
                {
                    JobCategoryId = 2,
                    JobCategoryName = "Data Scientist"
                },
                new JobCategory
                {
                    JobCategoryId = 3,
                    JobCategoryName = "Product Manager"
                },
                new JobCategory
                {
                    JobCategoryId = 4,
                    JobCategoryName = "UX Designer"
                },
                new JobCategory
                {
                    JobCategoryId = 5,
                    JobCategoryName = "DevOps Engineer"
                }
            );

            // Seed data for Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1987, 11, 21),
                    Email = "jdoe@anywhere.com",
                    Street = "123 Main St",
                    Zip = "12345",
                    City = "Anytown",
                    CountryId = 1,
                    PhoneNumber = "123-456-7890",
                    Smoker = false,
                    MaritalStatus = MaritalStatus.Single,
                    JobCategoryId = 1,
                    Latitude = 37.7749,
                    Longitude = -122.4194,
                    JoinedDate = new DateTime(2022, 1, 15),
                    Gender = Gender.Male,
                    IsOnHoliday = false,
                    Comment = "New employee, eager to learn."
                }
            );

            var random = new Random();
            // Seed data for TimeRegistrations
            for (int i= 1;i <= 1000; i++)
            {
                modelBuilder.Entity<TimeRegistration>().HasData(
                    new TimeRegistration
                    {
                        Id = i,
                        EmployeeId = 1,
                        StartTime = new DateTime(2023, 10, 1, random.Next(8, 10), random.Next(0, 60), 0),
                        EndTime = new DateTime(2023, 10, 1, random.Next(16, 18), random.Next(0, 60), 0),
                        TaskDescription = $"Task {i} description"
                    }
                );
            }
        }
    }
}
