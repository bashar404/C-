using System;

namespace string1
{
    class String
    {
        static void Main(string[] args)
        {
            string s = "D:\\golam\\FLC\\CompSec";  //  \ acts as escape sequence
            Console.WriteLine(s);                  //   D:\golam\FLC\CompSec

            //less readable for programmers

            string s2 = @"D:\golam\FLC\CompSec";  // @ called verbatim literal is more readable
            Console.WriteLine(s2);                //     D:\golam\FLC\CompSec

            string s3 = " \"End of this topic\" ";
            Console.WriteLine(s3);                //  "End of this topic"

        }
    }
}
