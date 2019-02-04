using System;

namespace _02.Division
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int maxDivisor = 1;
			if (number % 2 == 0)
			{
				maxDivisor = 2;
			}
			if (number % 3 == 0)
			{
				maxDivisor = 3;
			}
			if (number % 6 == 0)
			{
				maxDivisor = 6;
			}
			if (number % 7 == 0)
			{
				maxDivisor = 7;
			}
			if (number % 10 == 0)
			{
				maxDivisor = 10;
			}

			if (maxDivisor > 1)
			{
				Console.WriteLine($"The number is divisible by {maxDivisor}");
			}
			else
			{
				Console.WriteLine("Not divisible");
			}
		}
	}
}
