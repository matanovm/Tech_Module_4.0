using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			List<string> list = new List<string>();
			for (int i = 0; i < count; i++)
			{
				string[] command = Console.ReadLine()
					.Split()
					.ToArray();

				switch (command[2])
				{
					case "going!":
						bool isOnTheList = false;
						if (list.Count > 0)
						{
							for (int j = 0; j < list.Count; j++)
							{
								if (list[j] == command[0])
								{
									isOnTheList = true;
								}
							}
						}
						if (isOnTheList)
						{
							Console.WriteLine($"{command[0]} is already in the list!");
						}
						else
						{
							list.Add(command[0]);
						}
						break;
					case "not":
						bool isNotOnTheList = true;
						if (list.Count > 0)
						{
							for (int j = 0; j < list.Count; j++)
							{
								if (list[j] == command[0])
								{
									isNotOnTheList = false;
								}
							}
						}
						if (isNotOnTheList)
						{
							Console.WriteLine($"{command[0]} is not in the list!");
						}
						else
						{
							list.Remove(command[0]);
						}
						break;
				}
			}

			foreach (string item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
}
