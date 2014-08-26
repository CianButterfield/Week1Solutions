using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Greet("Cian");
            int myAgeDouble = DoubleIt(20);
            Console.WriteLine(myAgeDouble);
            Console.WriteLine(DoubleIt(myAgeDouble));
            Console.WriteLine(Multiply(myAgeDouble, 4));

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Multiply(i, 3));
            }

            Console.ReadKey();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static int DoubleIt(int num)
        {
            return 2 * num;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
