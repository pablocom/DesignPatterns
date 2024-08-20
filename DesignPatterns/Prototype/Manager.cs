namespace DesignPatterns.Prototype;

public sealed class Manager : Person
{
    private readonly List<Employee> _supportedEmployees = new();

    public Manager(string name, string position, int age)
        : base(name, position, age)
    {
    }
    
    private Manager(string name, string position, int age, IEnumerable<Employee> employees)
        : base(name, position, age)
    {
        _supportedEmployees.AddRange(employees);
    }

    public void AddSupportedEmployee(Employee employee) => _supportedEmployees.Add(employee);

    public override Person Clone()
    {
        var managerClone = new Manager(Name, Position, Age, _supportedEmployees.ToList());
        return managerClone;
    }

    void Main()
    {
        var pablo = new Employee("Pablo", "Software Engineer", 27, "420");
        var manager = new Manager("Radahn", "Elden Ring Boss", 300, [pablo]);
        var managerClone = manager.Clone();
    }
}