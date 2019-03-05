using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split('|').ToList();
			List<int> output = new List<int>();
			for (int i = 0; i < input.Count; i++)
			{
				int[] numbers = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				output.InsertRange(0, numbers);
			}
			Console.WriteLine(string.Join(" ", output));
		}
	}
}
