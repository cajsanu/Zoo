using ADayInTheZoo.Interfaces;
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


Fox fox = new("Perry", 4);
Chicken chicken = new("Linda", 2);

List<IAnimal> animals = [fox, chicken];

app.MapGet("/animals", () =>
{
    Console.WriteLine("Getting animals");
     if (animals == null || animals.Count == 0)
    {
        return Results.Text("No animals");
    }
    // Use LINQ to join all animal names into a single string
    var animalNames = string.Join(", ", animals.Select(animal => animal.Name));

    return Results.Json(animalNames);
})
.WithName("GetAnimals")
.WithOpenApi();

app.Run();

