using GeometryApplicationClass.Classes;
using GeometryApplicationClass.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var featureManagement = new Dictionary<string, string> { { "FeatureManagement:Square", "true" }, { "FeatureManagement:Rectangle", "false" }, { "FeatureManagement:Triangle", "true" } };

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();
var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

static double? ConvertToDouble(string? input)
{
    if (double.TryParse(input, out double number))
    {
        return number;
    }
    else
    {
        return null;
    }
}

async Task AccessControl(string access)
{
    if (!await featureManager.IsEnabledAsync(access))
    {
        Console.WriteLine("You do not have access to this feature.");
        Console.Out.Flush();
        Environment.Exit(1);
    }
}

Console.WriteLine("Which shape do you want");

var option = Console.ReadLine();


if (option?.ToLower() == "square")
{
    await AccessControl("Square");
    double? size;
    Console.WriteLine("Enter Size:");
    size = ConvertToDouble(Console.ReadLine());
    while (size == null)
    {
        Console.WriteLine("Please enter a valid size:");
        size = ConvertToDouble(Console.ReadLine());
    }
    Square square = new Square((double)size);
    Console.WriteLine($"Area of Square = {square.CalculateArea()}");
    Console.WriteLine($"Perimeter of Square = {square.CalculatePerimeter()}");
}
else if (option?.ToLower() == "rectangle")
{
    await AccessControl("Rectangle");
    double? length;
    double? width;
    Console.WriteLine("Enter Length:");
    length = ConvertToDouble(Console.ReadLine());
    while (length == null)
    {
        Console.WriteLine("Please enter a valid length:");
        length = ConvertToDouble(Console.ReadLine());
    }
    Console.WriteLine("Enter Width:");
    width = ConvertToDouble(Console.ReadLine());
    while (width == null)
    {
        Console.WriteLine("Please enter a valid width:");
        width = ConvertToDouble(Console.ReadLine());
    }
    Rectangle rectangle = new Rectangle((double)length, (double)width);
    Console.WriteLine($"Area of Rectangle = {rectangle.CalculateArea()}");
    Console.WriteLine($"Perimeter of Rectangle = {rectangle.CalculatePerimeter()}");
}
else if (option?.ToLower() == "triangle")
{
    await AccessControl("Triangle");
    double? leftSide;
    double? rightSide;
    double? triangleBase;
    double? height;
    Console.WriteLine("Enter Left side:");
    leftSide = ConvertToDouble(Console.ReadLine());
    while (leftSide == null)
    {
        Console.WriteLine("Please enter a valid left side:");
        leftSide = ConvertToDouble(Console.ReadLine());
    }
    Console.WriteLine("Enter right side:");
    rightSide = ConvertToDouble(Console.ReadLine());
    while (rightSide == null)
    {
        Console.WriteLine("Please enter a valid right side:");
        rightSide = ConvertToDouble(Console.ReadLine());
    }
    Console.WriteLine("Enter base:");
    triangleBase = ConvertToDouble(Console.ReadLine());
    while (triangleBase == null)
    {
        Console.WriteLine("Please enter a valid base:");
        triangleBase = ConvertToDouble(Console.ReadLine());
    }
    Console.WriteLine("Enter height:");
    height = ConvertToDouble(Console.ReadLine());
    while (height == null)
    {
        Console.WriteLine("Please enter a valid height:");
        height = ConvertToDouble(Console.ReadLine());
    }
    Triangle triangle = new Triangle((double)leftSide, (double)rightSide, (double)triangleBase, (double)height);
    Console.WriteLine($"Area of Triangle = {triangle.CalculateArea()}");
    Console.WriteLine($"Perimeter of Triangle = {triangle.CalculatePerimeter()}");
}
else
{
    Console.WriteLine("Invalid shape selected");
}