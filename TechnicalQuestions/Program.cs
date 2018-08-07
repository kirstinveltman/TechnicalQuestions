using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an array of integers, write a method to total the odd numbers.
            int[] array = new int[] { 5, 3, 2, 6, 7, 13, 23, 32 };
            int oddNumbers = 0;

            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    oddNumbers += i;
                }
            }

            Console.WriteLine(oddNumbers);
            Console.ReadLine();

            // Given an array of integers, write a method to sum the elements in the array, 
            // knowing that some of the elements may be very large integers.
            long[] array1 = new long[] { 5, 3, 2, 6, 7, 13, 23, 32 };
            long sum = 0;

            for (long i = 0; i < array1.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
            Console.ReadLine();

            // Given a string, reverse it.
            string something = "something wicked this way comes";

            Console.WriteLine(StringHelper.ReverseString(something));
            Console.ReadLine();

            // Given a string, remove any repeated letters.
            string string1 = "I am the very model of a modern major general";
            string string2 = "We're knights of the round table! We dance whene're we're able.";

            Console.WriteLine(RemoveDuplicateCharacters(string1));
            Console.WriteLine(RemoveDuplicateCharacters(string2));

            Console.ReadLine();

            // FizzBuzz
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static string RemoveDuplicateCharacters(string t)
        {
            string result = "";

            foreach (char value in t)
            {
                if (result.IndexOf(value) == -1)
                {
                    result += value;
                }
            }
            return result;
        }
    }

    static class StringHelper
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
