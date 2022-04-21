using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Escuela;
            int CANTIDAD_FILAS = 3;
            int CANTIDAD_COLUMNAS = 4;

            Escuela = new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];

            for (int f = 0; f < CANTIDAD_FILAS; f++)
            {
                for (int c = 0; c < CANTIDAD_COLUMNAS; c++)
                {
                    Console.WriteLine("Bienvenido, digite el numero de estudiantes ");
                    Escuela[f, c] = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}