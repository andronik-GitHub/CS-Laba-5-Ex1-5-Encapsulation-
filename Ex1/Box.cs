using System;

class Box
{
    float? length;
    float? width;
    float? height;

    public float? SurfaceArea()
    {
        return (float?)(2 * length * width + 2 * length * height + 2 * width * height);
    }

    public float? LateralSurfaceArea()
    {
        return (float?)(2 * length * height + 2 * width * height);
    }

    public float? Volume()
    {
        return (float?)(length * width * height);
    }

    public Box (float? length, float? width, float? height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
}
