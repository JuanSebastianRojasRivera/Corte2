using System;



namespace AplicacionBase
{
    class vector
    {

        public  void Rellenar(int ju)
        {
           
            int LONGITUD_VECTOR = 16;
            int[] num = new int[LONGITUD_VECTOR];
            

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Introduce un número");
                ju = int.Parse(System.Console.ReadLine());
            }
        }

        public void mostrar(int ju)
        {

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("En el indice " + i + " esta el valor " );
            }
        }

        public static void main()
        {
            vector op = new vector ();
            op.Rellenar(0);
            op.mostrar(0);

        }
    }   

}
