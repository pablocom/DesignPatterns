using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy.Strategies;

public class SpainSalesTaxStrategy : ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order)
    {
        if (order.ShippingDetails.IsNationalShipment())
        {
            return order.TotalPrice + 10.5m;
        }

        return order.TotalPrice + 30m;
    }
}
