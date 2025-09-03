namespace While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar algorito que permita obtener la suma de todos los números impares hasta el 99
            int contador = 1;
            int suma = 0;

            while (contador <= 99)
            {
                suma += contador; 
                Console.WriteLine($"{suma - contador} + {contador} = {suma}");
                contador += 2;

                Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine($"La suma de los números impares hasta el 99 es: {suma}");
        }
    }
}
