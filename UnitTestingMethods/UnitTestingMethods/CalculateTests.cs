using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();
        int expected = 7;

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculateulator = new();
        int expected = 3;

        // Act
        int actual = calculateulator.Subtraction(5, 2);

        //Assert
        Assert.AreEqual(expected, actual );
    }
}
