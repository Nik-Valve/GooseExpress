using GooseExpress2Api.Data;
using GooseExpress2Api.Interfaces;
using GooseExpress2Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICargoRepositories, CargoRepositories>();
builder.Services.AddScoped<ICountryRepositories, CountryRepositories>();
builder.Services.AddScoped<ICustomerRepositories, CustomerRepositories>();
builder.Services.AddScoped<IFeedbackRepositories, FeedBackRepositories>();
builder.Services.AddScoped<IOrderRepositories,OrderRepositories>();
builder.Services.AddScoped<IRecipientsRepositories,RecipientRepository>();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataContext"));
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
