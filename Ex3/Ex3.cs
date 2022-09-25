using System;
using System.Xml.Linq;

class Ex3
{
    static void Main()
    {
        Chicken chicken = new();

        chicken.Name = Console.ReadLine();
        chicken.Age = Convert.ToSingle(Console.ReadLine());

        chicken.ProductPerDay();


        Console.ReadKey();
    }
}