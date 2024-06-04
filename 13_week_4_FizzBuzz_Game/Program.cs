using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_week_4_FizzBuzz_Game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Gra FizzBuzz 1.0");
            Console.WriteLine();
            Console.WriteLine("Podaj liczbę");
            bool continueFlag = true;
            do
            {
                try
                {
                    if (!int.TryParse(Console.ReadLine(), out int userNumber))
                    {
                        throw new Exception("To nie jest liczba, spróbuj ponownie");
                    }

                    FizzBuzz fzCheck = new FizzBuzz();
                    string result = fzCheck.DescribeNumber(userNumber);
                    Console.WriteLine(result);

                    Console.WriteLine();
                    Console.WriteLine("Chcesz spróbować ponownie? T/N");
                    string decision = Console.ReadLine();
                    if (decision.ToUpper() == "N")
                    {
                        continueFlag = false;
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Podaj liczbę");
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            } while (continueFlag == true);

            Console.ReadLine();
        }
    }
}

