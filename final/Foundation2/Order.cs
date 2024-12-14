using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCostOfProduct();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.CompleteProduct() + "\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.CompleteCustomer()}";
    }
}