namespace _06_02.HotChocolateDummyData.Schema
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Phone { get; set; } = default!;

        public IEnumerable<Vehicle>? Vehicles { get; set; }

        public Company Company { get; set; } = default!;
    }
}
