using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardoFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0 1 1 2 3 5 8
            int a = 0;
            int b = 1;
            int c = 1;

            Console.Write("quantos valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("sequencia de Fibonacci com " + valores + " valores");

            for(int i = 0; i < valores; i++)
            {
                if(i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }
                

                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
