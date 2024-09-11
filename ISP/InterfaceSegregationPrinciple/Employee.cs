public class Employee : IEmployee
{
    public void TimeIn()
    {
        Console.WriteLine("Employee timed in");
    }

    public void Work()
    {
        Console.WriteLine("Employee worked");
    }
}