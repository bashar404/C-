using System;

namespace string1
{
    class date
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:d}",dt);  //9/16/2021
            Console.WriteLine("{0:D}", dt); //Thursday, September 16, 2021
            Console.WriteLine("{0:f}", dt); //Thursday, September 16, 2021 10:04 AM
            Console.WriteLine("{0:F}", dt); //Thursday, September 16, 2021 10:04:50 AM
            Console.WriteLine("{0:g}", dt); //9/16/2021 10:06 AM
            Console.WriteLine("{0:G}", dt); //9/16/2021 10:06:51 AM
        }
    }
}



