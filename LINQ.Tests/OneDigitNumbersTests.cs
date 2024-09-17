using LINQ.ProductionCode.Numbers;

namespace LINQ.Tests;

public class OneDigitNumbersTests
{
    [Test]
    public void GetEvenNumbersTest()
    {
        // Arrange


        // Act
        List<int> result = OneDigitNumbers.GetEvenNumbers();

        // Assert
        Assert.That(Is.Equals(result.Count, 4));
        Assert.That(Is.Equals(result[0], 2));
        Assert.That(Is.Equals(result[1], 8));
        Assert.That(Is.Equals(result[2], 6));
        Assert.That(Is.Equals(result[3], 4));
    }

    [Test]
    public void GetGreaterThanTest()
    {
        int testNumber = 3;

        List<int> result = OneDigitNumbers.GetGreaterThan(testNumber);

        Assert.That(Is.Equals(result.Count, 6));
    }

    [Test]
    public void GetWithMoreCharactersThanTest()
    {
        int testLength = 3;

        List<string> result = OneDigitNumbers.GetWithMoreCharactersThan(testLength);

        Assert.That(Is.Equals(result.Count, 6));
    }

    [Test]
    public void GetStringNumbersLengthTest()
    {

        List<int> result = OneDigitNumbers.GetStringNumbersLength();

        Assert.That(Is.Equals(result[0], 4));
        Assert.That(Is.Equals(result[1], 4));
        Assert.That(Is.Equals(result[2], 3));
        Assert.That(Is.Equals(result[3], 5));
        Assert.That(Is.Equals(result[4], 3));
        Assert.That(Is.Equals(result[5], 5));
        Assert.That(Is.Equals(result[6], 5));
        Assert.That(Is.Equals(result[7], 3));
        Assert.That(Is.Equals(result[8], 4));
    }

    [Test]
    public void GetSumTest()
    {

        int result = OneDigitNumbers.GetSum();

        Assert.That(Is.Equals(result, 45));
    }

    [Test]
    public void GetSumOfEvenNumbersTest()
    {
        int result = OneDigitNumbers.GetSumOfEvenNumbers();

        Assert.That(Is.Equals(result, 20));
    }

    [Test]
    public void GetAverageTest()
    {

        double result = OneDigitNumbers.GetAverage();

        Assert.That(Is.Equals(result, 5.0));
    }

    [Test]
    public void GetMaxTest()
    {
        int result = OneDigitNumbers.GetMax();

        Assert.That(Is.Equals(result, 9));
    }

    [Test]
    public void GetOrderedNumbers()
    {
        List<int> result = OneDigitNumbers.GetOrderedNumbers();

        Assert.That(Is.Equals(result[0], 1));
        Assert.That(Is.Equals(result[1], 2));
        Assert.That(Is.Equals(result[2], 3));
        Assert.That(Is.Equals(result[3], 4));
        Assert.That(Is.Equals(result[4], 5));
        Assert.That(Is.Equals(result[5], 6));
        Assert.That(Is.Equals(result[6], 7));
        Assert.That(Is.Equals(result[7], 8));
        Assert.That(Is.Equals(result[8], 9));
    }
}
