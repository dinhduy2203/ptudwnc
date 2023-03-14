using Microsoft.EntityFrameworkCore;
using TatBlog.Data.Contexts;
using TatBlog.Data.Seeders;
using TatBlog.Services.Blogs;


var buider = WebApplication.CreateBuilder(args);
{

    buider.Services.AddControllersWithViews();

    buider.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlServer(
        buider.Configuration.GetConnectionString("DefaultConnection")));

    buider.Services.AddScoped<IBlogRepository, BlogRepository>();
    buider.Services.AddScoped<IDataSeeder, DataSeeder>();
}


var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();
}
var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/blog/Error");
        app.UseHsts();
    }

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blog}/{action=Index}/{id?}");
}


using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<IDataSeeder>();
    seeder.Initialize();
}
app.Run();
