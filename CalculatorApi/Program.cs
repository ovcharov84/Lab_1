using Lab_1;
using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Calculator>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapGet("/add", (double a, double b, [FromServices] Calculator calculator) =>
{
    return calculator.Add(a, b);
})
.WithOpenApi();

app.MapGet("/subtract", (double a, double b, [FromServices] Calculator calculator) =>
{
    return calculator.Subtract(a, b);
})
.WithOpenApi();

app.MapGet("/divide", (double a, double b, [FromServices] Calculator calculator) =>
{
    return calculator.Divide(a, b);
})
.WithOpenApi();

app.MapGet("/multiply", (double a, double b, [FromServices] Calculator calculator) =>
{
    return calculator.Multiply(a, b);
})
.WithOpenApi();

app.Run();