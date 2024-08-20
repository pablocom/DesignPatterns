namespace DesignPatterns.Prototype;

public sealed class Employee : Person
{
    public string PropertyThatOnlyAppliesForEmployees { get; private set; }

    public Employee(string name, string position, int age, string propertyThatOnlyAppliesForEmployees)
        : base(name, position, age)
    {
        PropertyThatOnlyAppliesForEmployees = propertyThatOnlyAppliesForEmployees;
    }


    public override Person Clone()
    {
        var employeeClone = new Employee(Name, Position, Age, PropertyThatOnlyAppliesForEmployees);
        return employeeClone;
    }
}