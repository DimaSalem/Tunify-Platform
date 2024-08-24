using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Tunify_Platform.Data;
using Tunify_Platform.Repositories.interfaces;
using Tunify_Platform.Repositories.Services;
using Moq;

namespace Tunify_Platform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            // Configure JSON options to handle object cycles
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                });

            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Tunify API",
                    Version = "v1",
                    Description = "API for managing playlists, songs, and artists in the Tunify Platform"
                });
            });


            string ConnectionStringVar = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<TunifyDbContext>(optionsX => optionsX.UseSqlServer(ConnectionStringVar));

            // Register repositories
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IPlaylist, PlaylistService>();
            builder.Services.AddScoped<IArtist, ArtistService>();

            //2
            var app = builder.Build();

            app.UseSwagger(
             options =>
             {
                 options.RouteTemplate = "api/{documentName}/swagger.json";
             }
             );


            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Tunify API v1");
                options.RoutePrefix = "";
            });

            app.MapControllers();

            //3
            app.MapGet("/", () => "Hello World!");
            //4
            app.Run();
        }
    }
}
