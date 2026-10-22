namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message);
}

public class EmailNotification : INotificationChannel
{
    public  void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsNotification : INotificationChannel
{
    public  void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}


//R6
public class WhatsappNotification : INotificationChannel
{
    public  void Send(string to, string message) =>
        Console.WriteLine($"[whatsapp] {to}: {message}");
}




public class UregentNotificationDecorator : INotificationChannel
{
    private readonly INotificationChannel _innerChannel;
    public UregentNotificationDecorator(INotificationChannel innerChannel)
    {
        _innerChannel=innerChannel?? throw new ArgumentNullException(nameof(innerChannel));)
    }
    public void send(string to , string message)=> _innerChannel.Send(to,$"[Urgent] {message}")
}





public class ScheduledNotificationDecorator : INotificationChannel
{
    private readonly INotificationChannel _innerChannel;
    public DateTime SendAt { get; set; }

    public ScheduledNotificationDecorator(INotificationChannel innerChannel, DateTime sendAt)
    {
        _innerChannel = innerChannel ?? throw new ArgumentNullException(nameof(innerChannel));
        SendAt = sendAt;
    }

    public void Send(string to, string message)
    {
        
        if (_innerChannel is EmailNotification)
        {
            Console.WriteLine($"[email scheduled {SendAt:g}] {to}: {message}");
        }
        else if (_innerChannel is SmsNotification)
        {
            Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: {message}");
        }
        else
        {
            Console.WriteLine($"[scheduled {SendAt:g}] ");
            _innerChannel.Send(to, message);
        }
    }
}