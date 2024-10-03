namespace ADayInTheZoo.Interfaces;


public interface IAnimal
{
    string Name { get; set; }
    int Age { get; set; }
    void MakeNoice();
}