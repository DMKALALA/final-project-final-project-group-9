var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

#if DEBUG
var swaggerUrl = "http://localhost:5240/swagger";
try
{
    var psi = new System.Diagnostics.ProcessStartInfo
    {
        FileName = swaggerUrl,
        UseShellExecute = true
    };
    System.Diagnostics.Process.Start(psi);
}
catch (Exception ex)
{
    Console.WriteLine($"Failed to open Swagger UI: {ex.Message}");
}
#endif

app.Run();
