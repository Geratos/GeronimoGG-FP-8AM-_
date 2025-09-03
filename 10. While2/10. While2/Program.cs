namespace _10._While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int factorial = 1;
            int resultado = 1;

            Console.WriteLine("ingrese un número para calcular su vectorial");
            int numero= int.Parse(Console.ReadLine());

            while (factorial <= numero)
            {
                resultado = factorial * resultado;
                factorial++;
            }

            Console.WriteLine("el factorial de " + numero + " es: " + resultado); 
        }
    }
}
