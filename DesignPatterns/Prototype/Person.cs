namespace DesignPatterns.Prototype;

public abstract class Person
{
    public string Name { get; }
    public string Position { get; private set; }
    public int Age { get; }

    protected Person(string name, string position, int age)
    {
        Name = name;
        Position = position;
        Age = age;
    }

    public abstract Person Clone();
}