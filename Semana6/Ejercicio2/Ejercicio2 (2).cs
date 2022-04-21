using System;
using System.Collections;

namespace Ejercicio2
{
    class ejer
    {
      Random rdn =new Random();
      ArrayList pila =new ArrayList();
      int cuadra=0,sum=0;
      public void car ()
      {
          Console.WriteLine("digite la longitud de la lista");
          int lgd = int.Parse(Console.ReadLine());
          for (int i = 0; i < lgd; i++)
          { 
              
              pila.Add(rdn.Next(0,51));
            
          }
          Console.WriteLine("los datos  son:");
          foreach (int datos in pila)
          {
             Console.Write($"{datos}, ");
          } 
           Console.WriteLine();
      }
      public void op()
      {
          Console.WriteLine("el cuadrado de los datos es:");
          foreach (int dato in pila)
          {
              cuadra=dato*dato;
              Console.Write($"{cuadra}, ");
               sum+=cuadra;
          }
          Console.WriteLine($"\nla suma de los cuadrados es de: {sum}");
      }

      static void Main(string []args)
      {
        ejer elementos =new ejer();
        elementos.car();
        elementos.op();
      }  
    }
}