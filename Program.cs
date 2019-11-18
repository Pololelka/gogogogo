using System;

namespace metod
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите 3 числа для решения примера: ");
			double x = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());
			double z = double.Parse(Console.ReadLine());

			Pervaya();
			Vtoraya(x, y, z);
			Console.WriteLine("Ответ3: " + Tretiya(x, y, z));


			Console.ReadKey();
		}
		static void Pervaya()
		{
			Console.Write("Введите 3 числа для решения примера: ");
			int a = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());
			Console.WriteLine("Ответ1: " + ((4 * c) + d - 1) / (c - Math.Tan(a / 2)));
		}
		static void Vtoraya(double a, double d, double c)
		{
			Console.WriteLine("Ответ2: " + ((4 * c) + d - 1) / (c - Math.Tan(a / 2)));
		}
		static double Tretiya(double a, double d, double c)
		{
			double sum = 0;
			sum = (((4 * c) + d - 1) / (c - Math.Tan(a / 2)));
			return sum;
		}
	}
}
