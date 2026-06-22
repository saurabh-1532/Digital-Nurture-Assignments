using System;
using System.Collections.Generic;

public class MarketExchange : IStockTicker
{
    private List<IStockViewer> activeViewers = new List<IStockViewer>();
    private string tickerSymbol;
    private double currentValuation;

    public MarketExchange(string symbol, double initialValuation)
    {
        tickerSymbol = symbol;
        currentValuation = initialValuation;
    }

    public void Attach(IStockViewer viewer)
    {
        activeViewers.Add(viewer);
    }

    public void Detach(IStockViewer viewer)
    {
        activeViewers.Remove(viewer);
    }

    public void Broadcast()
    {
        foreach (var viewer in activeViewers)
        {
            viewer.OnPriceChanged(tickerSymbol, currentValuation);
        }
    }

    public void UpdateValuation(double newPrice)
    {
        currentValuation = newPrice;
        Broadcast();
    }
}

public class MobileDashboard : IStockViewer
{
    public void OnPriceChanged(string symbol, double newPrice)
    {
        Console.WriteLine($"[Mobile Push Notification] {symbol} is now trading at ${newPrice:F2}");
    }
}

public class WebTerminal : IStockViewer
{
    public void OnPriceChanged(string symbol, double newPrice)
    {
        Console.WriteLine($"[Web Browser Live Feed] {symbol} updated to ${newPrice:F2}");
    }
}