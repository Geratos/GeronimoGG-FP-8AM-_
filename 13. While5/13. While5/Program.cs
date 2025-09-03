namespace _13._While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
            El algoritmo debe escribir en pantalla: 
                La cantidad de números introducidos que son mayores que 0 
                La cantidad de números introducidos menores que 0  
                La cantidad de números iguales a 0. */

            int numero = 0;

            Console.WriteLine("Ingrese los numeros que quiera (presionar la tecla I para acabar):");
            numero = int.Parse(Console.ReadLine());
            
        }
    }
}
