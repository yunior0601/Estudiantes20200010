using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Estudiantes20200010.Data;
using Estudiantes20200010.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSqlite<EstudiantesDbContext>("Data Source=.//Data//Context//EstudiantesDb.sqlite");
builder.Services.AddScoped<IEstudiantesDbContext,EstudiantesDbContext>();

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


var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<EstudiantesDbContext>();
    if (db.Database.EnsureCreated())
    {
       
    }
}

app.Run();
