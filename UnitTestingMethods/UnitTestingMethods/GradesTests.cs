using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Security.Cryptography;

namespace TestApp.UnitTests;

public class GradesTests
{
    [Test]
    public void Test_GradeAsWords_ReturnsCorrectString()
    {
        // Arrange
        double grade = 2.20;
        string expected = "Fail";

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

            //         case >= 2.00 and< 3.00:
            //    return "Fail";
            //case >= 3.00 and< 3.50:
            //    return "Average";
            //case >= 3.50 and< 4.00:
            //    return "Good";
            //case >= 4.00 and< 4.50:
            //    return "Very Good";
            //case >= 4.50 and <= 5.00:
            //    return "Excellent";
            //default:
            //    return "Invalid!";

    [TestCase(1.99, "Invalid!")]
    [TestCase(2.00, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(3.99, "Good")]
    [TestCase(4.00, "Very Good")]
    [TestCase(4.49, "Very Good")]
    [TestCase(4.50, "Excellent")]
    [TestCase(5.00, "Excellent")]
    [TestCase(5.01, "Invalid!")]

    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [Test]

    public void Test_GradeAsWords_Return_Invalid_Value()
    {
        //Arrenge

        double grade = 6.00;
        string expected = "Invalid!";

        // Act

        string actual = Grades.GradeAsWords(grade);

        // Assert

        Assert.That(expected, Is.EqualTo(actual));

    }
}
