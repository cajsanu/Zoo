
using ADayInTheZoo.Interfaces;

namespace ADayInTheZoo.Models;

public class Fox(string name, int age, Sex sex) : Animal(name, age, sex)
{
    public override void MakeNoice() => Console.WriteLine("Yahoo");
}