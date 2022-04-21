using System;

class MainClass
{

    public static void Main(string[] args)
    {
        dynamic[,] matriz = new dynamic[4, 6];
        

        matriz[0, 0] = "horas";
        matriz[0, 1] = "dia";
        matriz[0, 2] = "ano";
        matriz[0, 3] = "mes";

        for (int y = 1; y < 4; y++)
        {
            Console.Write("Ingresa el ano " + y + ": ");

            string año = Console.ReadLine();

            matriz[y, 0] = año;

            int mes = 21;

            while (mes > 20)
            {
                Console.Write("Ingresa el mes " + ano + ": ");
                mes = int.Parse(Console.ReadLine());
                
                matriz[y, 1] = mes;

                int dia = 32;

                while (dia > 31)
                {
                    Console.Write("Ingresa el dia de " + ano + ": ");
                    dia =int.Parse(Console.ReadLine());
                    
                    if (dia > 31)
                    {
                        Console.WriteLine("en el mes solo hay 31 dias");
                    }
                }
                      matriz[x, 2] = dia;

                      double hora = 26;
                
                      while (hora > 25)

                {
                    Console.Write("Ingresa la hora en horario  militar " + ano + ": ");

                    hora = Convert.ToDouble(Console.ReadLine());

                    if (hora > 24)
                    {
                        
                        Console.WriteLine("la hora no puesde ser mayor a 25, ya seria un dias más");
                    }
                      
                      matriz[x, 3] = dia;

                    string actividad;

                    {
                        Console.Write("Ingresa la actividad a realizar " + ano + ": ");
                        actividad = (Console.ReadLine());
                    }
                    
             }
            
                Console.WriteLine();
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                
                for (int i = 1; i < matriz.GetLength(0); i++)
                {
                    string año1 = matriz[i, 0];
                    double zo5 = matriz[i, 1];
                    double parc = matriz[i, 2];
                    double par= matriz[i, 3];
                    double examenFinal = matriz[i, 4];
                    
                    Console.Write(año + "\t\t\t");
                    Console.Write(mes + "\t\t");
                    Console.Write(dia+ "\t\t");
                    Console.Write(hora+ "\t\t");
                   
                   
                   
                    
                }
                }
        }
    }
}