namespace DesignPatterns.Strategy.Models;

public class Item
{
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; }
    public ItemType ItemType { get; }

    public Item(string name, string description, decimal price, ItemType itemType)
    {
        Name = name;
        Description = description;
        Price = price;
        ItemType = itemType;
    }
}
