using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Interfaces.Service;
using BookManager.Infra.Context;
using BookManager.Infra.Repository;
using BookManager.Service.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BookManager.WebAPI {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices (IServiceCollection services) {
            services.AddCors (options => {
                options.AddPolicy ("EnableCORS", builder => {
                    builder.AllowAnyOrigin ().AllowAnyHeader ().AllowAnyMethod ().AllowCredentials ().Build ();
                });
            });
            services.AddDbContext<BookManagerContext> (
                options => options.UseNpgsql (
                    Configuration.GetConnectionString ("Books"),
                    b => b.MigrationsAssembly ("BookManager.WebAPI")
                )
            );

            ConfigureDI (services);

            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2);
        }

        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }
            app.UseCors ("EnableCORS");
            app.UseMvc ();
        }

        private void ConfigureDI (IServiceCollection services) {

            services.AddTransient<IAuthorRepository, AuthorRepository> ();
            services.AddTransient<IBookRepository, BookRepository> ();
            services.AddTransient<IGenreRepository, GenreRepository> ();
            services.AddTransient<IPublishingCompanyRepository, PublishingCompanyRepository> ();

            services.AddTransient<IAuthorService, AuthorService> ();
            services.AddTransient<IBookService, BookService> ();
            services.AddTransient<IGenreService, GenreService> ();
            services.AddTransient<IPublishingCompanyService, PublishingCompanyService> ();
        }
    }
}