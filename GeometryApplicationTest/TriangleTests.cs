namespace GeometryApplicationTest;

using GeometryApplicationClass.Classes;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var Triangle = new Triangle(5, 4, 7, 6);

        // Act
        var result = Triangle.CalculateArea();

        // Assert
        Assert.AreEqual(21, result);
    }
    [TestMethod]
    public void TestPerimeter()
    {
        // Arrange
        var Triangle = new Triangle(5, 4, 7, 2);

        // Act
        var result = Triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(16, result);
    }
}