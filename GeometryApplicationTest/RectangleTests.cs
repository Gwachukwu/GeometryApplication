namespace GeometryApplicationTest;

using GeometryApplicationClass.Classes;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var rectangle = new Rectangle(5,4);

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(20, result);
    }
    [TestMethod]
     public void TestPerimeter()
    {
        // Arrange
        var rectangle = new Rectangle(5,4);

        // Act
        var result = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(18, result);
    }
}