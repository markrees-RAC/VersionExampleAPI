using VersionExampleAPI.Options;

var builder = WebApplication.CreateBuilder(args);

// Add Core 
builder.Services.AddCore();

builder.Services.AddControllers();

builder.Services.AddControllers();


var app = builder.Build();

app.UseRouting();

// Core
app.UseSwaggerWithVersioning();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
