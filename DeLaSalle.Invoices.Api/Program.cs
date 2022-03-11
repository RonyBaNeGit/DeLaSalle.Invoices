using DeLaSalle.Invoices.Api.Services; //namespace
using  DeLaSalle.Invoices.Api.Services.Interfaces;
using DeLaSalle.Invoices.Api.Repositories;
using  DeLaSalle.Invoices.Api.Repositories.Interfaces;
using DeLaSalle.Invoices.Api.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerService,CustomerService>();
//builder.Services.AddSingleton<ICustomerRepository,CustomerInMemoryRepository>();
builder.Services.AddScoped<ICustomerRepository,CustomerInMemoryRepository>();


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
