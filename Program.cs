using Csharp_Playground.Playground.CustomArray;

namespace Csharp_Playground;

class Program
{
    public static void Main(string[] args)
    {
        var numbers = new CustomArray();

        numbers.Insert(1);
        numbers.Insert(2);
        numbers.Insert(3);

        numbers.RemoveAt(2);
        numbers.Insert(3);

        System.Console.WriteLine(numbers.IndexOf(3));
    }
}