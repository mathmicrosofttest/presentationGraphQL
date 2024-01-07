using GraphQL.Types;
using GraphQL;
using GraphQL.Tests.Subscription;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IChat, Chat>();
builder.Services.AddSingleton<MessageInputType>();
builder.Services.AddSingleton<MessageFromType>();
builder.Services.AddSingleton<ISchema, ChatSchema>();
builder.Services.AddGraphQL(b => b
    .AddAutoSchema<ChatSubscriptions>() // schema
    .AddSystemTextJson());   // serializer-

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
