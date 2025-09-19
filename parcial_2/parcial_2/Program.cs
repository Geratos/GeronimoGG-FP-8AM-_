namespace parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("introduzca su nota de practica");
            float nota_practica = float.Parse(Console.ReadLine());

            Console.WriteLine("introduzca su nota de problemas");
            float nota_problemas = float.Parse(Console.ReadLine());

            Console.WriteLine("introduzca su nota teorica");
            float nota_teorica = float.Parse(Console.ReadLine());

            float nota = 10;

            nota_practica = nota_practica * 0.1f;
            nota_problemas = nota_problemas * 0.5f;
            nota_teorica = nota_teorica * 0.4f;

            nota = nota_practica + nota_problemas + nota_teorica;

            if (nota < 0 || nota > 10)
            {
                 Console.WriteLine("Los datos dados no son acordes a los solicitados");
            }
            else if (nota > 6)
            {
                 Console.WriteLine("El alumno " + nombre + " ha aprobado con una nota de " + nota);
            }
            else
            {
                Console.WriteLine("El alumno " + nombre + " ha suspendido con una nota de " + nota);
            }

        }
    }
}
