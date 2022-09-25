using System;

class Person
{
    private string? name;
    private float? money;
    string? bag;

    public string? Name
    {
        get => name;
        set {
            if (string.IsNullOrEmpty(value) || (value.Trim() == string.Empty)) Console.WriteLine("Name cannot be empty.");
            else name = value;
        }
    }
    public float? Money
    {
        get => money;
        set
        {
            if (value < 0) Console.WriteLine("Money cannot be negative.");
            else money = value;
        }
    }
    public string? Bag { get => bag; set => bag = value; }


    public void InputPerson(Person[] ArrayPerson)
    {
        for (int i = 0; i < ArrayPerson.Length; i++)
        {
            if (ArrayPerson[i] == null) ArrayPerson[i] = new Person();

            Console.Write("Name: ");
            ArrayPerson[i].Name = Console.ReadLine();

            Console.Write("Money: ");
            ArrayPerson[i].Money = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine();
        }
    }

    public Person(string? Name = "Undefined", float? Money = null, string? Bag = "Undefined")
    {
        this.Name = Name;
        this.Money = Money;
        this.Bag = Bag;
    }
}
