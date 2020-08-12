using HealthChecks.UI.Client;
using Medgrupo.Contacts.Domain.Handlers;
using Medgrupo.Contacts.Domain.Repositories;
using Medgrupo.Contacts.Infra.Contexts;
using Medgrupo.Contacts.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Medgrupo.Contacts.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {           

            services.AddDbContext<ContactsDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ContactsDbConnection"));
            });


            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddHealthChecks().AddSqlServer(Configuration.GetConnectionString("ContactsDbConnection"));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MedGrupo Contacts OnLine Documentation", Version = "v1" });
            });

            //Handlers
            services.AddTransient<ContactHandler, ContactHandler>();
            //Data
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<ContactsDbContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            //app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Contacts V1");
            });

            app.UseRouting();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            //app.UseHealthChecks("/api/health");

            app.UseHealthChecks("/hc", new HealthCheckOptions
            {
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
