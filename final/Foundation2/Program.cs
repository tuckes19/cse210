using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _orders = new List<Order>();

        Address address1 = new Address("8138 Spearman Road", "Browns Summit", "NC", "USA");
        Address address2 = new Address("2645 Fox Creek Drive", "Lima", "OH", "USA");

        Customer customer1 = new Customer("Ronald Tucker", address1);
        Customer customer2 = new Customer("Ronda Tucker", address2);

        Product product1 = new Product("Lego Set", 4526, 20, 2);
        Product product2 = new Product("Mega Blocks", 666, 20, 1);
        Product product3 = new Product("Nintendo Wii", 89420, 250, 3);
        Product product4 = new Product("Super Mario Galaxy", 6900, 50, 1);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.GetProductList().Add(product1);
        order1.GetProductList().Add(product2);
        order2.GetProductList().Add(product3);
        order2.GetProductList().Add(product4);

        _orders.Add(order1);
        _orders.Add(order2);

        foreach (Order order in _orders)
        {
            order.ProducePackingLabel();
            order.ProduceShippingLabel();
            Console.WriteLine($"Total Cost: ${order.ComputeTotalCost()}");
            Console.WriteLine("");
        }
    }
}