using CustomerAccount.CrossCutting.Exceptions;
using CustomerAccount.Domain.Commands.MapperProfiles.v1;
using CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer;
using CustomerAccount.Infrastructure.Data.Query.Query.MapperProfiles.v1;
using CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CustomerAccountContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerAccountContext") ?? throw new InvalidOperationException("Connection string 'CustomerAccountContext' not found.")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(CustomerQueryRequestProfile));
builder.Services.AddAutoMapper(typeof(CustomerCommandRequestProfile));
builder.Services.AddMediatR(typeof(UpdateCustomerCommandRequest).Assembly, typeof(GetCustomersQueryRequest).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware(typeof(MiddlewareError));

app.UseAuthorization();

app.MapControllers();

app.Run();
