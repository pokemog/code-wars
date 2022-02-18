using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace Katas.Tests;

[TestClass]
public class TwoToOneTests
{
    [TestMethod]
    public void Longest_Should_Return_Longest_Distinct_String()
    {
        // Arrange
        var a = "axyb";
        var b = "feceeg";
        var expected = "abcefgxy";
        var twoToOne = new TwoToOne();

        // Act
        var result = twoToOne.Longest(a, b);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
}