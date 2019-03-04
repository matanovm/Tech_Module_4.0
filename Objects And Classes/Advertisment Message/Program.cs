using System;

namespace Advertisment_Message
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
			string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
			string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
			string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

			Random random = new Random();
			int number = int.Parse(Console.ReadLine());
			for (int i = 0; i < number; i++)
			{
				int firstIndex = random.Next(0, phrases.Length);
				int secondIndex = random.Next(0, events.Length);
				int thirdIndex = random.Next(0, authors.Length);
				int fourthIndex = random.Next(0, cities.Length);
				Console.WriteLine($"{phrases[firstIndex]} {events[secondIndex]} {authors[thirdIndex]} - {cities[fourthIndex]}");
			}
		}
	}
}
