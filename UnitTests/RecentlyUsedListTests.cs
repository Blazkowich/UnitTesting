using NUnit.Framework;

namespace UnitTests;

[TestFixture]
public class RecentlyUsedListTests
{
    private List<string> _list;

    [SetUp]
    public void SetUp()
    {
        _list = new List<string>();
    }

    [Test]
    public void NewList_IsEmpty()
    {
        // Arrange
        int count = _list.Count;

        // Act & Assert
        Assert.That(count, Is.EqualTo(0));
    }

    [Test]
    public void AddItem_AddsToTheList()
    {
        // Arrange
        _list.Add("item1");

        // Act & Assert
        Assert.That(_list.Count, Is.EqualTo(1));
        Assert.That(_list[0], Is.EqualTo("item1"));
    }

    [Test]
    public void AddItem_DuplicateMovesToFront()
    {
        // Arrange & Act
        _list.Add("item1");
        _list.Add("item2");
        _list.Add("item1");

        // Assert
        Assert.That(_list.Count, Is.EqualTo(2));
        Assert.That(_list[0], Is.EqualTo("item1"));
    }

    [Test]
    public void AddItem_NullOrEmptyNotAllowed()
    {
        // Arrange, Act & Assert
        Assert.Throws<ArgumentException>(() => _list.Add(null));
        Assert.Throws<ArgumentException>(() => _list.Add(""));
    }

    [Test]
    public void BoundedCapacity_LimitsListSize()
    {
        // Arrange & Act
        var boundedList = new List<string>();
        boundedList.Add("item1");
        boundedList.Add("item2");
        boundedList.Add("item3");
        boundedList.Add("item4");

        // Assert
        Assert.That(boundedList.Count, Is.EqualTo(3));
        Assert.That(boundedList.Contains("item1"), Is.False);
    }

    [Test]
    public void AccessItemByIndex_ReturnsCorrectItem()
    {
        // Arrange & Act
        _list.Add("item1");
        _list.Add("item2");
        _list.Add("item3");

        // Assert
        Assert.That(_list[1], Is.EqualTo("item2"));
    }

    [Test]
    public void AccessItemByIndex_ThrowsIfOutOfBounds()
    {
        // Arrange & Act
        _list.Add("item1");

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { var item = _list[2]; });
    }

    [Test]
    public void AccessItemByIndex_ThrowsIfNegativeIndex()
    {
        // Arrange & Act
        _list.Add("item1");

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => { var item = _list[-1]; });
    }

    [Test]
    public void DefaultCapacity_IsFive()
    {
        // Arrange & Act
        var defaultList = new List<string>();

        // Assert
        Assert.That(defaultList.Capacity, Is.EqualTo(5));
    }

    [Test]
    public void UnboundedList_HandlesUnlimitedItems()
    {
        // Arrange & Act
        var unboundedList = new List<string>();
        for (int i = 0; i < 1000; i++)
        {
            unboundedList.Add($"item{i}");
        }

        // Assert
        Assert.That(unboundedList.Count, Is.EqualTo(1000));
    }
}