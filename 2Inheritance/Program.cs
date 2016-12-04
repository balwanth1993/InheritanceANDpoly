using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    
    public virtual void Print()
    {
        Console.WriteLine("Employee name is : {0}  {1}", FirstName, LastName);
    }

}

public class FullTimeEmployee : Employee
{
    public int YearlySalary;
    public override void Print()
    {
        Console.WriteLine("FullTime Employee Name is  {0}  {1}", FirstName, LastName);
    }
}
public class ParttimeEmployee : Employee
{
    public int HourlySalary;
    public override void Print()
    {
        Console.WriteLine("PartTime Employee Name is  {0}  {1}", FirstName, LastName);
    }
}
class Program
{
    public static void Main()
    {
        FullTimeEmployee emp = new FullTimeEmployee();
        emp.FirstName = "Balwanth";
        emp.LastName = "Likki";
        emp.YearlySalary = 50000;
        emp.Print();

        ParttimeEmployee emp1 = new ParttimeEmployee();
        emp1.FirstName = "Suresh";
        emp1.LastName = "Ramesh";
        emp1.HourlySalary = 50;
        emp1.Print();
    }
}
