using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        NonPlayerCharacter[] characters = 
        {
            new NonPlayerCharacter(),
            new Farmer(),
            new Knight(),
            new Child()
        };

        foreach (NonPlayerCharacter character in characters)
        {
            character.ShowDescription();
            Console.WriteLine(new string('-', 40));
        }
    }
}

class NonPlayerCharacter
{
    public virtual void ShowDescription()
    {
        Console.WriteLine("Я простой NPC, умею только гулять");
    }
}

class Farmer : NonPlayerCharacter
{
    public override void ShowDescription()
    {
        base.ShowDescription();
        Console.WriteLine("А ещё я умею работать на поле");
    }
}

class Knight : NonPlayerCharacter
{
    public override void ShowDescription()
    {
        Console.WriteLine("Я рыцарь, моё дело только сражения!");
    }
}

class Child : NonPlayerCharacter
{

}
