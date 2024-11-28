using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slides_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal;
            
            Console.Write(" enter your animal   ");
            animal = Console.ReadLine();
            
            
            switch (animal.ToLower())
            {
                case "dog":
                    Console.WriteLine("MAMMAL");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("REPTILE");
                    break;
                default:
                    Console.WriteLine("There is no such animal!");
                    break;
            }
        }
    }
}
