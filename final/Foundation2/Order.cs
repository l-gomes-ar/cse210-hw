public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    public double CalculateTotalCost()
    {
        double totalCost;
        // Calculate total price
        totalCost = GetProductsCost(); 

        // If customer in USA, $5, else $35 for shipping
        if (_customer.LivesInAmerica())
        {
            totalCost += 5;
        }
        else 
        {
            totalCost += 35;
        }

        return Math.Round(totalCost, 2);
    }

    private double GetProductsCost()
    {
        double cost= 0;
        foreach (Product product in _products)
        {
            cost += product.GetTotalCost(); 
        }

        return cost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"Product: '{product.GetName()}', Product Id: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddressString()}";
    }
}