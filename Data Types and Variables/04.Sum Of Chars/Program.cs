using System;

namespace _04.Sum_Of_Chars
{
	class Program
	{
		static void Main(string[] args)
		{
			int sumOfChar = 0;
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				char simbol = char.Parse(Console.ReadLine());
				sumOfChar += simbol;
			}

			Console.WriteLine($"The sum equals: {sumOfChar}");
		}
	}
}
