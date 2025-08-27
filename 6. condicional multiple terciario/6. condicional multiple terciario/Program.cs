namespace _6._condicional_multiple_terciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de la compra:");
            valorCompra=Single.Parse(Console.ReadLine()); //single.parse es para cuando se usa float
            Console.WriteLine("Ingrese el día de la semana:l:Lunes, m:Martes, x:Miercoles, j:Jueves,v:Viernes, s:Sabado, d:Domingo");
            dia=Convert.ToChar(Console.ReadLine());  //char es para poner 1 sola letra

            switch (dia)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine("Hoy es lunes, descuento de " + descuento + ", valor total de la compra: " + (valorCompra - descuento));
                    break;

                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine("Hoy es martes, descuento de " + descuento + ", valor total de la compra: " + (valorCompra - descuento));
                    break;

                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine("Hoy es miercoles, descuento de " + descuento + ", valor total de la compra: " + (valorCompra - descuento));
                    break;

                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine("Hoy es jueves, descuento de " + descuento + ", valor total de la compra: " + (valorCompra - descuento));
                    break;

                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine("Hoy es viernes, descuento de " + descuento + ", valor total de la compra: " + (valorCompra - descuento));
                    break;

                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine("Hoy es sabado, descuento de " + descuento + ", valor total de la compra: " + (valorCompra - descuento));
                    break;

                case 'd':
                    descuento = 0;
                    Console.WriteLine($"Hoy es domingo, descuento de {descuento}, valor total de la compra: {valorCompra - descuento}");
                    //esta es otra forma de ponerlo
                    break;

                default:
                    Console.WriteLine("ingrese un dia valido no sea bobito");

                    break;

            }
            





        }
    }
}
