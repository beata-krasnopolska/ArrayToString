using System;
using System.Linq;

namespace ArrayToStringLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program converts string array into a string");
            string[] array;

            Console.WriteLine("Input number of strings to be stored in the array");
            int noOfStrings = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} strings to the array:", noOfStrings);
            array = new string[noOfStrings];
            for(int i=0; i<noOfStrings; i++)
            {
                array[i] = Console.ReadLine();
            }
            string newString = string.Join(", ", array.Select(s => s.ToString()).ToArray());

            Console.WriteLine(newString);

            Console.ReadKey();
        }
    }
}
