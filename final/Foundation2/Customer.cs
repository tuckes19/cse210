public class Customer
{
    // Attributes.
    string _customerName;
    Address _customerAddress;


    // Constructors.
    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    // Methods.
    public string GetCustomerName()
    {
        return _customerName;
    }
    public Address GetAddress()
    {
        return _customerAddress;
    }
    public bool USAorNot(Address address)
    {
        bool usaOrNot = address.USAorNot();
        return usaOrNot;
    }
    
}