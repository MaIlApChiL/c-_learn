using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> pat = new Queue<string>();

        pat.Enqueue("Vasya");
        pat.Enqueue("Petrovich");
        pat.Enqueue("Bomj");
        pat.Enqueue("Brodyaga");

        foreach (string p in pat)
        {
            Console.WriteLine(p); 
        }

        Console.WriteLine();

        Stack<string> pat1 = new Stack<string>();

        pat1.Push("Vasya");
        pat1.Push("Petrovich");
        pat1.Push("Bomj");
        pat1.Push("Brodyaga");

        Console.WriteLine(pat1.Pop());

        foreach (string p in pat1)
        {
            Console.WriteLine(p); 
        }
    }
}
