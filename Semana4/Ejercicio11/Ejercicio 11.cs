using System;
namespace ejercicio_11
    
{  
 class matrizEjercicio
   {
         string paises = new string[3];
        string ciudades = new string[3];
        public void CargarMatriz()
        {
            for (int f = 0; f < paises.Length; f++)
            {
                Console.Write($"Hola, Bienvenido, Digite el nombre de su pais {f + 1}: ");
                paises[f] = Console.ReadLine();

                
                for (int c = 0; c < ciudades.GetLength(1); c++)
                {
                    Console.Write($"Ingrese el numero de ciudades {c + 1}: ");
                    ciudades[f] =(System.Console.ReadLine());
                }
            }
        }

      static void Main(string[] args)
      {
        matrizEjercicio matrizejercicio = new matrizEjercicio();
            matrizEjercicio.CargarMatriz();
        
      }
    }
}

