using NUnit;
using NUnit.Framework;

namespace Code_Challanges
{
    internal class Program
    {
        public static void FizzBuzz()
        {
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three, print "Fizz" instead of the number
            // and for the multiples of five, print "Buzz."
            // For numbers that are multiples of both three and five, print "FizzBuzz."
        }

        public static bool IsPalindrome(string input)
        {
            // Write a program that checks whether a given string is a palindrome (reads the same forwards and backwards).
            // Ignore spaces and punctuation.
            return false;
        }

        public static int Factorial(int number)
        {
            // Write a program that calculates the factorial of a given number using recursion.'
            return number;
        }

        public static void PrintFibonacciSeries(int terms)
        {
            // Write a program that prints the Fibonacci series up to a given number of terms.
        }

        public static bool IsPrime(int number)
        {
            // Write a program that checks whether a given number is prime.
            return false;
        }

        static void Main(string[] args)
        {
            FizzBuzz();

            bool palindrome = IsPalindrome("racecar");
            Console.WriteLine($"Is \"racecar\" a palindrome? {palindrome}");

            int factorial = Factorial(5);
            Console.WriteLine($"5! = {factorial}");

            PrintFibonacciSeries(10);

            bool prime = IsPrime(7);
            Console.WriteLine($"Is 7 a prime number? {prime}");

            

            Console.ReadLine();
        }
    }
}