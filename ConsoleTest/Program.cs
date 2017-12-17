using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Test1();
            Test2();
            Program.Test3(); Program.Test3();
            Console.ReadKey();
        }


        static void Test1()
        {
            var a = "123";
            Console.WriteLine(a);
            var b = a;
            b = "1233";
            Console.WriteLine(a);

        }
        static void Test2()
        {
            var a = "123";
            Console.WriteLine(a);
            var b = a;
            a = "1233";
            Console.WriteLine(b);

        }

        static void Test3(string a = "12323")
        {
            a += "6";
            Console.WriteLine(a);
        }


    }
}
