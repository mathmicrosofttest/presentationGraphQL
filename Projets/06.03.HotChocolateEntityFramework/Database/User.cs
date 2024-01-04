namespace _06_03.HotChocolateEntityFramework.Database
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Phone { get; set; } = default!;

        public ICollection<Vehicle>? Vehicles { get; set; }

        public Company Company { get; set; } = default!;
        
        public Guid CompanyId { get; set; }
    }
}
