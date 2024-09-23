using System;
using System.Linq;
using System.Collections.Generic;
// То что класс Board имеет в себе класс Task, а Task имеет в себе класс Performer, и является связью Has-A
class Program
{
    static void Main()
    {
        Knight knight = new Knight(100, 10);
        Barbarian barbarian = new Barbarian(125, 1, 7);


    }
}

class Warrior
{
    protected int Health;
    protected int Armor;
    protected int Damage;

    protected Warrior(int health, int armor, int damage)
    {
        Health = health;
        Armor = armor;
        Damage = damage;
    }

    protected void TakeDamage(int damage)
    {
        Health -= damage - Armor;
    }

    protected void ShowInfo()
    {
        Console.WriteLine(Health);
    }
}

class Knight : Warrior
{
    public Knight(int health, int damage) : base(health, 5, damage) {}
    public void Pray()
    {
        Armor += 2;
    }
}

class Barbarian : Warrior
{
    public Barbarian(int health, int armor, int damage) : base(health, armor, damage) {}

    public void Shout()
    {
        Armor -= 2;
        Health += 10;
    }
}
