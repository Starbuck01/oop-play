public static void Main(string[] args)
{
    
    object Employee;
    Console.write("Whats your name? ");
    Employee.name  = Console.ReadLine();
    Console.write("Where do you work? ");
    Employee.employer = Console.ReadLine();
    Console.write("What is your job title? ");
    Employee.job = Console.ReadLine();
    Console.write("What year were you hired? ");
    Employee.hired = Console.ReadLine();
    Employees:Employee.job();


}

public class Employees:Engineer
{
    public  void getWage()
    {
        Employee.wage  = 1000;
        Employee.proffession = "Engineer";
        Employee.hours = 40;
    }
}
public class Employees:Operator
{
    public void getWage()
    {
        Employee.wage = 2000;
        Employee.proffession = "Operator";
        Employee.hours = 35;
    }
}
public class Employees:Accountant
{
    public void getWage()
    {
        Employee.wage = 1500;
        Employee.proffession = "Accountant";
        Employee.hours =60;
    }
}