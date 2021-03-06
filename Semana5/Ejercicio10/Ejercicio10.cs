using System;
using System.Threading;

namespace Ejercicio10
{
    public static void Main(string[] args)
    {

        int[][] num = RectangularArrays.RectangularIntArray(6, 10);

        int fila;
        int columna;

        int minimo = int.MaxValue;
        int filaMinimo = 0;
        int columnaMinimo = 0;

        int maximo = int.MinValue;
        int filaMaximo = 0;
        int columnaMaximo = 0;

        Console.Write("\n      ");
        for (columna = 0; columna < 10; columna++)
        {
            Console.Write("   " + columna + "  ");
        }
        Console.WriteLine();

        Console.Write("    ┌");
        for (columna = 0; columna < 10; columna++)
        {
            Console.Write("──────");
        }
        Console.WriteLine("┐");

        for (fila = 0; fila < 6; fila++)
        {
            Console.Write("  " + fila + " │");
            for (columna = 0; columna < 10; columna++)
            {
                num[fila][columna] = (int)(GlobalRandom.NextDouble * 1001);
                Console.Write("{0,5:D} ", num[fila][columna]);
                Thread.Sleep(100);

                // Calcula el mínimo y guarda sus coordenadas
                if (num[fila][columna] < minimo)
                {
                    minimo = num[fila][columna];
                    filaMinimo = fila;
                    columnaMinimo = columna;
                }

                // Calcula el máximo y guarda sus coordenadas
                if (num[fila][columna] > maximo)
                {
                    maximo = num[fila][columna];
                    filaMaximo = fila;
                    columnaMaximo = columna;
                }
            }
            Console.WriteLine("│");
        }
        Console.Write("    └");
        for (columna = 0; columna < 10; columna++)
        {
            Console.Write("──────");
        }

        Console.WriteLine("┘\n\nEl máximo es " + maximo + " y está en la fila " + filaMaximo + ", columna " + columnaMaximo);
        Console.WriteLine("El mínimo es " + minimo + " y está en la fila " + filaMinimo + ", columna " + columnaMinimo);
    }
}



