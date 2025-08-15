namespace _5._Condicional_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("ingrese el número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el número 2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el número 3");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("El número:" + num1 + " es el mayor");
                }
                else
                {
                    Console.WriteLine("El número:" + num3 + " es el mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El número:" + num2 + " es el mayor");
                }
                else
                {
                    Console.WriteLine("El número:" + num3 + " es el mayor");
                }
            }

        }
    }
}
