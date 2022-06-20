using System;

namespace ConsoleApp1
{
    abstract class Animals
    { 
        protected abstract string GetSound();
        public void animalSound()
        {
            Console.WriteLine("The {0} makes sound {1}", this.GetType().Name,GetSound());
        }
    }
}
