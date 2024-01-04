using Bogus;

namespace _06_02.HotChocolateDummyData.Schema
{
    public class Query
    {
        private readonly IEnumerable<User> _fakeUsers;

        public Query()
        {
            var fakeVehicles = new Faker<Vehicle>()
                .RuleFor(veh => veh.Model, f => f.Vehicle.Model())
                .RuleFor(veh => veh.Vin, f => f.Vehicle.Vin())
                .RuleFor(veh => veh.Fuel, f => f.Vehicle.Fuel());

            var fakeCompanies = new Faker<Company>()
                .RuleFor(com => com.Name, f => f.Company.CompanyName())
                .RuleFor(com => com.Vehicles, f => fakeVehicles.GenerateBetween(0, 20));

            _fakeUsers = new Faker<User>()
                .RuleFor(user => user.Id, f => Guid.NewGuid())
                .RuleFor(user => user.FirstName, f => f.Person.FirstName)
                .RuleFor(user => user.LastName, f => f.Person.LastName)
                .RuleFor(user => user.Email, f => f.Person.Email)
                .RuleFor(user => user.Phone, f => f.Person.Phone)
                .RuleFor(user => user.Vehicles, f => fakeVehicles.GenerateBetween(0, 2))
                .RuleFor(user => user.Company, f => fakeCompanies.Generate())
                .Generate(10);
        }

        [UseOffsetPaging]
        public IEnumerable<User> GetUsers() => _fakeUsers;

        public User? GetUserById(Guid id) => _fakeUsers.FirstOrDefault(user => user.Id == id);
    }
}
