using BlazorDemoApp.Components;
using BlazorDemoApp.Services;
using BlazorDemoApp.Services.SecretService;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var secretManager = new AzureVaultSecretManager(builder.Configuration);
builder.Services.AddSingleton<ISecretManager>(secretManager);
builder.Services.AddSingleton<SalesTerminalService>();
builder.Services.AddSyncfusionBlazor();


var app = builder.Build();

app.RegisterSyncfusionLicense();

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


