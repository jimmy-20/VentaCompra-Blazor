using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Inventario.Data;
using Data;
using Services;
using Data.Interfaces;
using Data.Repository;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<InventarioContext>();

//Implementando injeccion de repositorios.
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<IBaseProductRepository,BaseProductRepository>();
builder.Services.AddScoped<ICategoryProductRepository, CategoryProductRepository>();
builder.Services.AddScoped<IContentProductRepository,ContentProductRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<IOrderRepository,OrderRepository>();
builder.Services.AddScoped<IOrderDetailRepository,OrderDetailRepository>();
builder.Services.AddScoped<IProviderRepository,ProviderRepository>();
builder.Services.AddScoped<IPurchaseRepository,PurchaseRepository>();
builder.Services.AddScoped<IPurchaseDetailRepository,PurchaseDetailRepository>();
builder.Services.AddScoped<IPurchaseRepository,PurchaseRepository>();

builder.Services.AddScoped<ICategoryProductServices,CategoryProductServices>();
builder.Services.AddScoped<IProductServices,ProductServices>();
builder.Services.AddScoped<ICustomerServices,CustomerServices>();
builder.Services.AddScoped<IEmployeeServices,EmployeeServices>();
builder.Services.AddScoped<IProviderServices,ProviderServices>();
builder.Services.AddScoped<IPurchaseServices,PurchaseServices>();
builder.Services.AddScoped<IOrderServices,OrderServices>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
