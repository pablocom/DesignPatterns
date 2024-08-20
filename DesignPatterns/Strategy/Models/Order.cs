using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy.Models;

public class Order
{
    public ShippingDetails ShippingDetails { get; }
    public decimal TotalPrice => _items.Sum(x => x.Price);

    private readonly ICollection<Item> _items = new List<Item>();
    private readonly ISalesTaxStrategy _salesTaxStrategy;

    public Order(ShippingDetails shippingDetails)
    {
        _salesTaxStrategy = shippingDetails.DestinationCountry switch
        {
            "Spain" => new SpainSalesTaxStrategy(),
            "United States" => new UsaSalesTaxStrategy(),
            _ => throw new InvalidOperationException($"Shipment to {shippingDetails.DestinationCountry} not supported.")
        };

        ShippingDetails = shippingDetails;
    }

    public void AddItem(Item item) => _items.Add(item);

    public decimal GetTax() => _salesTaxStrategy.GetTaxFor(this);
}
