public interface IStockViewer
{
    void OnPriceChanged(string symbol, double newPrice);
}

public interface IStockTicker
{
    void Attach(IStockViewer viewer);
    void Detach(IStockViewer viewer);
    void Broadcast();
}