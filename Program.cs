using ADayInTheZoo.Interfaces;
using ADayInTheZoo.Middleware;
using ADayInTheZoo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<RequestLoggerMiddleware>();


Fox fox1 = new("Perry", 4, Sex.male);
Fox fox2 = new("Pernilla", 3, Sex.female);
Chicken chicken = new("Linda", 2, Sex.female);

List<IAnimal> animals = [fox1, fox2, chicken];

app.MapGet("/animals", () =>
{
    Console.WriteLine("Getting animals");
    if (animals == null || animals.Count == 0)
    {
        return Results.Text("No animals");
    }
    // Use LINQ to join all animal names into a single string
    var animalNames = string.Join(", ", animals.Select(animal => $"{animal.Name} who is a {animal.GetType().Name}"));

    return Results.Text(animalNames);
})
.WithName("GetAnimals")
.WithOpenApi();

app.Run();

