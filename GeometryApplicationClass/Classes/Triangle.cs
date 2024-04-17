namespace GeometryApplicationClass.Classes;

using GeometryApplicationClass.Interfaces;

public class Triangle : IShape
{
    private double leftSide;
    private double rigthSide;
    private double triangleBase;
    private double height;
    public Triangle(double leftSide, double rigthSide, double triangleBase, double height)
    {
        this.leftSide = leftSide;
        this.rigthSide = rigthSide;
        this.triangleBase = triangleBase;
        this.height = height;
    }
    public double CalculateArea()
    {
        return 0.5 * (triangleBase * height);
    }
    public double CalculatePerimeter()
    {
        return leftSide + rigthSide + triangleBase;
    }
}