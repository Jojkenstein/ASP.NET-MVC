var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});

var app = builder.Build();


app.UseSession();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
name: "Fever Check",
pattern: "FeverCheck",
defaults: new { controller = "Doctor", action = "Temperature" });

app.MapControllerRoute(
name: "Guessing Game",
pattern: "GuessingGame",
defaults: new { controller = "Games", action = "GuessNumber" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ajax}/{action=Index}/{id?}");


app.Run();
