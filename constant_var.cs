using System;

namespace string1
{
    class Constant
    {
        public const string name = "Golam";
        static void Main(string[] args)
        {
            const double pi = 3.1416d;  //const should be initialize when it is declare
            Console.WriteLine(pi);          //3.1416
            //pi = 1.2;      we can't assign any value to const var

            Console.WriteLine(name);        //Golam
            //name = "Bashar"; we can't assign any value to const var
        }
    }
}

//int a;  //declare
//a = 10; //initialize

//int b = 20; //initialize
