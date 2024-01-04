using _06_02.HotChocolateDummyData.Schema;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();