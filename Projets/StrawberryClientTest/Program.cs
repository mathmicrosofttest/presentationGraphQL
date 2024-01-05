
using Microsoft.Extensions.DependencyInjection;
using StrawberryClientTest;
using StrawberryShake;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IServiceCollection services = new ServiceCollection();

services.AddConferenceClient()
        .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://workshop.chillicream.com/graphql"));

IServiceProvider servicesProvider = services.BuildServiceProvider();

IConferenceClient client = servicesProvider.GetRequiredService<IConferenceClient>();

var result = await client.GetSessions.ExecuteAsync();
result.EnsureNoErrors();

if (result?.Data?.Sessions?.Nodes != null)
{
    foreach (var session in result.Data.Sessions.Nodes)
    {
        Console.WriteLine(session.Title);
    }
}
