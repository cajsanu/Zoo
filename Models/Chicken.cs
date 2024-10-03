
using ADayInTheZoo.Interfaces;

namespace ADayInTheZoo.Models;

public class Chicken(string name, int age, Sex sex) : Animal(name, age, sex)
{
    public override void MakeNoice() => Console.WriteLine("Cot cot");
}