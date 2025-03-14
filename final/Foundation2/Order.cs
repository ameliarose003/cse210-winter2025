public class Order
{
    private List<Customer> _customers = new List<Customer>();
    private List<Products> _products = new List<Products>();
    public Address _address = new Address();

    public Order()
    {

    }

    public void SetProduct(Products products)
    {
        _products.Add(products);
    }

    public void SetCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public int GetTotalPrice()
    {
        int total = 0;
        foreach (Products product in _products)
        {
            total += product.GetTotalCost();
        }
        return total;


    }

    public bool IsUsaOrder(Address address)
    {
        return address.InUsa();
    }

    public int GetShippingCost(Address address)
    {
        int orderShipping = 0;
        if (IsUsaOrder(address) == true)
        {
            orderShipping = 5;
        }
        else orderShipping = 35;
        return orderShipping;
    }

    public int GetTotalAndShippingCost(Address address)
    {
        int productsPrice = GetTotalPrice();
        int shipping = GetShippingCost(address);
        int orderTotal = productsPrice + shipping;
        return orderTotal;
    }

    public void GetPackageLabel()
    {
        foreach (Products product in _products)
        {
            Console.WriteLine($"{product.GetProductName}, id: {product.GetProductId}");
        }
    }

    public void GetShippingLabel()
    {

    }


}