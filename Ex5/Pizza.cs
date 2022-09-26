using System;

class Pizza
{
    string? name;
    public string? Name 
    { 
        get => name; 
        set
        {
            while((string.IsNullOrEmpty(value) || (value.Trim() == string.Empty)) ||
                (value.Length < 1 || value.Length > 15))
            {
                Console.Write("Pizza name should be between 1 and 15 symbols.\nName pizza: ");
                value = Console.ReadLine();
            }
            name = value;
        }
    }

    float? calories;
    public float? Calories { get => calories; set => calories = value; }

    int numberToppings;
    public int NumberToppings { 
        get => numberToppings;
        set 
        {
            if (value >= 10) Console.WriteLine("\nNumber of toppings should be in range [0..10].\n");
            else numberToppings = value;
        }
    }

    Dough dough { get; set; }
    Toppings[] toppings = new Toppings[10];


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public float? CalculatedTotalCalories(Pizza pizza)
    {
        float? sumCalories = 0;
        for (int i = 0; i < pizza.NumberToppings; i++)
            sumCalories += pizza.toppings[i].CaltulateCalories(pizza.toppings[i]);

        return pizza.dough.CaltulateCalories(pizza.dough) + sumCalories;
    }

    public void OutputCalories(Pizza pizza)
    {
        Console.WriteLine("{0} - {1:0.00} Calories", pizza.Name, pizza.CalculatedTotalCalories(pizza));
    }

    public void Input(Pizza pizza)
    {
        Console.Write("Name pizza: ");
        pizza.Name = Console.ReadLine();
        Console.WriteLine();

        pizza.dough.Input(pizza.dough);
        Console.WriteLine();


        string? action = "";
        int? temp = 0;

        while (action != "END" && action != "End" && action != "end")
        {
            if (temp < 10)
            {
                if (pizza.toppings[pizza.NumberToppings] == null)
                    pizza.toppings[pizza.NumberToppings] = new Toppings();

                pizza.toppings[pizza.NumberToppings].Input(pizza.toppings[pizza.NumberToppings]);

                temp = pizza.NumberToppings + 1;
                pizza.NumberToppings++;
            }

            action = Console.ReadLine();
        }
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public Pizza(string? Name = "Pizza Example", float? Calories = 0.0f, int NumberToppings = 0)
    {
        this.Name = Name;
        this.Calories = Calories;
        this.NumberToppings = NumberToppings;

        Random rand = new Random();

        dough = new Dough(  (rand.Next(0, 10) >= 5 ? "White" : "Wholegrain"),
                            (rand.Next(0, 10) >= 5 ? "homemade" : 
                            (rand.Next(0, 10) >= 5 ? "chewy" : "crispy")),
                            ((float)(rand.NextDouble() + 1) * rand.Next(1, 100)) // 1 - 200, 1-100 тому що 1.99 * 200 = 380, а 1.99 * 100 = 199
                            );

        for (int i = 0; i < NumberToppings; i++)
            toppings[i] = new Toppings( (rand.Next(0, 10) >= 5 ? "Meat" : 
                                        (rand.Next(0, 10) >= 5 ? "Veggies" : 
                                        (rand.Next(0, 10) >= 5 ? "Cheese" : "Sauce"))),
                                        ((float)(rand.NextDouble() + 1) * rand.Next(1, 25)) // 1 - 50, 1-25 тому що 1.99 * 50 = 99.5, а 1.99 * 25 = 49.75
                                        );
    }
}
