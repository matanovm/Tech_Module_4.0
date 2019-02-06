using System;

namespace _03.Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			double numberOfPeople = double.Parse(Console.ReadLine());
			double capacity = double.Parse(Console.ReadLine());

			double counter = Math.Ceiling(numberOfPeople / capacity);
			Console.WriteLine(counter);
		}
	}
}
