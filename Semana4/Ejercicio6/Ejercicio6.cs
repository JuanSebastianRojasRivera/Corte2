Scanner sc = new Scanner(System.in);
    System.out.println("Introduce el tamaño deseado para tu array porfavor: ");
    int tamaño = sc.nextInt();
    System.out.println("---------------------------------------------------");

    int array_primos[] = new int[tamaño]; 

    int cantidadPrimos = 0, numero = 0;

    while(cantidadPrimos < array_primos.length){

        numero = (int) (Math.random()*1000 + 1);

        if(esPrimo(numero) == true){

            array_primos[cantidadPrimos] = numero;
            System.out.println(array_primos[cantidadPrimos]);
            cantidadPrimos++; 
        }

    }
    
}

public static boolean esPrimo(int num){ 

        int contador = 2;
        boolean primo = true;

        while(contador < num){

            if(num % contador == 0){
    
                primo = false;
                break;

            }else{

                contador++;
            }
        }
            
        return primo;

}