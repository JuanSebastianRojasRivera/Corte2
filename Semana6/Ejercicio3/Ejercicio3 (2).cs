using System;
using System.Collections;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaOb = new ArrayList();
            listaOb.Add(10);
            listaOb.Add(44);
            listaOb.Add(7);
            imprimir(listaOb);
      
            Console.WriteLine($"El 10 se encuentra en la posicion {1}",listaOb.IndexOf(10));
        

        static void imprimir(ArrayList arreglo)
        {
            foreach (int l in arreglo)
                Console.Write($" {l} ");
            Console.WriteLine("\n-----------");


        }
      }
  }
}