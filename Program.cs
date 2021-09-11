using System;

namespace ConsoleApp1
{
    class KLA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Welcome" + " " + name);  //concatenation
            Console.WriteLine(" Good Morning {0}", name); //placeholder syntax
            Console.ReadLine();
        }
    }
}
