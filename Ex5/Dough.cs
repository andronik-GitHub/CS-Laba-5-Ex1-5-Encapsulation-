using System;

class Dough
{
    string? type;
    public string? Type 
    { 
        get => type; 
        set
        {
            while((string.IsNullOrEmpty(value) || (value.Trim() == string.Empty)) ||
                ((value.ToLower() != "white") && (value.ToLower() != "wholegrain")))
            {
                Console.Write("\nInvalid type of dough.\nDough: ");
                value = Console.ReadLine();
            }
            type = value;
        }
    }

    string? technique;
    public string? Technique 
    { 
        get => technique;
        set
        {
            while ((string.IsNullOrEmpty(value) ||  (value.Trim() == string.Empty)) ||
                ((value.ToLower() != "homemade") &&
                (value.ToLower() != "chewy") &&
                (value.ToLower() != "crispy")))
            {
                Console.Write("\nInvalid type of dough.\nBaking technique: ");
                value = Console.ReadLine();
            }
            technique = value;
        }
    }


    float? weight;
    public float? Weight 
    { 
        get => weight;
        set
        {
            while ((value < 1 || value > 200) || value == null)
            {
                Console.Write("\nDough weight({0}) should be in the range [1..200]. \nWeight dough: ", value);
                value = Convert.ToSingle(Console.ReadLine());
            }
            weight = value;
        }
    }



    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public void Output(Dough dough) { 
        Console.WriteLine("{0} {1} {2:0.00} - {3:0.00}", dough.Type, dough.Technique, dough.Weight, dough.CaltulateCalories(dough));
    }

    public void Input(Dough dough)
    {
        Console.Write("Dough: ");
        dough.Type = Console.ReadLine();

        Console.Write("Baking technique: ");
        dough.Technique = Console.ReadLine();

        Console.Write("Weight dough: ");
        dough.Weight = Convert.ToSingle(Console.ReadLine());
    }

    public float? CaltulateCalories(Dough dough)
    {
        if (dough.Type == "white" || dough.Type == "White")
        {
            if (dough.Technique == "homemade" || dough.Technique == "Homemade")
                return (dough.Weight * 2) * 1.5f * 1.0f;
            else if (dough.Technique == "chewy" || dough.Technique == "Chewy")
                return (dough.Weight * 2) * 1.5f * 1.1f;
            else if (dough.Technique == "crispy" || dough.Technique == "Crispy")
                return (dough.Weight * 2) * 1.5f * 0.9f;
        }
        else if (dough.Type == "wholegrain" || dough.Type == "Wholegrain")
        {
            if (dough.Technique == "homemade" || dough.Technique == "Homemade")
                return (dough.Weight * 2) * 1.0f * 1.0f;
            else if (dough.Technique == "chewy" || dough.Technique == "Chewy")
                return (dough.Weight * 2) * 1.0f * 1.1f;
            else if (dough.Technique == "crispy" || dough.Technique == "Crispy")
                return (dough.Weight * 2) * 1.0f * 0.9f;
        }


        return dough.Weight;
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public Dough(string? Type = "White", string? Technique = "homemade", float? Weight = 100.0f)
    {
        this.Type = Type;
        this.Technique = Technique;
        this.Weight = Weight;
    }
}
