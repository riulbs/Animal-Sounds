using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> AnimalList = new List<Animals>();

            AnimalList.Add(new Dog());
            AnimalList.Add(new Cat());
            AnimalList.Add(new Wolf());

            Console.WriteLine("Animals and their sounds:");

            foreach (var animal in AnimalList)
            {
                animal.animalSound();
            }

            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
