var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barabara Oak", "Xenobiology", 21500),
    new Employee("Nisha Patel", "Mechanics", 21000),
    new Employee("Gustavo Sanchez", "Mechanics", 20000)
};

var averageSalary = CalculateAverageSalaryDepartment(employees);

Dictionary<string, decimal> CalculateAverageSalaryDepartment(List<Employee> employees)
{
    var employeesPerDepartments = new Dictionary<string, List<Employee>>();
    foreach (var employee in employees)
    {
        if (!employeesPerDepartments.ContainsKey(employee.Department))
        {
            employeesPerDepartments[employee.Department] = new List<Employee>();
        }
        employeesPerDepartments[employee.Department].Add(employee);
    }
    var result = new Dictionary<string, decimal>();
    foreach (var employeesPerDepartment in employeesPerDepartments)
    {
        decimal sumOfSalaries = 0;
        foreach (var employee in employeesPerDepartment.Value)
        {
            sumOfSalaries +=  employee.Salary;
        }
        result[employeesPerDepartment.Key] = sumOfSalaries / employeesPerDepartment.Value.Count;
    }
    return result;
}

Console.ReadKey();


internal class Employee(string name, string department, decimal salary)
{
    public string Name { get; set; } = name;
    public string Department { get; set; } = department;
    public decimal Salary { get; set; } = salary;
}