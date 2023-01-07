using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IHomework<Homework>, HomeworkRepository>();
        services.AddControllers();
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(
            builder =>
            {
                builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            });
        });
        services.AddSwaggerGen();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomeWorked API v1");
        });
        app.UseRouting();
        // global cors policy
        app.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => true) // allow any origin
            .AllowCredentials()); // allow credentials


        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
