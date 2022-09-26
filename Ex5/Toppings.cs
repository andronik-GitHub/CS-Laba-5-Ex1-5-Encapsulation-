using System;

class Toppings
{
    string? type;
    public string? Type { 
        get => type;
        set
        {
            while ((string.IsNullOrEmpty(value) || (value.Trim() == string.Empty)) ||
                (value.ToLower() != "meat" && 
                value.ToLower() != "veggies" && 
                value.ToLower() != "cheese" && 
                value.ToLower() != "sauce"))
            {
                Console.Write("\nCannot place {0} on top of your pizza.\nToppings: ", value);
                value = Console.ReadLine();
            }
            type = value;
        }
    }

    float? weight;
    public float? Weight { 
        get => weight;
        set
        {
            while ((value < 1 || value > 50) || value == null)
            {
                Console.Write("\n{0} weight({1}) should be in the range [1..50]. \nWeight toppings: ", Type, value);
                value = Convert.ToSingle(Console.ReadLine());
            }
            weight = value;
        }
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void Output(Toppings toppings)
    {
        Console.WriteLine("{0} {1:0.00} - {2:0.00}", toppings.Type, toppings.Weight, toppings.CaltulateCalories(toppings));
    }

    public void Input(Toppings toppings)
    {
        Console.Write("Toppings: ");
        toppings.Type = Console.ReadLine();

        Console.Write("Weight toppings: ");
        toppings.Weight = Convert.ToSingle(Console.ReadLine());
    }

    public float? CaltulateCalories(Toppings toppings)
    {
        if (toppings.Type == "Meat" || toppings.Type == "meat")
            return (toppings.Weight * 2) * 1.2f;
        else if (toppings.Type == "Veggies" || toppings.Type == "veggies")
            return (toppings.Weight * 2) * 0.8f;
        else if (toppings.Type == "Cheese" || toppings.Type == "cheese")
            return (toppings.Weight * 2) * 1.1f;
        else if (toppings.Type == "Sauce" || toppings.Type == "sauce")
            return (toppings.Weight * 2) * 0.9f;


        return toppings.Weight;
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public Toppings(string? Type = "Meat", float? Weight = 25.0f)
    {
        this.Type = Type;
        this.Weight = Weight;
    }
}
