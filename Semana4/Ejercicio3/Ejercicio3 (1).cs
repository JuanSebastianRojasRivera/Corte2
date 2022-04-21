using System;

public class Ejercicio3
{ 
	

	public static void rellenar(int[] lista, int a, int b)
	{

		int i = 0;

		
		while (i < lista.Length)
		{
			int num = ((int)Math.Floor(GlobalRandom.NextDouble * (a - b) + b));
			if (esPrimo(num))
			{
				lista[i] = num;
				i++;
			}
		}
	}
	private static bool esPrimo(int num)
	{

		
		if (num <= 1)
		{
			return false;
		}
		else
		{

			      
			int prueba;
			int contador = 0;
			
			prueba = (int)Math.Sqrt(num);
			for (;prueba > 1;prueba--)
			{
				if (num % prueba == 0)
				{
					contador += 1;
				}
			}
			return contador < 1;
		}
	}

	public static void mostrar(int[] lista)
	{
		for (int i = 0;i < lista.Length;i++)
		{
			Console.WriteLine("En el indice " + i + " esta el valor " + lista[i]);
		}
	}

	public static int mayor(int[] lista)
	{
		int mayor = 0;
		for (int i = 0;i < lista.Length;i++)
		{
			if (lista[i] > mayor)
			{
				mayor = lista[i];
			}
		}

		return mayor;
	}

      public static void Main(string[] args)
      {

	     Console.WriteLine("Introduce un tamaño");
	     int.Parse(System.Console.ReadLine());


	      rellenar(num, 1, 100);

	      mostrarArray(num);


	     int primoMayor = mayor(num);
	       Console.WriteLine("El primo más grande es el " + primoMayor);
      }




}
