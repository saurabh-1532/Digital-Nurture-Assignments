using System;

public abstract class NotificationWrapper : INotificationService
{
    protected INotificationService internalService;

    public NotificationWrapper(INotificationService serviceToWrap)
    {
        internalService = serviceToWrap;
    }

    public virtual void Dispatch(string messageContent)
    {
        internalService.Dispatch(messageContent);
    }
}

public class SmsWrapper : NotificationWrapper
{
    public SmsWrapper(INotificationService serviceToWrap) : base(serviceToWrap) { }

    public override void Dispatch(string messageContent)
    {
        base.Dispatch(messageContent);
        Console.WriteLine($"[SMS Alert Texted]: {messageContent}");
    }
}

public class SlackWrapper : NotificationWrapper
{
    public SlackWrapper(INotificationService serviceToWrap) : base(serviceToWrap) { }

    public override void Dispatch(string messageContent)
    {
        base.Dispatch(messageContent);
        Console.WriteLine($"[Slack Channel Ping]: {messageContent}");
    }
}