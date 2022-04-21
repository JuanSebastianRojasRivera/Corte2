using System;
using System.Collections;

namespace Ejercicio10
{
    class Academia
    {
        private int[,] numeros;
        int CANTIDAD_FILAS = 4;
        int CANTIDAD_COLUMNAS = 5;

        public void CargarMatriz()
        {
            numeros = new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];
            int suma = 0;
            int sumacolumnas = 0;
            int sumafilas= 0;



            for (int f = 0; f < CANTIDAD_FILAS; f++)

            {
                for (int c = 0; c < CANTIDAD_COLUMNAS; c++)
                {
                    Console.Write("Digite 20 numeros: ");
                    numeros[f, c] = int.Parse(Console.ReadLine());
                    suma=sumacolumnas+sumafilas;
                    sumacolumnas += numeros[f,c];
                    sumafilas += numeros[f, c];
                    
                }
                
                Console.WriteLine();
            }
            
            Console.WriteLine("el total de columnas es: " + sumacolumnas);
            Console.WriteLine("el total de filas es: " + sumafilas);
            Console.WriteLine("el total es: " + suma);
        }
        public void MostrarMatriz()

        { }

        static void Main(string[] args)
        {
            Academia op = new Academia();
            op.CargarMatriz();
            op.MostrarMatriz();
        }
    }
}
