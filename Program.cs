using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsMale = true;
            if (IsMale) 
            {
                Console.WriteLine(" You are male");
            }
            else 
            {
                Console.WriteLine("You are female");
            }
            bool IsTall = false;
            if (IsTall && IsMale) 
            {
                Console.WriteLine("You are both tall and male");
            }
            else
            {
             Console.WriteLine("You are either not both tall and male");
            }
            Console.ReadLine();
        }
    }
}
