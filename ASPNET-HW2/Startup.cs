using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_HW2
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASPNET_HW2", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASPNET_HW2 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            string classnum, studnum;
            app.Use(async (context, next) =>
            {
                string req = context.Request.Path;
                string[] reqarr = req.Split("/");
                if (reqarr.Length <= 2) await next();
                else { classnum = reqarr[1];
                      
                    await context.Response.WriteAsync("class number is " + classnum + "\n");
                }
                next();
                
            
                
            });

            app.Use(async (context, next) =>
            {

                string req = context.Request.Path;
                string[] reqarr = req.Split("/");
                if (reqarr.Length <= 2) await next();
                else
                {
                    studnum = reqarr[2];

                    await context.Response.WriteAsync("student number is " + studnum + "\n");
                }


            });



            app.UseEndpoints(endpoints => endpoints.MapControllers());
           
        }

    }
}

