using _06_03.HotChocolateEntityFramework.Database;
using HotChocolate.Subscriptions;

namespace _06_03.HotChocolateEntityFramework.Schema
{
    public class Mutation
    {
        public async Task<Guid> AddCompanyAsync([Service] UserDbContext dbContext, [Service] ITopicEventSender topicEventSender,
            string companyName)
        {
            var newCompany = new Company { Name = companyName };

            await dbContext.AddAsync(newCompany);
            await dbContext.SaveChangesAsync();

            await topicEventSender.SendAsync(nameof(Subscription.CompanyCreated), newCompany.Id);

            return newCompany.Id;
        }
    }
}
