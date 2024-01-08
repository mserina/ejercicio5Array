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
            
             foreach (int i in vector1)
             {
                    Console.WriteLine("Escribe numeros para el vector 1");
                    vector1[i] = Convert.ToInt32(Console.ReadLine());
             }
            Console.WriteLine(vector1[1]);
        }
    }
}