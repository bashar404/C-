using System;

namespace string1
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            int a = 20;
            float f = a;
            Console.WriteLine(f);  //20  Implicit cast done by the compiler as no data will loss

            float ff = 20.99f;
            // int aa = ff;          //will show error as data may lost
            int aa = (int)ff;        //explicit cast
            Console.WriteLine(aa);   //20

            //another way to explicit cast
            float fff = 33.33f;
            int aaa = Convert.ToInt32(fff);
            Console.WriteLine(aaa);  //33

            //string to int/float
            string s = "12.12";
            string ss = "14.14";
            float f2 = float.Parse(s) + float.Parse(ss);  //Parse convert a string to a number
            Console.WriteLine(f2);   //26.26


        }
    }
}
