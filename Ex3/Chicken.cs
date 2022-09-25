using System;

class Chicken
{
    string? name;
    float? age;

    public string? Name { 
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value) || (value.Trim() == string.Empty)) Console.WriteLine("Name cannot be empty.");
            else name = value;
        }
    }
    public float? Age { 
        get => age;
        set
        {
            if (value > 15 || value < 0) Console.WriteLine("Age should be between 0 and 15.");
            else age = value;
        }
    }


    string? CalculateProductPerDay(float? age)
    {
        if (age < 0.7) return "0";
        else if (age >= 0.7 && age <= 2) return "1-2";
        return "0-1";
    }

    public void ProductPerDay() => Console.WriteLine($"Chicken Mara (age {Age}) can produce {CalculateProductPerDay(Age)} eggs per day.");


    public Chicken(string? Name = "Chicken", float? Age = 1)
    {
        this.Name = Name;
        this.Age = Age;
    }
}
