using System;


namespace data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MinValue); //-2147483648
            Console.WriteLine(int.MaxValue); // 2147483647
            


            Console.WriteLine(uint.MinValue); // 0
            Console.WriteLine(uint.MaxValue); // 4294967295

            //byte b = 345; etar range 255 max


            Console.WriteLine(byte.MinValue); // 0
            Console.WriteLine(byte.MaxValue); // 255

            float f = 123.456789f; // seshe a f dite hobe
            Console.WriteLine(f);  // 123.45679  total 7

            double d = 123456789.123456789; // d dile o hoy nao hoy
            Console.WriteLine(d);  // 123456789.12345679  total 15-16

            decimal dc = 123456789.123456789123456789m; //m dite hobe
            Console.WriteLine(dc);  //123456789.123456789123456789

        }
    }
}
