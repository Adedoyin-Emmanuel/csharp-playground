using Csharp_Playground.Playground.CustomArray;
using Csharp_Playground.Playground.GenericArray;

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
       

        System.Console.WriteLine(numbers.IndexOf(3));


        var names = new GenericArray<string>();

        names.Insert("Emmanuel");
        names.Insert("Temi");
        names.Insert("Niyi");


        


        System.Console.WriteLine(names.Count());

        System.Console.WriteLine(names.IndexOf("Temi"));

        System.Console.WriteLine(names.IndexOf("Emmanuel"));

        System.Console.WriteLine(names.IndexOf("Niyi"));


        names.RemoveAt(2);

        names.Insert("Doyin");


        names.Print();







    }
}