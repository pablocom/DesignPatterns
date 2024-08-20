using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy.Strategies;

public interface ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order);
}
