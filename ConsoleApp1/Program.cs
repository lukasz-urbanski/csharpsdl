using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			for (int i = -10; i <= 0; i++)
			{
				Console.Write(i);
				if (i % 2 == 0)
				{
					Console.Write("\tis even");
				}
				Console.Write("\n");
			}
			*/

			Punkt punkt1 = new Punkt();
			punkt1.x = 1;
			punkt1.y = 2;

			ChangePunkt(punkt1);

			Console.ReadKey();
		}
		public static void ChangePunkt(Punkt p)
		{
			p.x = -1;
			p.y = -1;
		}
		public struct Punkt
		{
			public int x;
			public int y;
		}
	}
}
