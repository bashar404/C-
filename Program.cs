using System;

namespace ConsoleApp1
{
    class KLA
    {
        static void Main(string[] args)
        {
            // Ctrl+k+c for comment
            //Ctrl+K+u  for uncomment

            Console.WriteLine("Enter your first Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Welcome" + " " + fname);  //concatenation

            Console.WriteLine("Enter your last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine(" Good Morning {0} {1}", fname, lname); //placeholder syntax


            Console.WriteLine("Have a good day " + fname + " " + lname);

            Console.ReadLine();
        }
    }
}
