namespace _06_03.HotChocolateEntityFramework.Database
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default!;

        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}
