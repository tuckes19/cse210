public class Product
{
    // Attributes.
    string _productName;
    int _productID;
    int _productPrice;
    int _productQuantity;

    // Constructors.
    public Product(string productName, int productID, int productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    // Methods.
    public string GetProductName()
    {
        return _productName;
    }
    public int GetProductID()
    {
        return _productID;
    }
    public int GetProductPrice()
    {
        return _productPrice;
    }
    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public int ComputeProductPrice()
    {
        int productPrice = _productPrice * _productQuantity;
        return productPrice;
    }

}