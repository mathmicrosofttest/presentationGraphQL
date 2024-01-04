namespace _06_02.HotChocolateDummyData.Schema
{
    public class Company
    {
        public string Name { get; set; } = default!;

        public IEnumerable<Vehicle>? Vehicles { get; set; }
    }
}
