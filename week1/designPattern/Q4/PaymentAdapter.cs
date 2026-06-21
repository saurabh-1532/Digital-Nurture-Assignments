public class StripeAdapter : ITransactionProcessor
{
    private readonly StripeService stripeSystem;

    public StripeAdapter(StripeService stripeSystem)
    {
        this.stripeSystem = stripeSystem;
    }

    public void ExecuteTransaction(decimal amount)
    {
        stripeSystem.ChargeCard(amount);
    }
}

public class PayPalAdapter : ITransactionProcessor
{
    private readonly PayPalSystem paypalSystem;

    public PayPalAdapter(PayPalSystem paypalSystem)
    {
        this.paypalSystem = paypalSystem;
    }

    public void ExecuteTransaction(decimal amount)
    {
        paypalSystem.TransferFunds(amount);
    }
}