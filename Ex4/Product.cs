using System;

class Product
{
    string? name;
    float? price;

    public string? Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value) || (value.Trim() == string.Empty)) Console.WriteLine("Name cannot be empty.");
            else name = value;
        }
    }
    public float? Price
    {
        get => price;
        set
        {
            if (value < 0) Console.WriteLine("Money cannot be negative.");
            else price = value;
        }
    }

    public void InputProduct(Product[] ArrayProduct)
    {
        for (int i = 0; i < ArrayProduct.Length; i++)
        {
            if (ArrayProduct[i] == null) ArrayProduct[i] = new Product();

            Console.Write("Name: ");
            ArrayProduct[i].Name = Console.ReadLine();

            Console.Write("Price: ");
            ArrayProduct[i].Price = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine();
        }
    }

    public Product(string? Name = "Undefined", float? Price = null) {
        this.Name = Name;
        this.Price = Price;
    }
}