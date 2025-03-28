

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient<CnpjService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllerRoute(name: "default", pattern: "{controller=Cnpj}/{action=Index}/{id?}"); });
app.Run();