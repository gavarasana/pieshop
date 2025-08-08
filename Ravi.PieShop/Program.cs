using Microsoft.EntityFrameworkCore;
using Ravi.PieShop.Components;
using Ravi.PieShop.Contracts.Repositories;
using Ravi.PieShop.Contracts.Services;
using Ravi.PieShop.Data;
using Ravi.PieShop.Repositories;
using Ravi.PieShop.Services;
using Ravi.PieShop.State;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// Register the DbContext with the dependency injection container
builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<SharedState>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
.AddInteractiveServerRenderMode();

app.Run();
