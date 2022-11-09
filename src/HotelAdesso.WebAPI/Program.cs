using HotelAdesso.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EFContext>(opt =>
{
    opt.UseSqlServer("name=ConnectionStrings:HotelConnection");
});
var app = builder.Build();
using (var scope = app.Services.CreateScope() )
{
    var scopedProvider = scope.ServiceProvider;
    var efContext = scopedProvider.GetRequiredService<EFContext>();
    EFContextSeed.Seed(efContext);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
