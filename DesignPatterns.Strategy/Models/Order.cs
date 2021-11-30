using DesignPatterns.Strategy.Strategies;

namespace DesignPatterns.Strategy.Models;

public class Order
{
    public ShippingDetails ShippingDetails { get; }
    public decimal TotalPrice => Items.Sum(x => x.Price);

    private ICollection<Item> Items = new List<Item>();
    private ISalesTaxStrategy salesTaxStrategy;

    public Order(ShippingDetails shippingDetails)
    {
        switch (shippingDetails.DestinationCountry)
        {
            case "Spain":
                salesTaxStrategy = new SpainSalesTaxStrategy();
                break;
            case "United States":
                salesTaxStrategy = new USASalesTaxStrategy();
                break;
            default:
                throw new InvalidOperationException($"Shipment to {shippingDetails.DestinationCountry} not supported.");
        }

        ShippingDetails = shippingDetails;
    }

    public void AddItem(Item item) => Items.Add(item);

    public decimal GetTax() => salesTaxStrategy.GetTaxFor(this);
}
