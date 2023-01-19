using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Middleware;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace API
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
            services
                .AddSwaggerGen(c =>
                {
                    c
                        .SwaggerDoc("v1",
                        new OpenApiInfo { Title = "WebAPIv5", Version = "v1" });
                    c
                        .AddSecurityDefinition("Bearer",
                        new OpenApiSecurityScheme {
                            Description = "Jwt auth header",
                            Name = "Authorization",
                            In = ParameterLocation.Header,
                            Type = SecuritySchemeType.ApiKey,
                            Scheme = "Bearer"
                        });
                    c
                        .AddSecurityRequirement(new OpenApiSecurityRequirement {
                            {
                                new OpenApiSecurityScheme {
                                    Reference =
                                        new OpenApiReference {
                                            Type = ReferenceType.SecurityScheme,
                                            Id = "Bearer"
                                        },
                                    Scheme = "oauth2",
                                    Name = "Bearer",
                                    In = ParameterLocation.Header
                                },
                                new List<string>()
                            }
                        });
                });
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string connString;
            if (env == "Development")
                connString = Configuration
                        .GetConnectionString("DefaultConnection");
            else
            {
                // Use connection string provided at runtime by Heroku.
                var connUrl =
                    Environment.GetEnvironmentVariable("DATABASE_URL");

                // Parse connection URL to connection string for Npgsql
                connUrl = connUrl.Replace("postgres://", string.Empty);
                var pgUserPass = connUrl.Split("@")[0];
                var pgHostPortDb = connUrl.Split("@")[1];
                var pgHostPort = pgHostPortDb.Split("/")[0];
                var pgDb = pgHostPortDb.Split("/")[1];
                var pgUser = pgUserPass.Split(":")[0];
                var pgPass = pgUserPass.Split(":")[1];
                var pgHost = pgHostPort.Split(":")[0];
                var pgPort = pgHostPort.Split(":")[1];

                connString =
                    $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={
                        pgPass};Database={pgDb};";
            }
            services
                .AddDbContext<StoreContext>(opt =>
                {
                    opt.UseNpgsql (connString);
                });

            services.AddCors();
            services
                .AddIdentityCore<User>(opt =>
                {
                    opt.User.RequireUniqueEmail = true;
                })
                .AddRoles<Role>()
                .AddEntityFrameworkStores<StoreContext>();
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters =
                        new TokenValidationParameters {
                            ValidateIssuer = false,
                            ValidateAudience = false,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey =
                                new SymmetricSecurityKey(Encoding
                                        .UTF8
                                        .GetBytes(Configuration["JWTSettings:TokenKey"]))
                        };
                });

            services.AddAuthorization();
            services.AddScoped<TokenService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionMiddleware>();

            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app
                    .UseSwaggerUI(c =>
                        c
                            .SwaggerEndpoint("/swagger/v1/swagger.json",
                            "WebAPIv5 v1"));
            }

            //app.UseHttpsRedirection();
            app.UseRouting();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app
                .UseCors(opt =>
                {
                    opt
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .WithOrigins("http://localhost:3000");
                });

            app.UseAuthentication();
            app.UseAuthorization();

            app
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                    endpoints.MapFallbackToController("Index", "Fallback");
                });
        }
    }
}
