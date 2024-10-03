
namespace ADayInTheZoo.Models;

public class Chicken(string name, int age) : Animal(name, age)
{
    public override void MakeNoice() => Console.WriteLine("Cot cot");
}