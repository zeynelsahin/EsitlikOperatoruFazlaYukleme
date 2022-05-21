// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Employee employee1 = new Employee()
{
    Id = 1,
    FirstName = "asda",
    LastName = "asda"
};
Employee employee2 = new Employee()
{
    Id = 1,
    FirstName = "121",
    LastName = "asda"
};
employee1 = null;
if (employee1 == null)
{
    Console.WriteLine("Employee1 is null");
}
else
{
    Console.WriteLine("Employee1 is not null");
}
// if (emp1 == emp2)
// {
//     Console.WriteLine("Employee1 is equal to employee2");
// }
// else
// {
//     Console.WriteLine("Employee1 is not equal to employee2");
// }

Console.ReadKey();


public class Employee : IEquatable<Employee>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (employee1 is null && employee2 is null)
            return true;

        if ((employee1 is null && employee2 is not null)
            || (employee1 is not null && employee2 is null))
            return false;


        if (employee1.Id.Equals(employee2.Id)
            && employee1.FirstName.Equals(employee2.FirstName, StringComparison.OrdinalIgnoreCase)
            && employee1.LastName.Equals(employee2.LastName, StringComparison.OrdinalIgnoreCase)
           )
        {
            return true;
        }

        return false;
    }

    public static bool operator !=(Employee employee1, Employee employee2)
    {
        if (employee1 is null && employee2 is null)
            return false;

        if ((employee1 is null && employee2 is not null)
            || (employee1 is not null && employee2 is null))
            return true;

        if (!employee1.Id.Equals(employee2.Id)
            || !employee1.FirstName.Equals(employee2.FirstName, StringComparison.OrdinalIgnoreCase)
            || !employee1.LastName.Equals(employee2.LastName, StringComparison.OrdinalIgnoreCase)
           )
        {
            return true;
        }

        return false;
    }

    // public override bool Equals(object? obj)
    // {
    //         Employee employee= obj as Employee;
    //         if (employee!=null)
    //         {
    //             return employee.Id.Equals(this.Id);
    //         }
    //
    //         return false;
    // }
    public bool Equals(Employee? other)
    {
        if (other is null)
            return false;

        return other.Id.Equals(this.Id)
               && other.FirstName.Equals(this.FirstName, StringComparison.OrdinalIgnoreCase)
               && other.LastName.Equals(this.LastName, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return this.Id;
    }
}