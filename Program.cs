namespace ejercicio5Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /// DECLARAR 3 VECTORES DE 5 ENTEROS CADA UNO
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];

            /// Pedir al usuario los valores del vector 1 y 2
            
            //VECTOR1
            for(int i = 0; i < vector1.Length; i++)
             {
                 Console.WriteLine("Escribe numeros para el vector 1");
                 vector1[i] = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("");
             }

             Console.WriteLine("VECTOR1");
             foreach(int imprimirLista in vector1)
             {
                Console.WriteLine(imprimirLista);
                Console.WriteLine("");
             }


            //VECTOR2
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine("Escribe numeros para el vector 2");
                vector2[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("VECTOR2");

            foreach (int imprimirLista2 in vector2)
            {
                Console.WriteLine(imprimirLista2);
            }


            //VECTOR3
            for (int i = 0; i < vector3.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
                Console.WriteLine("");
            }

            Console.WriteLine("VECTOR3");

            foreach (int imprimirLista3 in vector3)
            {
                Console.WriteLine(imprimirLista3);
            }
        }
    }
}