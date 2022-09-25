using System;

struct Bag
{
    string? name;
    string? baG;

    public string? Name { get => name; set => name = value; }
    public string? bag { get => baG; set => baG = value; }
}

class Ex4
{
    static void Main()
    {
        Console.Write("Num person: ");
        int numPe = Convert.ToInt32(Console.ReadLine());

        Person[] people = new Person[numPe];

        for (int i = 0; i < people.Length; i++)
            if (people[i] == null) people[i] = new();

        Console.WriteLine();
        people[0].InputPerson(people);
        if (!CheckInArrPer(people, null, 0)) return;



        Console.Write("\nNum product: ");
        int numPr = Convert.ToInt32(Console.ReadLine());

        Product[] products = new Product[numPr];

        for (int i = 0; i < products.Length; i++)
            if (products[i] == null) products[i] = new();

        Console.WriteLine();
        products[0].InputProduct(products);
        if (!CheckInArrPro(products, null, 0)) return;



        Console.WriteLine();
        Shoping(people, products);




        Console.ReadKey();


        /////////////////////////////////////////////////////////////////////////////////


        void Shoping(Person[] PersonArr, Product[] ProductArr)
        {
            string? action = "";
            string? str1 = "";
            string? str2 = "";

            Bag[] bag = new Bag[PersonArr.Length];
            for (int i = 0; i < PersonArr.Length; i++)
                bag[i].Name = PersonArr[i].Name;

            while (true)
            {
                Console.Write("Name person: ");
                str1 = Console.ReadLine();
                if (!CheckInArrPer(PersonArr, str1, 1)) Console.WriteLine("This person not found!");

                Console.Write("Name product: ");
                str2 = Console.ReadLine();
                if (!CheckInArrPro(ProductArr, str2, 1)) Console.WriteLine("This product not found!");

                if (CheckInArrPer(PersonArr, str1, 1) && CheckInArrPro(ProductArr, str2, 1))
                {
                    if (CheckToShop(PersonArr, ProductArr, str1, str2))
                    {
                        Console.WriteLine("{0} bought {1}", str1, str2);
                        for (int i = 0; i < PersonArr.Length; i++)
                            if (str1 == PersonArr[i].Name)
                            {
                                if (bag[i].bag == null)
                                    bag[i].bag = str2;
                                else bag[i].bag += ", " + str2;
                            }
                    }
                    else Console.WriteLine("{0} can't afford {1}", str1, str2);
                }

                action = Console.ReadLine();
                if (action == "END" || action == "End" || action == "end") break;
            }

            Console.WriteLine();
            for (int i = 0; i < PersonArr.Length; i++)
                if (bag[i].bag == null) Console.WriteLine("{0} - Nothing bought", bag[i].Name);
                else Console.WriteLine("{0} - {1}", bag[i].Name, bag[i].bag);
        }

        bool CheckToShop(Person[] PersonArr, Product[] ProductArr, string? str1, string? str2)
        {
            for (int i = 0; i < PersonArr.Length; i++)
                if (PersonArr[i].Name == str1)
                {
                    for (int j = 0; j < ProductArr.Length; j++)
                        if (ProductArr[j].Name == str2)
                        {
                            if (PersonArr[i].Money < ProductArr[j].Price)
                                return false;
                            else PersonArr[i].Money -= ProductArr[j].Price;
                        }

                    break;
                }

            return true;
        }

        bool CheckInArrPer(Person[] PersonArr, string? str, int x)
        {
            if (x == 0)
            {
                for (int i = 0; i < PersonArr.Length; i++)
                    if (PersonArr[i].Money == null)
                        return false;

            }
            else if (x == 1)
            {
                int index = 0;

                for (int i = 0; i < PersonArr.Length; i++)
                    if (PersonArr[i].Name == str) index++;

                if (index == 0) return false;
            }

            return true;
        }

        bool CheckInArrPro(Product[] ProductArr, string? str, int x)
        {
            if (x == 0)
            {
                for (int i = 0; i < ProductArr.Length; i++)
                    if (ProductArr[i].Price == null)
                        return false;
            }
            else if (x == 1)
            {
                int index = 0;

                for (int i = 0; i < ProductArr.Length; i++)
                    if (ProductArr[i].Name == str) index++;

                if (index == 0) return false;
            }

            return true;
        }


        /////////////////////////////////////////////////////////////////////////////////
    }
}