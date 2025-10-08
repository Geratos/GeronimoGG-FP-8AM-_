namespace _26._matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de matrices
            int[,]numerosMatriz = new int[2, 2];
            string[,]nombresMatriz = new string[3, 4]; //el rango es 6 posiciones0



            char[,] caracteresMatriz = new char[3,3]; //el rango es 9 posiciones

            //Asignacion de datos
            numerosMatriz[0, 0] = 25;
            numerosMatriz[0, 1] = 46;
            numerosMatriz[1, 0] = 42;
            numerosMatriz[1, 1] = 78;
            //numerosMatriz[1, 2] = 2; //fuera de rango

            //otra forma de declarar y inicializar matrices
            string[,] apellidos =
            {
                {"Chica" , "Alvarez" },
                {"Cardona" , "Rios"},
                {"Lopez" , "Mejia"}
            };

            //Recuperar datos de la matriz
            Console.WriteLine(apellidos[1,1]);

            //Recorrer matrices - almacenar datos
            char[,] caracteres = new char[3, 2]; //rango=6

            for (int i = 0; i < 3; i++)//Recorre filas
            {
                for (int j = 0; j < 2; j++)//Recorre columnas  cada fila
                {
                    Console.WriteLine($"Ingrese el caracter para la posicion [{i},{j}]");
                    caracteres[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer matrices - recuperar datos

            for(int i = 0; i < caracteres.GetLength(0) ; i++)//.GetLength(0) devuelve el numero de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++)//.GetLength(1) devuelve el numero de columnas
                {
                    Console.Write($"Caracter posicion {i},{j}: {caracteres[i,j]} ");
                }

                //Rango de la matriz
                Console.WriteLine(caracteres.Length);

            }
        }
    }
}
