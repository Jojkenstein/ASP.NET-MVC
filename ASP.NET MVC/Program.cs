var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

//VERKAR EJ FUNGERA PLÖTSLIGT
app.MapControllerRoute(
name: "Fever Check",
pattern: "fevercheck",
defaults: new { controller = "Doctor", action = "Temperature" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");




app.Run();
