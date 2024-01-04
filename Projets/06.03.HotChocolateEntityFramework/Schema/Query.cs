using _06_03.HotChocolateEntityFramework.Database;

namespace _06_03.HotChocolateEntityFramework.Schema
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<User> GetUsers([Service] UserDbContext userDbContext) => userDbContext.Users;
    }
}
