using System;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaP = new Stack();
            Stack pilaP2 = new Stack();
            pilaP.Push(5);
            pilaP.Push(19);
            pilaP.Push(47);
            pilaP.Push(84);
            pilaP.Push(78);

            while (pilaP.Count>0){
                pilaP2.Push(pilaP.Pop);
            }

        }
    }
}