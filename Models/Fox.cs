
namespace ADayInTheZoo.Models;

public class Fox(string name, int age) : Animal(name, age)
{
    public override void MakeNoice() => Console.WriteLine("Yahoo");
}