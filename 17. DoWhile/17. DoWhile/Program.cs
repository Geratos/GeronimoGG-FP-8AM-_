namespace _17._DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador < 5);

            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");


            //17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            int resultado = 0;
            int numero2 = 1;

            Console.WriteLine("Ingresar un numero porfavor: ");
            int numerodado = int.Parse(Console.ReadLine());

            do
            {
                resultado = numero2 * numerodado;
                Console.WriteLine($"{numerodado} * {numero2} = {resultado}");

               
                if (numero2 == 10)
                {

                    Console.WriteLine("si quiere empezar de nuevo presione cualquier tecla, si quiere finalizar, presione X");
                    string empezarotra = Console.ReadLine();

                    if (empezarotra != "x")
                    {
                        Console.WriteLine("Ingresar un numero porfavor: ");
                        numerodado = int.Parse(Console.ReadLine());
                        numero2 = 1;
                    }
                    else if (empezarotra == "x")
                    {
                        numero2 = 10;
                    }


                }
                numero2++;

            } while (numero2 <= 10 );


        }
    }
}
