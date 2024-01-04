namespace _06_03.HotChocolateEntityFramework.Schema
{
    public class Subscription
    {
        [Subscribe]
        public Guid CompanyCreated([EventMessage] Guid newCompanyId) => newCompanyId;
    }
}
