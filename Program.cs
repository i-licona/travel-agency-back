using Microsoft.EntityFrameworkCore;
using travel_agency_back.Data;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

/* openAPI: permite propar nuestros endpoints */

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/* conexion a la base de datos */
builder.Services.AddDbContext<TravelAgencyContext>( options =>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"));
});

var app = builder.Build();

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
