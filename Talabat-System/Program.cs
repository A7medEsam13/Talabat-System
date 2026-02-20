
using Serilog;
using Talabat_System.Extensions;

namespace Talabat_System
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // add logging info.
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateBootstrapLogger();


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            // connect to the datatbase.
            builder.Services.ConnectDatabase(builder.Configuration);

            builder.Host.UseSerilog((context, services, configuration) =>
            {
                configuration
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext();
            });

            // services registering.
            builder.Services.RegisterRepositories();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // add the logger to the app.
            app.UseSerilogRequestLogging(options =>
            {
                options.MessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";
            });

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
