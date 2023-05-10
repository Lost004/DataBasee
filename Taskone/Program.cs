using Microsoft.EntityFrameworkCore;
using Taskone.DataAccsessLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=;Database0TaskoneDb;Trusted_Connection=true;");
});
var app = builder.Build();
app.MapControllerRoute( name: "default",pattern: "{controller=marka}/{action=index}/{id?}");

app.Run();

