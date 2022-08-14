using CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CustomerAccountContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerAccountContext") ?? throw new InvalidOperationException("Connection string 'CustomerAccountContext' not found.")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(CustomerQueryRequest).Assembly);

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
