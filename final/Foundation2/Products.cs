public class Products
{
    private string _productName;
    private int _productId;
    private int _pricePerUnit;
    private int _quantity;

    public Products(string productName, int id, int pricePerUnit, int quantity)
    {
        _productName = productName;
        _productId = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string ProductInfo()
    {
        return $"{_productName}: #{_productId}, ${_pricePerUnit}, quantity: {_quantity}";
    }

    public int GetTotalCost()
    {
        int total = _pricePerUnit * _quantity;
        return total;
    }

    public string GetProductName { get { return _productName; } }
    public int GetProductId { get { return _productId; } }
    // public int GetPricePerUnit { get { return _pricePerUnit; } }
    // public int GetQuantity { get { return _quantity; } }
}