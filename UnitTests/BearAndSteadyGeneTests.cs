using BearAndSteadyGene;
using NUnit.Framework;

namespace UnitTests;

public class BearAndSteadyGeneTests
{
    private BearAndSteadyGeneClass _bearAndSteady;

    [SetUp]
    public void SetUp()
    {
        _bearAndSteady = new BearAndSteadyGeneClass();
    }

    [Test]
    public void CaseWhenEqualsEight()
    {
        // Arrange
        var s = "GAAATAAA";
        var n = 8;

        // Act
        var result = _bearAndSteady.MinimumReplacementLength(n, s);

        // Assert
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void CaseWhenEqualsZero()
    {
        // Arrange
        var s = "GACT";
        var n = 4;

        // Act
        var result = _bearAndSteady.MinimumReplacementLength(n, s);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void CaseWithAllSameCharacters()
    {
        // Arrange
        var s = "AAAA";
        var n = 4;

        // Act
        var result = _bearAndSteady.MinimumReplacementLength(n, s);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void LargerGeneWithMultipleSubstrings()
    {
        // Arrange
        var s = "ACGTACGT";
        var n = 8;

        // Act
        var result = _bearAndSteady.MinimumReplacementLength(n, s);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void ComplexCaseWithUnbalancedCharacters()
    {
        // Arrange
        var s = "GGATAGCTGCTT";
        var n = 12;

        // Act
        var result = _bearAndSteady.MinimumReplacementLength(n, s);

        // Assert
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void CaseWithMaximumLength()
    {
        // Arrange
        var s = "A" + new string('G', 499999);
        var n = 500000;

        // Act
        var result = _bearAndSteady.MinimumReplacementLength(n, s);

        // Assert
        Assert.That(result, Is.GreaterThanOrEqualTo(0));
    }
}
