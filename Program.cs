using MitchellFabrication.Components;
using MitchellFabrication.Models;
using MitchellFabrication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSingleton<DataService>();
builder.Services.AddScoped<PersonalInfo>();
builder.Services.AddScoped<LocationService>();
builder.Services.AddScoped(sp =>
{
    var client = new HttpClient();
    client.DefaultRequestHeaders.Add("X-CSCAPI-KEY", "b8598348fa774a74e879aa6b8327a7d33ddaf67accbeb3700d3ffe32b9cc8f1d");
    return client;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
