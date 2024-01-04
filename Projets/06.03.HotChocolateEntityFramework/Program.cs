using _06_03.HotChocolateEntityFramework.Database;
using _06_03.HotChocolateEntityFramework.Schema;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserDbContext>();

builder.Services.AddGraphQLServer()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddInMemorySubscriptions();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.UseWebSockets();

app.Run();