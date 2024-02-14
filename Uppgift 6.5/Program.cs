using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nu ska du skriva in ord");
        Console.WriteLine();
        Console.WriteLine("Skriv");
        string x = Console.ReadLine();
        Console.WriteLine("Skriv igen");
        string y = Console.ReadLine();
        Console.WriteLine($"Det som var längst var: {Längst(x,y)}");
        
        
        
    }

    static string Längst(string x, string y)
    {
        if (x.Length > y.Length)
        {
            return x;
        }
        else if (x.Length == y.Length)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    static double Längst(double x, double y)
    {
        if (x > y)
        {
            return x;
        }
        else if (x == y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}