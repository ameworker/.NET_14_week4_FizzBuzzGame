using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_week_4_FizzBuzz_Game
{

    internal class FizzBuzz
    {

        public string DescribeNumber(int number)
        {
            if (number % 3 == 0 && number % 5 != 0)
            {
                Console.WriteLine("Fizz");
                return "Fizz";
            }
            else if (number % 3 != 0 && number % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return "Buzz";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                return "FizzBuzz";
            }
            else
            {
                Console.WriteLine(number);
                return number.ToString();
            }
        }
    }
}

