using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.API.Data;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Auth.API
{
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
        var hostName = Environment.GetEnvironmentVariable("SQLSERVER_HOST");
            // var hostPassword = Environment.GetEnvironmentVariable("SA_PASSWORD");

            // var connectionString = $"Server={hostName}; Database=CatalogDb; user ID =sa; Password={hostPassword};";

            // services.AddDbContext<DataContext>(
            //     options => options.UseSqlServer(connectionString) 
            // );

             services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddIdentity(User, IdentityRole)
            .AddIdentityFrameworkStores<DataContext>()
            .AddDefaultTokenProviders();

            services.AddIdentityServer()
            .AddDeveloperSigningCredential()
            .AddInMemoryIdentityResources(Config.GetIdentityResource())
            .AddInMemoryApiResources(Config.GetApiResources())
            .AddInMemoryClients(Config.GetClients())
             .AddAspNetIdentity<User>();

            services.AddTransient<IProfileService, IdentityClaimsProfileService>();
        
            services.AddSwaggerGen( options => {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info()
                {
                        Title = "Aoth Services",
                        Version = "v1",
                        Description = "for testing only",
                });
                
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDeveloperExceptionPage();
                app.UseSwagger().UseSwaggerUI( c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Auth API");
                });
            }
           app.UseIdentityServer(); 
            app.UseMvc();
        }
    }
}
