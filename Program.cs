using System;
using System.Globalization;

namespace FizzBuzzChallenge
{
	public class Program
	{
		public static void Main()
		{
			FizzBuzz(0);
			
		}
		public static void FizzBuzz(int num) 
		{
			Console.WriteLine("What number would you like to Check?");
			num = int.Parse(Console.ReadLine());
			if (num % 3 == 0 && num % 5 == 0) 
			{
                Console.WriteLine("FizzBuzz");
            }
			else if (num % 3 == 0)
			{
				Console.WriteLine("Fizz");
			}
			else if (num % 5 == 0) 
			{
				Console.WriteLine("buzz");
			}
			
		
		
		}
	}
}
