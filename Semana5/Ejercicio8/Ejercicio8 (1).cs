public class Main {

    public static void main(String[] args) {
 
        Scanner sc = new Scanner(System.in);
        int i, N;
        int contMas = 0, contMenos = 0;
        double media = 0;
  
        do{
            System.out.print("Número de personas: ");                                                             
            N = sc.nextInt();
        }while(N<=0);
  
        double[] alto = new double[N];
  
        //Leer alturas
        System.out.println("Lectura de la altura de las personas: ");
        for (i = 0; i < N; i++) {
            System.out.print("persona " + (i+1) + " = ");
            alto[i] = sc.nextDouble();
            media = media + alto[i];                            
        }
  
        media = media / N;
  
        for (i = 0; i < alto.length; i++) {
            if (alto[i] > media){ 
                contMas++;
            } else if (alto[i] < media){ 
                contMenos++;
            }
        }
  
        System.out.println("Estatura media: " + media);
        System.out.println("Personas con estatura superior a la media: " + contMas);
        System.out.println("Personas con estatura inferior a la media: " + contMenos);                            
    }
}