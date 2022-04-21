using System;
using System.Collections;
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList datos = new ArrayList();
            int sw = 0;
            int elem;
            Console.WriteLine("Por favor ingrese numeros  enteros, Digite el numero 0 para finalizar: ");
            while (sw == 0){
                Console.WriteLine("Ingrese el numero: ");
                elemento = int.Parse(System.Console.ReadLine());
                datos.Add(elem);
                if (elem == 0){
                    sw = 1;
                }
            }
        }
    }
}
