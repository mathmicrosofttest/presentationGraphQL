namespace _06_03.HotChocolateEntityFramework.Database
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public string Model { get; set; } = default!;

        public string Vin { get; set; } = default!;

        public string Fuel { get; set; } = default!;

        public Guid? UserId { get; set; }

        public User? User { get; set; }

        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }
    }
}
