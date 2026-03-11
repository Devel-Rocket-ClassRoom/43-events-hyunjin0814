using System;

class Stock
{
    private string symbol;
    private decimal price;

    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    public Stock(string symbol, decimal price)
    {
        this.symbol = symbol;
        this.price = price;
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (price == value)
            {
                return;
            }

            decimal oldPrice = price;
            price = value;

            OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
        }
    }

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public override string ToString()
    {
        return $"{symbol}: {price:C}";
    }
}