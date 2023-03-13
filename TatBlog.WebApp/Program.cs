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
app.Run();
