using System;
using System.Collections;
using System.Collections.Generic;
 
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila1 = new Stack();
            Stack pila2 = new Stack();
            Stack pila3 = new Stack();
            pila1.Push(8.8);
            pila1.Push(10.5);
            pila1.Push(12.6);

            pila2.Push(15.2);
            pila2.Push(14.5);
            pila2.Push(47.1);

            while (pila1.Count > 0)
            {
                double PTotal = 0;
                PTotal =(double)pila1.Pop();
                Console.WriteLine($" elementos de la cola número uno: {PTotal}");
                pila3.Push(PTotal);
            }
            Console.WriteLine(" ");
            while (pila2.Count > 0)
            {
                double PTotal2 = 0;
                PTotal2 = (double)pila2.Pop();
                Console.WriteLine($" elemento de la cola número dos: {PTotal2}");
                pila3.Push(PTotal2);
            }
            Console.WriteLine(" ");
           
            imprimirPilas(pila3);
           
            
            
        static void imprimirPilas(Stack pila1)
            {
                foreach (double n in pila1)
                    Console.WriteLine($"el elemento de la pila es {n}");
            }
        }
    }
}