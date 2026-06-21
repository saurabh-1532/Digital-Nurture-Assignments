using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Initializing Payment Routing System ---\n");

        ITransactionProcessor cardPayment = new StripeAdapter(new StripeService());
        cardPayment.ExecuteTransaction(150.75m);

        ITransactionProcessor digitalWalletPayment = new PayPalAdapter(new PayPalSystem());
        digitalWalletPayment.ExecuteTransaction(89.99m);
    }
}