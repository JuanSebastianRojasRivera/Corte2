using System;

namespace Ejercicio_03
{
    class Matriz
    {
        static void Main(String[] args)
        {
            Random num = new Random();
            int [,] i,j;
            int filas= 5
            int columnas = 8;
            int [,] m;
            m = new int[f, c];

            Console.WriteLine("\n La matriz, se encuentra con los siguientes datos : ");

            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                    m[i, j] = num.Next(0, 10);
                  Console.WriteLine(m[i, j] + "t/");
                  Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
