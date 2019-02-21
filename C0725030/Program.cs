using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1) Simple recursion
            //new PlayWithRecursion().Add(3, 4);
            new PlayWithRecursion();
            Console.WriteLine(PlayWithRecursion.GetFactorial(4));
        }
    }
    //(1) Simple recursion
    class PlayWithRecursion
    {
        //simple recursion
        public void Add(int a, int b)
        {
            //Have to add the step back to return to the back point
            if (a > 10)
            {
                return;
            }

            Add(++a, --b);
        }

        public static long GetFactorial(int number)
        {
            Console.WriteLine(number);
            //Condition
            if (number == 0)
            {
                return 1;
            }
            //Call the method again
            //return number is (int number)
            //GetFactorial(number - 1) is the function of --> GetFactorial(int number)
            return number * GetFactorial(number - 1);
        }
    }
}


//NOTE:
//Everytime I call a method, I create a frame in the stack (call stack frame)