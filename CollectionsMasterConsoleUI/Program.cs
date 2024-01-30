using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numArray = new int[50];

            Populater(numArray);

            Console.WriteLine($"First number: {numArray[0]}");

            Console.WriteLine($"Last number: {numArray[numArray.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            
            NumberPrinter(numArray);
            
            ReverseArray(numArray);
            
            Console.WriteLine("All Numbers Reversed:");
            
            NumberPrinter(numArray);
            
            ThreeKiller(numArray);
            
            Console.WriteLine("Multiple of three = 0: ");
            
            NumberPrinter(numArray);
            
            Array.Sort(numArray);
            
            Console.WriteLine("Sorted numbers:");
            
            NumberPrinter(numArray);
            
            List<int> numList = new List<int>();
            
            Console.WriteLine($"List capacity: {numList.Capacity}");
            
            Populater(numList);
            
            Console.WriteLine($"List capacity after population: {numList.Capacity}");
            
            Console.WriteLine("Search for a number in the list.");
            
            int searchNumber;
            
            if (int.TryParse(Console.ReadLine(), out searchNumber))
            {
                NumberChecker(numList, searchNumber);
            }
            else
            {
                Console.WriteLine("Wrong numbers.");
            }

            Console.WriteLine("All Numbers:");
            
            NumberPrinter(numList);
            
            OddKiller(numList);
            
            Console.WriteLine("Evens Only!!");
            
            NumberPrinter(numList);
            
            numList.Sort();
            
            Console.WriteLine("Organized Evens.");
            
            NumberPrinter(numList);
            
            int[] newArray = numList.ToArray();
            
            numList.Clear();

        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is on the list");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not on the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }
        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int> //I dont know what this means Chat Gbt had me put it in.
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
