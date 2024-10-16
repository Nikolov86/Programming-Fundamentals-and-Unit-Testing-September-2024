﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrenge

        int input = 0;
        int expected = 1;

        // Act 

        int actual = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrenge

        int input = 5;
        int expected = 120;

        // Act

        int actual = Factorial.CalculateFactorial(input);

        //Assert
        Assert.That(expected, Is.EqualTo(actual));
    }
}