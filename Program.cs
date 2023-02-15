using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Inventario;
using Inventario.Data;
using Microsoft.EntityFrameworkCore;
using InventarioBlazor.Controllers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddDbContextFactory<InventarioContext>();
builder.Services.AddSqlServer<InventarioContext>("Server=(local); Database=Inventario;Integrated Security = true");
await builder.Build().RunAsync();
