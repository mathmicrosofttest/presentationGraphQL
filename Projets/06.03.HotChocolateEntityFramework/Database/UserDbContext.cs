using Bogus;
using Microsoft.EntityFrameworkCore;

namespace _06_03.HotChocolateEntityFramework.Database
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        private readonly string dbPath;

        public UserDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            dbPath = System.IO.Path.Join(path, "users.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseSqlite($"Data Source={dbPath}")
            .LogTo(Console.WriteLine);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seed = 854071;

            var fakeCompanies = new Faker<Company>()
                .UseSeed(seed)
                .RuleFor(com => com.Id, f => Guid.NewGuid())
                .RuleFor(com => com.Name, f => f.Company.CompanyName())
                .Generate(10);

            modelBuilder.Entity<Company>().HasData(fakeCompanies);

            var fakeUsers = new Faker<User>()
                .UseSeed(seed)
                .RuleFor(user => user.Id, f => Guid.NewGuid())
                .RuleFor(user => user.FirstName, f => f.Person.FirstName)
                .RuleFor(user => user.LastName, f => f.Person.LastName)
                .RuleFor(user => user.Email, f => f.Person.Email)
                .RuleFor(user => user.Phone, f => f.Person.Phone)
                .RuleFor(user => user.CompanyId, f => f.PickRandom(fakeCompanies).Id)
                .Generate(75);

            modelBuilder.Entity<User>().HasData(fakeUsers);

            var fakeVehicles = new Faker<Vehicle>()
                .UseSeed(seed)
                .RuleFor(veh => veh.Id, f => Guid.NewGuid())
                .RuleFor(veh => veh.Model, f => f.Vehicle.Model())
                .RuleFor(veh => veh.Vin, f => f.Vehicle.Vin())
                .RuleFor(veh => veh.Fuel, f => f.Vehicle.Fuel())
                .RuleFor(veh => veh.CompanyId, f => f.PickRandom(fakeCompanies).Id)
                .RuleFor(veh => veh.UserId, f => f.PickRandom(fakeUsers).Id)
                .Generate(200);

            modelBuilder.Entity<Vehicle>().HasData(fakeVehicles);

            base.OnModelCreating(modelBuilder);
        }
    }
}
