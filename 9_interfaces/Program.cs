using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
    }
}

interface IMovable
{
    void Move();
    void ShowMoveSpeed();
}

interface IBurnable
{
    void Burn();
}

class Vehicle
{

}

class Car : Vehicle, IMovable, IBurnable
{
    public void Move()
    {

    }

    public void ShowMoveSpeed()
    {

    }

    public void Burn()
    {

    }
}

class Human : IMovable
{
    public void Move()
    {

    }

    public void ShowMoveSpeed()
    {

    }
}