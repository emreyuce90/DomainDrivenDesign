using DomainDrivenDesign.Application;
using DomainDrivenDesign.Infrastructure;
namespace DomainDrivenDesign.API {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddApplicationDependenciesExt();
            builder.Services.AddInfraDependenciesExt(builder.Configuration.GetConnectionString("SqlServer"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.MapControllers();

            app.UseHttpsRedirection();

            app.UseAuthorization();

      

            app.Run();
        }
    }
}
