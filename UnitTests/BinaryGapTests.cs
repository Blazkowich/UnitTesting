using BinaryGap;
using NUnit.Framework;

namespace UnitTests;

[TestFixture]
public class BinaryGapTests
{
    private BinaryGapClass _solver;

    [SetUp]
    public void SetUp()
    {
        _solver = new BinaryGapClass();
    }

    [Test]
    public void SimpleCase_ReturnsExpectedResult()
    {
        // Arrange
        var input = 9; // 1001
        var expected = 2;

        // Act
        var result = BinaryGapClass.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultipleGaps_ReturnsLongestGap()
    {
        // Arrange
        var input = 529; // 1000010001
        var expected = 4;

        // Act
        var result = BinaryGapClass.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void NoBinaryGap_ReturnsZero()
    {
        // Arrange
        var input = 15; // 1111
        var expected = 0;

        // Act
        var result = BinaryGapClass.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void AllOnes_ReturnsZero()
    {
        // Arrange
        var input = 2147483647; // all ones
        var expected = 0;

        // Act
        var result = BinaryGapClass.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void EndsWithZero_ReturnsZero()
    {
        // Arrange
        var input = 16; // 10000
        var expected = 0;

        // Act
        var result = BinaryGapClass.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void OnlyOneOne_ReturnsZero()
    {
        // Arrange
        var input = 1; // 1
        var expected = 0;

        // Act
        var result = BinaryGapClass.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ShortBinary_ReturnsCorrectGap()
    {
        // Arrange
        var input = 20; // 10100
        var expected = 1;

        // Act
        var result = BinaryGapClass.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
