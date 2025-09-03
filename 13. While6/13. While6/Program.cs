namespace _13._While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14. Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.

            int rango = 0;
            int contadorPares = 0;
            int contador = 1;

            Console.WriteLine("ingrese el rango a evaluar");
            rango=int.Parse(Console.ReadLine());

            while(contador <= rango)

            {
                if (contador%2==0)
                {
                    contadorPares++;
                }

                contador++;
            }
            Console.WriteLine($"la cantidad de números pares de 1 hasta {rango} es: {contadorPares}"); 
        }
    }
}
