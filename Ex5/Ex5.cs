using System;

class Ex5
{
    static void Main()
    {
        Random rand = new Random();
        Console.WriteLine($"{(float)(rand.NextDouble() * rand.Next(1, 50))}\n");

        Pizza pizza = new Pizza();

        pizza.OutputCalories(pizza);
    }
}
