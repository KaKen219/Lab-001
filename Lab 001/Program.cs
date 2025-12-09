using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {

        private static int prsent = DateTime.Now.Year;
        private static string generation;


        static void Main(string[] args)
        {
            Console.WriteLine("Please select your birth year.");
            string intput = (Console.ReadLine());
            if (!int.TryParse(intput, out int birthYear))
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                return;
            }

            String generation = GetGeneration(birthYear);
            Console.WriteLine();
            Console.WriteLine("Your Generation is: " + generation);
            Console.ReadLine();
        }

        private static string GetGeneration(int year)
        {
            if (year >= 0 && year <= 1980)
            {
                return "Generation X";
            }
            else if (year >= 1981 && year <= 1996)
            {
                return "Generation Y";
            }
            else if (year >= 1997 && year <= 2012)
            {
                return "Generation Z";
            }
            else if (year >= 2013 && year <= 2025)
            {
                return "Generation Alpha";
            }
            else
            {
                return "Unknown Generation";



            }
        }
    }
}




