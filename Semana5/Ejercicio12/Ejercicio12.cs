using System;

namespace Ejercicio12
{
        static void Main(string[] args)
        {

            Random random = new Random();
            int[,] matriz=new int[4,4];
            int x=1;
            for(int i=0;i<4;i++)
            {for (int j = 0; j <4; j++)
            {
                if(k!=x-1)
                {
                    matriz[i,j] =random.Next(1,4);
                }
            }
            }
            Console.WriteLine("PRIMERA MATRIZ");
            for(int i=0;i<4;i++)
            {
                for (int j = 0; j <4; j++)
                {
                Console.Write(" | " +matriz[i,j]+ " | ");
                }
                Console.WriteLine();
            }
           
            Console.WriteLine("");
            Console.WriteLine("FINAL MATRIZ");
            for(int i=1;i<4;i++)
            { int j;
                for (j = 0; j < 4; j++)
                {
                Console.Write(" | " +matriz[i,j]+" | ");
                }
                 
                  Console.WriteLine();
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
              {
                Console.Write(" | " +matriz[i,j]+" | ");
              }
                
            }
        }
    
}