{
        static void Main(string[] args)
        {
            string[,] alumnos = new string[7,2];
            for (int i = 0; i < alumnos.GetLength(0); i++)
            int[,] matrizO = new int[3,3];
            int[,] matrizT = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Humano ingresa el nombre del alumno "+(i+1));
                alumnos[i,0]=Console.ReadLine();
                Console.WriteLine("Humano ingresa el salon del alumno "+(i+1));
                alumnos[i,1]=Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    matrizO[i, j] = int.Parse(Interaction.InputBox("Humano ingresa el elemento de la matrizO["+(i+1)+ "," + (j + 1) + "]"));
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizT[i, j] = matrizO[j, i];
                }
            }
            string resultado = "Matriz original\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado = resultado + matrizO[i, j] + " | ";
                }
                resultado = resultado + "\n";
            }
            Console.WriteLine("Humano ingresa el salon de los alumnos que quieres ver ");
            string salon = Console.ReadLine();
            for (int i = 0; i < alumnos.GetLength(0); i++)
            resultado = resultado+"\n\nMatriz original\n";
            for (int i = 0; i < 3; i++)
            {
                if (alumnos[i, 1] == salon) {
                    
                    for (int j = 0; j < alumnos.GetLength(1); j++)
                    {
                        Console.Write(alumnos[i,j]+" | ");
                    }

                for (int j = 0; j < 3; j++)
                {
                    resultado = resultado + matrizT[i, j] + " | ";
                }
                Console.WriteLine();
                resultado = resultado + "\n";
            }
            Console.Read();
            MessageBox.Show(resultado);
        }
    }
}