using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Cart cart = new Cart();
        cart.ShowProducts();

        List<Product> products = new List<Product>();

        for (int i = 0; i <  cart.GetProductsCount(); i++)
        {
            products.Add(cart.GetProductByIndex(i));
        }

        products.RemoveAt(0);

        Console.WriteLine();
        cart.ShowProducts();

        List<Product> products1 = cart.GetProducts();

        
        for (int i = 0; i <  cart.GetProductsCount(); i++)
        {
            Console.Write($" !{products1[i].Name}! ");
        }

        Console.WriteLine();
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

    public int GetProductsCount()
    {
        return _products.Count;
    }

    public Product GetProductByIndex(int index)
    {
        return _products.ElementAt(index);
    }

    public List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();
        for (int i = 0; i < GetProductsCount(); i++)
        {
            products.Add(GetProductByIndex(i));
        }
        return products;
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