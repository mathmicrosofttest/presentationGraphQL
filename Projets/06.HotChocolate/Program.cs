using _06_01.HotChocolateSetup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();
