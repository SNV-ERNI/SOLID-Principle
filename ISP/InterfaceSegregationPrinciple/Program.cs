namespace InterfaceSegregationPrinciple;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager();
        Employee employee = new Employee();
        Admin admin = new Admin();

        DoWork(manager);
        DoWork(employee);
        DoWork(admin);

        Manage(manager);
        DeleteUser(admin);
    }

    public static void DoWork(IEmployee employee)
    {
        employee.TimeIn();
        employee.Work();
    }

    public static void Manage(IManager manager)
    {
        manager.Manage();
    }

    public static void DeleteUser(IAdmin admin)
    {
        admin.DeleteUser();
    }
}