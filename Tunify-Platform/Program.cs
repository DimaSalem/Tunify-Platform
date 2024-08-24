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


            string ConnectionStringVar = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<TunifyDbContext>(optionsX => optionsX.UseSqlServer(ConnectionStringVar));

            // Register repositories
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IPlaylist, PlaylistService>();
            builder.Services.AddScoped<IArtist, ArtistService>();

            //2
            var app = builder.Build();

            app.MapControllers();

            //3
            app.MapGet("/", () => "Hello World!");
            //4
            app.Run();
        }
    }
}
