using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZooAnimalList.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ZooEventAndScheduleContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZooEventAndScheduleContext") ?? throw new InvalidOperationException("Connection string 'ZooEventAndScheduleContext' not found.")));
builder.Services.AddDbContext<ZooPriceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZooPriceContext") ?? throw new InvalidOperationException("Connection string 'ZooPriceContext' not found.")));
builder.Services.AddDbContext<ZooAnimalListContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZooAnimalListContext") ?? throw new InvalidOperationException("Connection string 'ZooAnimalListContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
