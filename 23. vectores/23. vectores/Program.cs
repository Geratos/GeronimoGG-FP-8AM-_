namespace _23._vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos unidimensionales
            //vectores

            int[] numeros = new int[5]; //el vector tiene 5 posiciones
            string[] nombres = new string[4];

            //asignacion de valores
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 5;
            numeros[3] = 30;
            numeros[4] = 45;
            //numeros[5] fuera de rango

            int[] numeros1=new int[] { 1, 2, 3, 4, 5 };
            int[] numeros2 = { 6, 7, 8, 9, 10 };
            //puedo recorrer el vector para llenarlo de datos o recuperar los datos

            char[] caracter=new char[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese un caracter para la posicion{i+1} con el indice {i}: ");
                caracter[i] = Convert.ToChar(Console.ReadLine());
            }
            
            Console.WriteLine($"el vector caracter en la pocision 3 es: {caracter[2]}");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"el vector caracter en la pocision {i+1} tiene el dato: {caracter[i]}");
            }

            for (int i = 0; i < caracter.Length; i++) //length me devuelve el rango del vector
            {
                Console.Write(caracter[i] + " | ");
            }
        }
    }
}
