using System;

public interface INotificationService
{
    void Dispatch(string messageContent);
}

public class EmailService : INotificationService
{
    public void Dispatch(string messageContent)
    {
        Console.WriteLine($"[Email Sent]: {messageContent}");
    }
}