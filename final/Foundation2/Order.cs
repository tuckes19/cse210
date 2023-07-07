public class Order
{
    // Attributes.
    int _totalPrice = 0;
    Customer _customer;
    List<Product> _products = new List<Product>();

    // Constructors.
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Methods.
    public List<Product> GetProductList()
    {
        return _products;
    }
    public int ComputeTotalCost()
    {
        foreach (Product product in _products)
        {
            _totalPrice += product.ComputeProductPrice();
        }

        if (_customer.USAorNot(_customer.GetAddress()))
        {
            _totalPrice += 5;
        }
        else
        {
            _totalPrice += 35;
        }

        return _totalPrice;
    }

    public void ProducePackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Name: {product.GetProductName()}");
            Console.WriteLine($"Product ID: {product.GetProductID()}");
            Console.WriteLine("");
        }
    }
    public void ProduceShippingLabel()
    {
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"Name: {_customer.GetCustomerName()}");
        Console.WriteLine($"Address: {_customer.GetAddress()}");
    }
    
}