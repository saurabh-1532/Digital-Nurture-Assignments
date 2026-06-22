using System;

class Program
{
    static void Main(string[] args)
    {
        MarketExchange techStock = new MarketExchange("CGZNT", 150.00);

        IStockViewer iosApp = new MobileDashboard();
        IStockViewer chromeTab = new WebTerminal();

        techStock.Attach(iosApp);
        techStock.Attach(chromeTab);

        Console.WriteLine("--- Market Open ---");
        techStock.UpdateValuation(152.50);

        Console.WriteLine("\n--- User closes the web browser ---");
        techStock.Detach(chromeTab);

        Console.WriteLine("\n--- Afternoon Trading Volatility ---");
        techStock.UpdateValuation(149.75);
    }
}