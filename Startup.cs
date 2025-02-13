using PlataformaPrestamos.Data;
using PlataformaPrestamos.Repositories;
using PlataformaPrestamos.Security;
using PlataformaPrestamos.Services;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();
        services.AddScoped<UsuarioRepository>();
        services.AddScoped<PrestamoRepository>();
        services.AddScoped<PagoRepository>();
        services.AddScoped<AuthService>();
        services.AddScoped<TokenService>();
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}