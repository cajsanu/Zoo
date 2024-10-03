using ADayInTheZoo.Interfaces;
using System;


namespace ADayInTheZoo.Models;
public abstract class Animal(string name, int age, Sex sex) : IAnimal
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public Sex Sex { get; set; } = sex;
    public abstract void MakeNoice();

}