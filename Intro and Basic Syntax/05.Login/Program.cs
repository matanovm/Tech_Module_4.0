using System;
using System.Linq;

namespace _05.Login
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] username = Console.ReadLine().ToCharArray().Select(c => c.ToString()).ToArray();

			for (int i = 0; i < 4; i++)
			{
				string[] password = Console.ReadLine().ToCharArray().Select(c => c.ToString()).Reverse().ToArray();

				bool isTrue = true;
				for (int J = 0; J < username.Length; J++)
				{
					if (username[J] != password[J])
					{
						isTrue = false;
						break;
					}
				}
				if (isTrue)
				{
					Console.WriteLine($"User {string.Join("", username)} logged in.");
					return;
				}
				else if (i < 3)
				{
					Console.WriteLine("Incorrect password. Try again.");
				}
				else if (i == 3)
				{
					Console.WriteLine($"User {string.Join("", username)} blocked!");

				}
			}
		}
	}
}
