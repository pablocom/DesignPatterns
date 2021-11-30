using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy.Strategies;

public class USASalesTaxStrategy : ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order)
    {
        switch (order.ShippingDetails.DestinationState)
        {
            case "NY":
                return order.TotalPrice + 10.5m;
            case "LA":
                return order.TotalPrice + 25m;
            default: 
                return order.TotalPrice;
        }
    }
}