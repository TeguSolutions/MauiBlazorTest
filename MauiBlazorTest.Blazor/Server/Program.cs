using MauiBlazorTest.Blazor.Server.ServiceImplementations;
using MauiBlazorTest.Blazor.Shared.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Todo:
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44371/") });
builder.Services.AddHttpClient("Api", client => client.BaseAddress = new Uri("https://localhost:44371/"));
builder.Services.AddScoped<IPersistentComponentState, BlazorPersistentComponentState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
//app.MapFallbackToFile("index.html");
app.MapFallbackToPage("/_Host");

app.Run();
