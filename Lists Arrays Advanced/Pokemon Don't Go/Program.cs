using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
			int index = int.Parse(Console.ReadLine());
			int sum = 0;

			while (input.Count > 0)
			{
				int indexValue = 0;
				if (index >= 0 && index < input.Count)
				{
					indexValue = input[index];
					sum += indexValue;
					input.RemoveAt(index);
					if (input.Count == 0)
					{
						break;
					}
					input = Calculate(input, indexValue);
				}
				else if (index < 0)
				{
					indexValue = input[0];
					sum += indexValue;
					input.RemoveAt(0);
					input.Insert(0, input[input.Count - 1]);
					input = Calculate(input, indexValue);
				}
				else
				{
					indexValue = input[input.Count - 1];
					sum += indexValue;
					input.RemoveAt(input.Count - 1);
					input.Add(input[0]);
					input = Calculate(input, indexValue);
				}
				index = int.Parse(Console.ReadLine());
			}
			Console.WriteLine(sum);
		}

		public static List<int> Calculate(List<int> input, int indexValue)
		{
			for (int i = 0; i < input.Count; i++)
			{
				if (input[i] <= indexValue)
				{
					input[i] += indexValue;
				}
				else
				{
					input[i] -= indexValue;
				}
			}
			return input;
		}
	}
}
