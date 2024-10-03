using ADayInTheZoo.Interfaces;

namespace ADayInTheZoo.Models;
public abstract class Animal(string name, int age) : IAnimal
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public abstract void MakeNoice();
}