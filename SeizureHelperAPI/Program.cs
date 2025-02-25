
using SeizureHelper.ServiceDefaults;

namespace SeizureHelperAPI;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        _ = builder.AddServiceDefaults();

        // Add services to the container.

        _ = builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _ = builder.Services.AddEndpointsApiExplorer();
        _ = builder.Services.AddSwaggerGen();

        WebApplication app = builder.Build();
    https://localhost:7282/swagger/index.html
        _ = app.MapDefaultEndpoints();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI();
        }

        _ = app.UseHttpsRedirection();

        _ = app.UseAuthorization();


        _ = app.MapControllers();

        app.Run();
    }
}
