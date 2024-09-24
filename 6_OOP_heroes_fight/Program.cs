using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Fighter[] fighters =
        {
            new Fighter("Максим", 500, 0, 50),
            new Fighter("Игорь", 250, 20, 25),
            new Fighter("Женя", 150, 10, 100),
            new Fighter("Артём", 300, 5, 75),
        };

        int fighterPeak1;
        int fighterPeak2;

        for (int i = 0; i < fighters.Count(); i++)
        {
            Console.Write(i + 1 + " ");
            fighters[i].ShowStats();
        }

        Console.WriteLine("\n** " + new string('-', 25) + " **");

        Console.Write("\nВыберите номер 1го бойца: ");
        fighterPeak1 = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("\nВыберите номер 2го бойца: ");
        fighterPeak2 = Convert.ToInt32(Console.ReadLine()) - 1;

        Fighter fighter_1 = fighters[fighterPeak1];
        Fighter fighter_2 = fighters[fighterPeak2];
        Console.WriteLine("\n** " + new string('-', 25) + " **");

        while (fighter_1.Health > 0 && fighter_2.Health > 0)
        {
            fighter_1.TakeDamage(fighter_2.Damage);
            fighter_2.TakeDamage(fighter_1.Damage);

            fighter_1.ShowCurrentHealth();
            fighter_2.ShowCurrentHealth();

            Console.WriteLine("\n** " + new string('-', 25) + " **");
        }

        if (fighter_1.Health < fighter_2.Health)
        {
            Console.WriteLine($"{fighter_2.Name} победил!");
        }
        else if (fighter_1.Health == fighter_2.Health)
        {
            Console.WriteLine("Ничья!");
        }
        else
        {
            Console.WriteLine($"{fighter_1.Name} победил!");
        }
    }
}

class Fighter
{
    private string _name;
    private int _health;
    private int _armor;
    private int _damage;

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public int Health
    {
        get
        {
            return _health;
        }
    }

    public int Damage
    {
        get
        {
            return _damage;
        }
    }

    public Fighter(string name, int health, int armor, int damage)
    {
        _name = name;
        _health = health;
        _armor = armor;
        _damage = damage;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Боец - {_name}, здоровье: {_health}, броня: {_armor}, наносимый урон: {_damage}");
    }

    public void ShowCurrentHealth()
    {
        Console.WriteLine($"Здоровье {_name}: {_health}");
    }

    public void TakeDamage(int damage)
    {
        if (_armor > 0)
        {
            _health -= damage / 2;
            _armor -= damage / 2;
        }
        else
        {
            _health -= damage;
        }
    }
}