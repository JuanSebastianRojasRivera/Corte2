public class Registros {
	
	
	static String[] nombres = new String[5];
	static String[] materias = new String[5];
	static double[][] notas = new double[5][3];

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		
		for (int i = 0; i < 5; i++) {
			System.out.println("Registrando alumno #" + (i+1));
			System.out.print("Nombre: ");
			nombres[i] = teclado.nextLine();
			System.out.print("Materia: ");
			materias[i] = teclado.nextLine();
			System.out.print("Nota 1: ");
			notas[i][0] = Double.parseDouble(teclado.nextLine());
			System.out.print("Nota 2: ");
			notas[i][1] = Double.parseDouble(teclado.nextLine());
			notas[i][2] = (((((notas[i][0]+notas[i][1])/2)+0.5))*2)/2;
			System.out.println("Valor autocalculado para Nota 3: " + notas[i][2]);
			System.out.println("Alumno registrado...\n");
		}
		
		int opcion = 0;
		do {
			System.out.println("\n\n\t\tMENU OPCIONES\n");
			System.out.println("[1] Mostrar nota promedio más alta.");
			System.out.println("[2] Mostrar las 3 notas más bajas.");
			System.out.println("[3] Ordenar de mayor a menor Nota 1.");
			System.out.println("[4] SALIR.");
			System.out.print("Elija opcion: ");
			opcion = Integer.parseInt(teclado.nextLine());
			switch(opcion) {
			case 1:
				notaPromedioMasAlta();
				break;
			case 2:
				tresNotasMasBajas();
				break;
			case 3:
				ordenaNota1();
				break;
			case 4:
				System.out.println("\n\t\tFIN DE PROGRAMA");
				break;
			default:
				System.out.println("\nOpcion equivocada. Escoja entre [1-4]");
			}
		}while(opcion != 4);

		teclado.close();
	}
	
	
	private static void notaPromedioMasAlta() {

		double masAlta = 0;
		int alumno = 0;
		
		for (int i = 0; i < notas.length; i++) {
			double sumaNotas = notas[i][0] + notas[i][1] + notas[i][2];
			double promedio = sumaNotas / 3;
			if (promedio > masAlta) {
				masAlta = promedio;
				alumno = i;
			}
		}
		
		System.out.printf("\nNota promedio más alta: %.2f\n", masAlta);
		System.out.println("Alumno: " + nombres[alumno]);
	}
	
	private static void tresNotasMasBajas() {

		
		double[] todasNotas = new double[15];
		int z = 0;
		for (int i = 0; i < notas.length; i++)
			for (int j = 0; j < notas[0].length; j++) {
				todasNotas[z] = notas[i][j];
				z++;
			}
		for (int i = 0; i < todasNotas.length -1; i++) {
			for (int j = 0; j < todasNotas.length-i-1; j++) {
				if (todasNotas[j + 1] < todasNotas[j]) {
					double aux = todasNotas[j + 1];
					todasNotas[j + 1] = todasNotas[j];
					todasNotas[j] = aux;
				}
			}
		}
		
		System.out.println("\nLas tres notas más bajas son:");
		for (int i = 0; i < 3; i++) {
			System.out.println("- " + todasNotas[i]);
		}
	}
	
	private static void ordenaNota1() {

		
		double[] notas1 = new double[5];
		for (int i = 0; i < 5; i++)
			notas1[i] = notas[i][0];
		for (int i = 0; i < notas1.length -1; i++) {
			for (int j = 0; j < notas1.length-i-1; j++) {
				if (notas1[j + 1] > notas1[j]) {
					double aux = notas1[j + 1];
					notas1[j + 1] = notas1[j];
					notas1[j] = aux;
				}
			}
		}
		
		System.out.println("\nNotas 1 de MAYOR a MENOR:");
		for (int i = 0; i < 5; i++)
			System.out.print(notas1[i] + " ");
	}
}