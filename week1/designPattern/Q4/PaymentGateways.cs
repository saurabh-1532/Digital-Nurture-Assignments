using System;

public interface ITransactionProcessor
{
    void ExecuteTransaction(decimal amount);
}

public class StripeService
{
    public void ChargeCard(decimal totalAmount)
    {
        Console.WriteLine($"Stripe: Successfully charged ${totalAmount} to the credit card.");
    }
}

public class PayPalSystem
{
    public void TransferFunds(decimal paymentAmount)
    {
        Console.WriteLine($"PayPal: Transferred ${paymentAmount} via secure user wallet.");
    }
}