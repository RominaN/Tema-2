using System;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
	public class Asignare

	{
		public static void Main(string[] args)
		{
		
			Console.WriteLine("Exercitiul 1");
			int a = 3;
			// a=3;
			int b = (a = 2) * a;
			// a=2; b=2*2; b=4
			int c = b * (b = 5);
			// c=4*5; c=20; b=5
			Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);
			// Se afiseaza a=2; b=5, c=20

			Console.WriteLine();
			Console.WriteLine("Exercitiul 2");
			double d = 2.95;
			int i = 4;
			Console.WriteLine(++d > i ? d : i);
			// ++d = 3.95; 3.95 < 4 => returneaza i adica 4; daca ++d ar fi < i ( i = 4 ) atunci ar returna d=3.95 
			// Se compileaza.
			// Afiseaza 4

			Console.WriteLine();
			Console.WriteLine("Exercitiul 3");
			int e= 3;
			if (++e < 4)
				if (e++ < 4)
					Console.WriteLine(e);
				else
					Console.WriteLine(e);
			//nu se afiseaza nimic deoarece conditia din primul if nu este indeplinita 

			Console.WriteLine();
			Console.WriteLine("Exercitiul 4");
			int suma = 0;
			for (int j = 1; j < 10; j++)
			{
				suma = suma + j;
			}
			Console.WriteLine("Suma este: " +suma);
			// Suma este:45

			Console.WriteLine();
			Console.WriteLine("Exercitiul 5");
			int n = 1, z;
			for (z = 2; z < 13; z++)
				{ 
					n = n * z;
				}
			Console.WriteLine("n! este: " + n);

			Console.WriteLine();
			Console.WriteLine("Exercitiul 6");
				int f=6, g=3, h=5;
			if (f < g && f < h)
			{
				Console.WriteLine("Minumul este: " + f);
			}
			else
			if (g < f && g < h)
			{
				Console.WriteLine("Minumul este: " + g);
			}
			else
			{
				Console.WriteLine("Minumul este: " + h);
			}

			Console.WriteLine();
			Console.WriteLine("Exercitiul 7");
			int x = 20, r;
			r = x % 2;
			if (r != 0)
			{
				Console.WriteLine("Numarul este impar");
			}
			else
			{
				Console.WriteLine("Numarul este par");
			}


			Console.WriteLine();
			Console.WriteLine("Exercitiul 8");
			int caseSwitch = 6;
			switch (caseSwitch)
			{
				case 1:
					Console.WriteLine("Ziua selectata este: Luni");
					break;
				case 2:
					Console.WriteLine("Ziua selectata este: Marti");
					break;
				case 3:
					Console.WriteLine("Ziua selectata este: Miercuri");
					break;
				case 4:
					Console.WriteLine("Ziua selectata este: Joi");
					break;
				case 5:
					Console.WriteLine("Ziua selectata este: Vineri");
					break;
				case 6:
					Console.WriteLine("Ziua selectata este: Sambata");
					break;
				default:
					Console.WriteLine("Ziua selectata este: Duminica");
					break;
			}

		}

	}

}

