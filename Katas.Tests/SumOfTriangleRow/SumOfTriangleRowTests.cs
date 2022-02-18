using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace Katas.Tests;

[TestClass]
public class SumOfTriangleRowTests
{
    [TestMethod]
    public void RowSumOddNumbers_Should_Return_Sum()
    {
        // Arrange
        var sumOfTriangleRow = new SumOfTriangleRow();
        long row = 2257754;
        var expected = -6937948892021054552;

        // Act
        long result = sumOfTriangleRow.RowSumOddNumbers(row);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
}