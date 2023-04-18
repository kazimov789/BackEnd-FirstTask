var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
static void ConfigureService(IServiceCollection services)
{
    services.AddControllers();
    services.AddControllersWithViews();
}
//static void NewMethod(WebApplication app)
//{
//    app.UseEndpoints(endpoints =>
//    {
//        endpoints.MapControllerRoute("default", "/{controllers}/{action}");

//    });
//}
//NewMethod(app);

app.MapControllerRoute("default", "/{controllers}/{action}");
app.Run();
