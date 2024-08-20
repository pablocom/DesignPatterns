using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy.Strategies;

public class UsaSalesTaxStrategy : ISalesTaxStrategy
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