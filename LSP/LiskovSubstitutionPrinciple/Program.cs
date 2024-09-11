namespace LiskovSubstitutionPrinciple;

public class Program
{
    static void Main(string[] args)
    {
        Admin admin = new Admin("Admin");
        Employee Employee = new Employee("Employee");
        DoSomething(admin);
        DoSomething(Employee);
    }

    public static void DoSomething(User user)
    {
        user.LogIn();
        user.AccessByRole();
        user.LogOut();
    }
    public class User
    {
        private string _name;
        public User(string name)
        {
            _name = name;
        }
        public void LogIn()
        {
            Console.WriteLine($"{_name} Logged in");
        }
        public void LogOut()
        {
            Console.WriteLine($"{_name} Logged out");
        }
        public virtual void AccessByRole()
        {
        }
    }

    public class Admin : User
    {
        public Admin(string name) : base(name)
        {
        }

        public override void AccessByRole()
        {
            Console.WriteLine("Admin accessed this");
        }
    }

    public class Employee : User
    {
        public Employee(string name) : base(name)
        {
        }

        public override void AccessByRole()
        {
            Console.WriteLine("Employee cannot access this");
        }
    }
}