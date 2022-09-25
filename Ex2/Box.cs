using System;

class Box
{
    float? length = 1;
    float? width = 1;
    float? height = 1;

    public float? Length {
        get => length;
        set {
            if (value <= 0) Console.WriteLine("Length cannot be zero or negative! Length = {0}", length);
            else length = value;
        }
    }
    public float? Width
    {
        get => width;
        set
        {
            if (value <= 0) Console.WriteLine("Width cannot be zero or negative! Width = {0}", width);
            else width = value;
        }
    }
    public float? Height
    {
    get => height;
        set
        {
            if (value <= 0) Console.WriteLine("Height cannot be zero or negative! Height = {0}", height);
            else height = value;
        }
    }


    public float? SurfaceArea() => (float?)(2 * Length * Width + 2 * Length * height + 2 * Width * Height);

    public float? LateralSurfaceArea() => (float?)(2 * Length * Height + 2 * Width * Height);

    public float? Volume() => (float?)(Length * Width * Height);

    public Box(float? length, float? width, float? height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
}
