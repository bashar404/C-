using System;

namespace ConsoleApp1
{
    class addition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 no: ");
            int num1 = int.Parse( Console.ReadLine() );
            int num2 = int.Parse( Console.ReadLine() );
            int sum = num1 + num2;
            Console.WriteLine(" Addition is {0}" , sum );
            Console.ReadLine();
        }
    }
}