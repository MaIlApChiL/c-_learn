using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Behaviour[] behaviours =
        {
            new Walker(),
            new Jumper()
        };

        while (true)
        {
            foreach (var behaviour in behaviours)
            {
                behaviour.Update();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

class Behaviour
{
    public virtual void Update()
    {

    }
}

class Walker : Behaviour
{
    public override void Update()
    {
        Console.WriteLine("Иду");
    }
}

class Jumper : Behaviour
{
    public override void Update()
    {
        Console.WriteLine("Прыгаю");
    }
}
