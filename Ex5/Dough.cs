using System;

class Dough
{
    string? typeOne;
    public string? TypeOne { get => typeOne; set => typeOne = value; }

    string? typeTwo;
    public string? TypeTwo { get => typeTwo; set => typeTwo = value; }


    float? weight;
    public float? Weight { get => weight; set => weight = value; }



    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public float CaltulateCalories(Dough dough)
    {
        if(dough.TypeOne == "White")
        {
            if (dough.typeTwo == "homemade")
                return (float)(dough.Weight * 1.5 * 1.0);
            else if (dough.typeTwo == "chewy")
                return (float)(dough.Weight * 1.5 * 1.1);
            else if (dough.typeTwo == "crispy")
                return (float)(dough.Weight * 1.5 * 0.9);
        }
        else if (dough.TypeOne == "Wholegrain")
        {
            if (dough.typeTwo == "homemade")
                return (float)(dough.Weight * 1.0 * 1.0);
            else if (dough.typeTwo == "chewy")
                return (float)(dough.Weight * 1.0 * 1.1);
            else if (dough.typeTwo == "crispy")
                return (float)(dough.Weight * 1.0 * 0.9);
        }


        return (float)(dough.Weight);
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public Dough(string? TypeOne = "White", string? TypeTwo = "homemade", float? Weight = 100.0f)
    {
        this.TypeOne = TypeOne;
        this.TypeTwo = TypeTwo;
        this.Weight = Weight;
    }
}
