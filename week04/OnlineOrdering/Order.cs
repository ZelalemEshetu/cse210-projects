using System;
using System.Collections.Generic;

public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        double shipping = customer.IsInUSA() ? 5 : 35;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (var product in products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{customer.GetName()}\n{customer.GetAddressString()}";
    }
}
