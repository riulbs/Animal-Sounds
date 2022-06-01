using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public class Animale
        {
            private string denumire;
            private string sunet;

            public Animale(string denumire, string sunet)
            {
                this.denumire = denumire;
                this.sunet = sunet;
            }
            public string Denumire
            {
                get { return denumire; }
                set { denumire = value; }
            }
            public string Sunet
            {
                get { return sunet; }
                set { sunet = value; }
            }
        }

        static void Main(string[] args)
        {
            int optiune;

            List<Animale> AnimalList = new List<Animale>();

            AnimalList.Add(new Animale("caine", "woof"));
            AnimalList.Add(new Animale("pisica", "miau"));
            AnimalList.Add(new Animale("lup", "awu"));

            Console.WriteLine("Animale si sunetele lor:");

            foreach (var animal in AnimalList)
            {
                Console.WriteLine("{0} face {1}", animal.Denumire, animal.Sunet);
            }

            Console.WriteLine("Press any key to close the console...");
            Console.ReadKey();
        }
    }
}
