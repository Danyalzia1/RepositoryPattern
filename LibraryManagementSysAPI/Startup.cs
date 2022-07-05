using LibraryManagementSysAPI.Data;
using LibraryManagementSysAPI.Models;
using LibraryManagementSysAPI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
using AutoMapper;
namespace LibraryManagementSysAPI
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
            services.AddDbContext<ApplicationDbContext>();
            services.AddScoped(typeof(IRepository<Book>), typeof(BookRepository));
            services.AddScoped(typeof(IRepository<Librarian>), typeof(LibrarianRepository));
            services.AddScoped(typeof(IRepository<Library>), typeof(LibraryRepository));
            services.AddScoped(typeof(IRepository<Member>), typeof(MemberRepository));
            services.AddScoped(typeof(IRepository<Membership>), typeof(MembershipRepository));
            services.AddScoped(typeof(IRepository<Staff>), typeof(StaffRepository));
            services.AddScoped(typeof(IRepository<Student>), typeof(StudentRepository));
            services.AddScoped(typeof(IRepository<BooksAssToMembers>), typeof(BooksAssToMembersRepository));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped(typeof(IRepository<Book>), typeof(BookRepository));
            services.AddScoped(typeof(IRepository<BooksAssToMembers>), typeof(BooksAssToMembersRepository));
            services.AddScoped(typeof(IRepository<Librarian>), typeof(LibrarianRepository));
            services.AddScoped(typeof(IRepository<Library>), typeof(LibraryRepository));
            services.AddScoped(typeof(IRepository<Member>), typeof(MemberRepository));
            services.AddScoped(typeof(IRepository<Membership>), typeof(MembershipRepository));
            services.AddScoped(typeof(IRepository<Staff>), typeof(StaffRepository));
            services.AddScoped(typeof(IRepository<Student>), typeof(StudentRepository));





            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LibraryManagementSysAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LibraryManagementSysAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
