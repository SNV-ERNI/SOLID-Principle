public class Notification
{
    private readonly IEmailService _emailService;

    public Notification(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void PromotionalNotification()
    {
        var content = "You have won a gift!";
        _emailService.SendEmail(content);
    }
}