namespace ADayInTheZoo.Interfaces;

public enum Sex
{
    female,
    male
}
public interface IAnimal
{
    string Name { get; set; }
    int Age { get; set; }
    Sex Sex {get; set;}
    void MakeNoice();
}