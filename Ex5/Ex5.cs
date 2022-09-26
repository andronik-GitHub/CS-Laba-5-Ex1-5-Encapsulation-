using System;

class Ex5
{
    static void Main()
    {
        Pizza pizza = new Pizza();


        pizza.Input(pizza);

        Console.WriteLine();

        pizza.OutputCalories(pizza);


        Console.ReadKey();
    }
}
