using DesignPatterns.Strategy.Models;

var order = new Order(new ShippingDetails("Spain", "Spain"));
order.AddItem(new Item("Some book", "Description", 100, ItemType.Literature));

var secondOrder = new Order(new ShippingDetails("United States", "United States", "NY"));
order.AddItem(new Item("Some book", "Description", 23, ItemType.Literature));

Console.WriteLine("Spain tax: " + order.GetTax());
Console.WriteLine("USA tax: " + secondOrder.GetTax());
