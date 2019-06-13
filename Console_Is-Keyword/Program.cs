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
            Sex.Greeting(new Man());       // Create an object of Man'Class
            Sex.Greeting(new Women());    // Create an object of Woman'Class
            Console.ReadKey();
        }
    }

    class Person { }
    class Man : Person { }
    class Women : Person { }

    //-------------------------- 2st usage of Is-Keyword ---------------------------
    class Sex
    {
        public static void Greeting(Person personObj)     // using -Is Keyword->  If (obj  is xxx)
        {
            if (personObj is Man)
            {
                Console.WriteLine("Welcome Mr.");
            }
            else if (personObj is Women)
            {
                Console.WriteLine("Welcome Mrs.");
            }
        }

    }
}
