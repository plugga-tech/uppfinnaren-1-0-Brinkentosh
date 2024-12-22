using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Uppfinnaren.Data.Entities;
using Uppfinnaren.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductInfoRepository, ProductInfoRepository>();
builder.Services.AddScoped<IContactInfoRepository, MockContactInfoRepository>();
builder.Services.AddDbContext<AppDbContext>(options=>
    options.UseInMemoryDatabase("inventorsgalleri")
);
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
