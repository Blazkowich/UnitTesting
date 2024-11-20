using NUnit.Framework;

namespace UnitTests;

public class BearAndSteadyGeneTests
{
    
    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void CaseWhenEqualsEight()
    {
        // Arrange
        string s = "GAAATAAA";
        int n = 8;

        // Act
        int result = 0; // must be (n, s);

        // Assert
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void CaseWhenEqualsZero()
    {
        // Arrange
        string s = "GACT";
        int n = 4;

        // Act
        int result = 0; // must be (n, s);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void CaseWithAllSameCharacters()
    {
        // Arrange
        string s = "AAAA";
        int n = 4;

        // Act
        int result = 0; // must be (n, s);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void LargerGeneWithMultipleSubstrings()
    {
        // Arrange
        string s = "ACGTACGT";
        int n = 8;

        // Act
        int result = 0; // must be (n, s);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void ComplexCaseWithUnbalancedCharacters()
    {
        // Arrange
        string s = "GGATAGCTGCTT";
        int n = 12;

        // Act
        int result = 0; // must be(n, s);

        // Assert
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void CaseWithMaximumLength()
    {
        // Arrange
        string s = "A" + new string('G', 499999);
        int n = 500000;

        // Act
        int result = 0; //must be (n, s);

        // Assert
        Assert.That(result, Is.GreaterThanOrEqualTo(0));
    }
}
