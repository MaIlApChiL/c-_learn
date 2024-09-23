using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Cart cart = new Cart();
        cart.ShowProducts();

    }
}

class Cart
{
    private List<Product> _products = new List<Product>();

    public Cart()
    {
        _products.Add(new Product("Яблоко"));
        _products.Add(new Product("Банан"));
        _products.Add(new Product("Апельсин"));
        _products.Add(new Product("Груша"));
    }

    public void ShowProducts()
    {
        Console.Write($"Продукты в корзине:\n{_products[0].Name}");
        foreach (Product pr in _products)
        {
            Console.Write($", {pr.Name}");
        }
    }

    public Product GetProductByIndex(int index)
    {
        return _products.ElementAt(index);
    }
}

class Product
{
    public string Name {get; private set; }

    public Product(string name)
    {
        Name = name;
    }
}