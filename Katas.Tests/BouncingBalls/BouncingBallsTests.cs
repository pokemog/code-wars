using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace Katas.Tests;

[TestClass]
public class BouncingBallsTests
{
    [TestMethod]
    public void BouncingBall_Should_Return_Number_Of_Bounces()
    {
        // Arrange
        var bouncingBall = new BouncingBall();
        var dropHeight = 3;
        var bounceHeight = .66;
        var windowHeight = 1.5;
        var expected = 3;

        // Act
        int result = bouncingBall.Bounces(dropHeight, bounceHeight, windowHeight);

        // Assert
        Assert.AreEqual(expected, result);
    }
}