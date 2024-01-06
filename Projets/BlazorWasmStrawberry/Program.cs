using BlazorWasmStrawberry;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddCryptoClient()
    .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://demo.chillicream.com/graphql"));

await builder.Build().RunAsync();
