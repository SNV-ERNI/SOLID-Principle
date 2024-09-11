public class Admin : IEmployee, IAdmin
{
    public void TimeIn()
    {
        Console.WriteLine("Admin timed in");
    }

    public void Work()
    {
        Console.WriteLine("Admin worked");
    }

    public void DeleteUser()
    {
        Console.WriteLine("Admin deleted a user");
    }
}