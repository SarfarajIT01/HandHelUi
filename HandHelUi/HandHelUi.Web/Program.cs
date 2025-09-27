using HandHeldUi.Shared.Services;
using HandHelUi.Shared.Services;
using HandHelUi.Web.Components;
using HandHelUi.Web.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<ILoginService, LoginService>();

// Register HttpClient with BaseUrl from appsettings.json
var baseUrl = builder.Configuration["ApiSettings:BaseUrl"];
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(baseUrl!)
});

builder.Services.AddHttpClient();

//builder.Services.AddScoped<ApiService>();
builder.Services.AddSingleton<UserState>();

// Register CartState service
builder.Services.AddScoped<CartState>();

builder.Services.AddScoped<TableSelectionService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(HandHelUi.Shared._Imports).Assembly);

app.Run();
