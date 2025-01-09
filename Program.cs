using System.Security.Cryptography.X509Certificates;
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
        numbers.Insert(8);


        int[] numbers2 = new int[4] { 4, 5, 6, 8 };

        var results = numbers.Intersect(numbers2);

        results.Print();

        //numbers.RemoveAt(2);


        // numbers.Insert(4);

        // numbers.Insert(100);

        // System.Console.WriteLine(numbers.Max());



        // var names = new GenericArray<string>();

        // names.Insert("Emmanuel");
        // names.Insert("Temi");
        // names.Insert("Niyi");





        // System.Console.WriteLine(names.Count());

        // System.Console.WriteLine(names.IndexOf("Temi"));

        // System.Console.WriteLine(names.IndexOf("Emmanuel"));

        // System.Console.WriteLine(names.IndexOf("Niyi"));


        // names.RemoveAt(2);

        // names.Insert("Doyin");


        // names.Print();



        // var nums = new GenericArray<int>();

        // nums.Insert(2);
        // nums.Insert(4);


        // nums.Print();




    }

}