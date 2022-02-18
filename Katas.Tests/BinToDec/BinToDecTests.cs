using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace Katas.Tests;

[TestClass]
public class BinToDecTests
{
    [TestMethod]
    public void binaryArrayToNumber_Should_Return_Int()
    {
        // Arrange
        int[] myBinaryNumber = new int[] { 0, 1, 0, 1};
        var expected = 5;
        var binToDecConverter = new BinToDec();

        // Act
        var result = binToDecConverter.binaryArrayToNumber(myBinaryNumber);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
}