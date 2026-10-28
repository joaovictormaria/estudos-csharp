class Employee
{
    public string Name = "";
    public double Wage;
    public double HourWorked;

    public Employee()
    {
        HourWorked = 0;
    }
    public Employee(string name, double wage) : this()
    {
        Name = name;
        Wage = wage;
    }
    public Employee(string name, double wage, double hourWorked) : this(name, wage)
    {
        HourWorked = hourWorked;
    }
}