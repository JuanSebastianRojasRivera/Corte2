using System;


namespace Ejercicio_03
{
    class program
    {
        static void Main(String[] args)
        {
            Random num = new Random();
            int i,j;
            int f = 3;
            int c = 6;
            int [,] m;
            m = new int[f, c];

            Console.WriteLine("\n La matriz con nombre num esta compuesta por los datos: ");

            for (i = 0; i < f; i++)
            {
                for (j = 0; j < c; j++)
                    m[i, j] = num.Next(0, 10);
                  Console.WriteLine(m[i, j] + "\t");
                  Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
