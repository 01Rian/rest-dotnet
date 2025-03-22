using Microsoft.OpenApi.Models;
using PizzaAPI.src.Repositories;
using PizzaAPI.src.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(option =>
{
  option.AddPolicy("AllowAll", builder =>
  {
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
  });
});

builder.Services.AddEndpointsApiExplorer();

if (builder.Environment.IsDevelopment())
{
  builder.Services.AddSwaggerGen(c =>
    {
      c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pizza API", Description = "Keep track of your Pizzas", Version = "v1" });
      c.TagActionsBy(api => ["Pizzas API"]);
      c.OrderActionsBy(apiDesc => apiDesc.HttpMethod);
    });
}

var app = builder.Build();
app.UseCors("AllowAll");

app.UseSwagger();
app.UseSwaggerUI(c =>
 {
   c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pizza API");
 });

app.MapGet("api/pizzas/{id}", (int id) => PizzaRepository.GetPizza(id));
app.MapGet("api/pizzas", () => PizzaRepository.GetPizzas());
app.MapPost("api/pizzas", (Pizza pizza) => PizzaRepository.CreatePizza(pizza));
app.MapPut("api/pizzas", (Pizza pizza) => PizzaRepository.UpdatePizza(pizza));
app.MapDelete("api/pizzas/{id}", (int id) => PizzaRepository.RemovePizza(id));

app.Run();
