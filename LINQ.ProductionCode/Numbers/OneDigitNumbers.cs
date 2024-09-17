using System.Collections.Immutable;

namespace LINQ.ProductionCode.Numbers;

public class OneDigitNumbers
{
    private static readonly List<int> Numbers = new() { 9, 5, 2, 7, 1, 3, 8, 6, 4 };
    private static readonly List<string> StringNumbers = new() { "Nine", "Five", "Two", "Seven", "One", "Three", "Eight", "Six", "Four" };

    // 01
    public static List<int> GetEvenNumbers()
    {
        var evenNumbers = Numbers.Where(n => n % 2 == 0).ToList();

        return evenNumbers;
    }

    // 02 (Get the numbers greater than the given number)
    public static List<int> GetGreaterThan(int number)
    {
        var greaterNumbers = Numbers.Where(n => n > number).ToList();

        return greaterNumbers;
    }

    // 03 (Get the numbers with more characters than the given length)
    public static List<string> GetWithMoreCharactersThan(int length)
    {
        var longerNumbers = StringNumbers.Where(sn => sn.Length > length).ToList();

        return longerNumbers;
    }

    // 04 (Get the length of each string in the list)
    public static List<int> GetStringNumbersLength()
    {
        var numberLengths = StringNumbers.Select(sn => sn.Length).ToList();

        return numberLengths;
    }

    // 05
    public static int GetSum()
    {
        var sum = Numbers.Sum();

        return sum;
    }

    // 06
    public static int GetSumOfEvenNumbers()
    {
        var sum = Numbers.Where(sn => sn % 2 == 0).Sum();

        return sum;
    }

    
    // 07
    public static double GetAverage()
    {
        var average = Numbers.Average();

        return average;
    }

    // 08
    public static int GetMax()
    {
        var max = Numbers.Max();

        return max;
    }

    // 09
    public static List<int> GetOrderedNumbers()
    {
        var sortedNums = Numbers.OrderBy(sn => sn).ToList();

        return sortedNums;
    }
    
}
