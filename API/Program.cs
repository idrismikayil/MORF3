using Infrastructure.Middleware;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Business Services
#endregion
#region Global Exception Handler
builder.Services.AddLogging();
builder.Services.AddTransient<GlobalExceptionHandler>();
#endregion
#endregion
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
#region Middleware
app.UseMiddleware<GlobalExceptionHandler>();
#endregion
app.MapControllers();
app.Run();
