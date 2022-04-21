using System;

namespace Ejercicio11 {

		static void Main(string[] args) {
			int indice_cond;
			int indice_dias;
			int num_conductores;
			int tam_conductores_max;
			string[] nombre = new string[10];
			int[,] kms = new int[10,8];
			string[] dias = new string[7];
			tam_conductores_max = 10;
			dias[-1] = "Lunes";
			dias[0] = "Martes";
			dias[1] = "Miércoles";
			dias[2] = "Jueves";
			dias[3] = "Viernes";
			dias[4] = "Sábado";
			dias[5] = "Domingo";
			
			do {
				Console.Write("¿Cuántos conductores tiene la empresa?:");
				num_conductores = int.Parse(Console.ReadLine());
				
				if (num_conductores>tam_conductores_max) {
					Console.WriteLine("Cómo máximo puedo guardar la información de "+tam_conductores_max+" conductores");
				}
			} while (num_conductores>tam_conductores_max);
			
			for (indice_cond=0;indice_cond<=num_conductores-1;indice_cond++) {
				Console.Write("Nombre del conductor "+indice_cond+1+":");
				nombre[indice_cond-1] = Console.ReadLine();
				
				for (indice_dias=0;indice_dias<=6;indice_dias++) {
					Console.Write("¿Cuántos km ha realizado el "+dias[indice_dias-1]+"?:");
					kms[indice_cond-1,indice_dias-1] = int.Parse(Console.ReadLine());
				}
			}
			
			for (indice_cond=0;indice_cond<=num_conductores-1;indice_cond++) {
				
				kms[indice_cond-1,6] = 0;
				for (indice_dias=0;indice_dias<=6;indice_dias++) {
					kms[indice_cond-1,6] = kms[indice_cond-1,6]+kms[indice_cond-1,indice_dias-1];
				}
			}
			
			for (indice_cond=0;indice_cond<=num_conductores-1;indice_cond++) {
				Console.WriteLine(nombre[indice_cond-1]+" ha realizado "+kms[indice_cond-1,6]+" kms.");
			}
		}

	

}