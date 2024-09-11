namespace InterfaceSegregationPrinciple;

public class Manager : IEmployee, IManager
{
    public void TimeIn()
    {
        Console.WriteLine("Manager timed in");
    }

    public void Work()
    {
        Console.WriteLine("Manager worked");
    }

    public void Manage()
    {
        Console.WriteLine("Manager managed");
    }
}