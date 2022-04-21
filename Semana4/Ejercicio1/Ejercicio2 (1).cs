using System;

public class Ejercicio2
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Introduce un tamaño");
	    int.Parse(System.Console.ReadLine());
		rellenar(num, 0, 9);

		mostrar(num);
	}

	public static void rellenar(int[] lista, int a, int b)
	{
		for (int i = 0;i < lista.Length;i++)
		{
			
			lista[i] = ((int)Math.Floor(GlobalRandom.NextDouble * (a - b) + b));
		}
	}

	public static void mostrar(int[] lista)
	{
		for (int i = 0;i < lista.Length;i++)
		{
			Console.WriteLine("En el indice " + i + " esta el valor " + lista[i]);
		}
	}
}