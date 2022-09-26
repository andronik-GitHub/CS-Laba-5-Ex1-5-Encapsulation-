using System;

class Pizza
{
    string? name;
    string? Name { get => name; set => name = value; }

    Dough dough;
    Toppings toppings;


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public void OutputCalories(Pizza pizza)
    {
        Console.WriteLine($"{pizza.dough.TypeOne} {pizza.dough.TypeTwo} {pizza.dough.Weight} - {pizza.dough.CaltulateCalories(dough)}");
        Console.WriteLine($"{pizza.toppings.Type} {pizza.toppings.Weight} - {pizza.dough.CaltulateCalories(dough)}");
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public Pizza(string? Name = "Pizza Example")
    {
        this.Name = Name;

        Random rand = new Random();

        dough = new Dough((rand.Next(0, 10) >= 5 ? "White" : "Wholegrain"),
            (rand.Next(0, 10) >= 5 ? "homemade" : (rand.Next(0, 10) >= 5 ? "chewy" : "crispy")),
            ((float)(rand.NextDouble() * rand.Next(1, 200)))
            );

        toppings = new Toppings((rand.Next(0, 10) >= 5 ? "Meat" : (rand.Next(0, 10) >= 5 ? "Veggies" : (rand.Next(0, 10) >= 5 ? "Cheese" : "Sauce"))),
            ((float)(rand.NextDouble() * rand.Next(1, 50)))
            );
    }
}
