using System;

class Toppings
{
    string? type;
    public string? Type { get => type; set => type = value; }

    float? weight;
    public float? Weight { get => weight; set => weight = value; }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public float CaltulateCalories(Toppings toppings)
    {
        if (toppings.Type == "Meat")
            return (float)(toppings.Weight * 1.2);
        else if (toppings.Type == "Veggies")
            return (float)(toppings.Weight * 0.8);
        else if (toppings.Type == "Cheese")
            return (float)(toppings.Weight * 1.1);
        else if (toppings.Type == "Sauce")
            return (float)(toppings.Weight * 0.9);


        return (float)(toppings.Weight);
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public Toppings(string? Type = "Meat", float? Weight = 100.0f)
    {
        this.Type = Type;
        this.Weight = Weight;
    }
}
