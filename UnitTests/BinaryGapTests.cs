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
        int input = 9; // 1001
        int expected = 2;

        // Act
        int result = _solver.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MultipleGaps_ReturnsLongestGap()
    {
        // Arrange
        int input = 529; // 1000010001
        int expected = 4;

        // Act
        int result = _solver.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void NoBinaryGap_ReturnsZero()
    {
        // Arrange
        int input = 15; // 1111
        int expected = 0;

        // Act
        int result = _solver.Solution(input);

        // Assert

    }

    [Test]
    public void AllOnes_ReturnsZero()
    {
        // Arrange
        int input = 2147483647; // all ones
        int expected = 0;

        // Act
        int result = _solver.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void EndsWithZero_ReturnsZero()
    {
        // Arrange
        int input = 16; // 10000
        int expected = 0;

        // Act
        int result = _solver.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void OnlyOneOne_ReturnsZero()
    {
        // Arrange
        int input = 1; // 1
        int expected = 0;

        // Act
        int result = _solver.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ShortBinary_ReturnsCorrectGap()
    {
        // Arrange
        int input = 20; // 10100
        int expected = 1;

        // Act
        int result = _solver.Solution(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
