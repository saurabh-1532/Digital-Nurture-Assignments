using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Standard Alert ---");
        INotificationService standardAlert = new EmailService();
        standardAlert.Dispatch("Weekly system maintenance scheduled.");

        Console.WriteLine("\n--- Urgent Alert ---");
        INotificationService urgentAlert = new SmsWrapper(new EmailService());
        urgentAlert.Dispatch("High memory usage detected on Server 04.");

        Console.WriteLine("\n--- Critical Alert ---");
        INotificationService criticalAlert = new SlackWrapper(new SmsWrapper(new EmailService()));
        criticalAlert.Dispatch("CRITICAL: Database connection lost!");
    }
}