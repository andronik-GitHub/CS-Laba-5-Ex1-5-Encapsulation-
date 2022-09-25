using System;

class Ex2
{
    static void Main()
    {
        Console.Write("Lenght: ");
        float? Lenght = Convert.ToSingle(Console.ReadLine());

        Console.Write("Width: ");
        float? Width = Convert.ToSingle(Console.ReadLine());

        Console.Write("Height: ");
        float? Height = Convert.ToSingle(Console.ReadLine());


        Box box = new(Lenght, Width, Height);

        Console.WriteLine("\nSurface Area - {0:0.00}", box.SurfaceArea());
        Console.WriteLine("Lateral Surface Area - {0:0.00}", box.LateralSurfaceArea());
        Console.WriteLine("Volume - {0:0.00}", box.Volume());


        Console.ReadKey();

    }
}