namespace GeometryApplicationClass.Classes;

using GeometryApplicationClass.Interfaces;

public class Square : IShape
{
    private double size;
    public Square(double size)
    {
        this.size = size;
    }
    public double CalculateArea()
    {
        return size * size;
    }
    public double CalculatePerimeter()
    {
        return 4 * size;
    }
}