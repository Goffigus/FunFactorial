using System;
using static System.Console;

namespace FunFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNum;
            int fact = 1;

            while (fact > 0)
            {
                userNum = ReadLine();
                fact = Convert.ToInt32(userNum);
            
                for (int n = fact - 1; n > 1; n--)
                {
                    fact = fact * n; // fact *= n

                }

                WriteLine(fact);
            }
        }
    }
}
