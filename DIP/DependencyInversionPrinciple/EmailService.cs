public class EmailService : IEmailService
{
    public void SendEmail(string emailContent)
    {
        Console.WriteLine("Email: " + emailContent);
    }
}