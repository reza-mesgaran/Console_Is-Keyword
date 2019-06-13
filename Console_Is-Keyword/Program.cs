using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Is_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------- 1st usage of Is-Keyword ---------------------------
            //int sum = 10 + 10;   
            double sum = 10.5+10.5; 

            if (sum is int)
            {
                Console.WriteLine("Result of sum is an Integer");
            }
            else if (sum is double)
            {
                Console.WriteLine("Result of sum is a Double");

            }
            //-------------------------- 1st usage of Is-Keyword ---------------------------

            Console.ReadKey();

        }
    }

}
