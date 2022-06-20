using System;
namespace ConsoleApp1
{
    class Cat : Animals
    {
        protected override string GetSound()
        {
            return "meow";
        }
    }
}
