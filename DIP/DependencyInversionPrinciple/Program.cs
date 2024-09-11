class Program
{
    static void Main()
    {
        IEmailService emailService = new EmailService();
        Notification notification = new Notification(emailService);

        notification.PromotionalNotification();
    }
}