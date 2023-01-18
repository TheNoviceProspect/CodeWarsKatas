namespace SumWithoutHighestAndLowestNumber;
class Program
{

    public static int Sum(int[] numbers)
    {
        if (numbers == null||numbers.Length == 0) return 0; // <-- ensure empty arrays or null values result in a 0 return code (sum)
        var ourList = numbers.ToList(); // <-- Convert array to list of numbers
        ourList.Remove(numbers.Min()); // <-- Remove smallest element from list
        ourList.Remove(numbers.Max()); // <-- Remove highest element from list
        return ourList.ToArray().Sum(); // <-- return the sum fo the remaining numbers (converted back into an array)
    }

    static void Main(string[] args)
    {
        var sample = new[] { 6, 2, 1, 8, 10};
        Console.WriteLine($"The sum is {Sum(sample)}");
    }
}
