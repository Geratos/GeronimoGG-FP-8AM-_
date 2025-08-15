namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 90;
            int numero2 = -numero1;
            int numero3 = +numero2;
            int numero4 = -numero3;

            Console.WriteLine(numero1 + " // " + numero2 + " // " + numero3 + " // " + numero4);

            //-Operadores aritmétricos-
            Console.WriteLine("---------------------------------------");

            int numero5 = 20 + 60;//suma
            Console.WriteLine(numero5);

            int numero6 = 686868 - 24564;//resta
            Console.WriteLine(numero6);

            int numero7 = 565 * 94;
            Console.WriteLine(numero7);

            double numero8 = 45439d / 3274d;//precision
            Console.WriteLine(numero8);

            float numero9 = (float)123439 / 3864;
            Console.WriteLine(numero9);

            decimal numero10 = (decimal)564757 / 1234567;//más precision
            Console.WriteLine(numero10);

            decimal numero11 = 7658576865m / 6464646m;
            Console.WriteLine(numero11);

            //-Operadores de incremento y decremento-
            Console.WriteLine("---------------------------------------");

            int numero12 = ++numero5;//incremento
            Console.WriteLine(numero12);

            int numero13 = --numero1;//decremento
            Console.WriteLine(numero13);

            numero2 += 125; //asignación positiva
            Console.WriteLine(numero2);

            numero3 -= 225; //asignación negativa
            Console.WriteLine(numero3);

            numero4 *= 100; //asignacion multiplicativa
            Console.WriteLine(numero4);

            numero5 /= 2; //asignacion fraccionaria
            Console.WriteLine(numero5);

            //orden de evaluación de operadores numericos
            Console.WriteLine("---------------------------------------");

            float numero14 = 17f * 7695f / 1.5f;
            Console.WriteLine(numero14);

            float numero15 = 7695f / 1.5f * 17f;
            Console.WriteLine(numero15);

            float numero16 = (17f * 7695f) / 1.5f;
            Console.WriteLine(numero16);

            float numero17 = 17f + 7695f * 1.5f;
            Console.WriteLine(numero17);

            float numero18 = 176f + 3332f * (575f - 3f);
            Console.WriteLine(numero18);

            //operadores lógicos
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("TABLA DE VERDAD: CONJUNCIÓN");
            Console.WriteLine($"V && V ={true && true}");
            Console.WriteLine($"V && F ={true && false}");
            Console.WriteLine($"F && V ={false && true}");
            Console.WriteLine($"F && F ={false && false}");

            Console.WriteLine("~~~");

            Console.WriteLine("TABLA DE VERDAD: DISYUNCION");
            Console.WriteLine($"V || V ={true || true}");
            Console.WriteLine($"V || F ={true || false}");
            Console.WriteLine($"F || V ={false || true}");
            Console.WriteLine($"F || F ={false || false}");

            Console.WriteLine("~~~");

            bool expresion1 = true;
            bool expresion2 = false;
            bool expresion3 = expresion1 && expresion2;
            bool expresion4 = !expresion2;
            bool expresion5 = !expresion3 || expresion4;
            Console.WriteLine($"expresion1 = {expresion1} | expresion2 = {expresion2} | expresion3 = {expresion3} | expresion4 = {expresion4} | expresion5 ={expresion5} ");

            //operadores de comparación
            Console.WriteLine("---------------------------------------");

            bool expresion6 = 5 > 5; //Mayor que > | menor que <
            Console.WriteLine(expresion6);

            bool expresion7 = 6 == 6; //Operador de igualdad ==
            Console.WriteLine(expresion7);

            bool expresion8 = 4 != 5; //Operador diferente a !=
            Console.WriteLine(expresion8);

            bool expresion9 = 5 > 4 && 6 != 6;
            Console.WriteLine(expresion9);

            bool expresion10 = 10 > 9 || !expresion9;
            Console.WriteLine(expresion10);
        }
    }
}
