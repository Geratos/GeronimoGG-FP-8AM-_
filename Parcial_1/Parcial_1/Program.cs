namespace Parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asignar Elementos por Mes y Signo zodiacal
            Console.Write("Ingrese su mes de nacimiento:");
            string mes = Console.ReadLine();

            Console.Write("Ingrese su signo zodiacal:");
            string signo = Console.ReadLine();

            if ((mes == "marzo" || mes == "abril" || mes == "julio" || mes == "agosto" || mes == "noviembre" || mes == "diciembre")
          && (signo == "aries" || signo == "leo" || signo == "sagitario"))
                Console.WriteLine("Tu elemento es fuego :D");

            else if ((mes == "abril" || mes == "mayo" || mes == "agosto" || mes == "septiembre" || mes == "diciembre" || mes == "enero")
            && (signo == "tauro" || signo == "virgo" || signo == "capricornio"))
                Console.WriteLine("Tu elemento es Tierra :D");

            else if ((mes == "mayo" || mes == "junio" || mes == "septiembre" || mes == "octubre" || mes == "enero" || mes == "febrero")
            && (signo == "géminis" || signo == "geminis" || signo == "libra" || signo == "acuario"))
                Console.WriteLine("Tu elemento es Aire :D");

            else if ((mes == "marzo" || mes == "junio" || mes == "julio" || mes == "octubre" || mes == "noviembre" || mes == "febrero")
            && (signo == "cáncer" || signo == "cancer" || signo == "escorpión" || signo == "escorpion" || signo == "acuario"))
                Console.WriteLine("Tu elemento es Agua :D");
            //algunos están repetidos por si lo pone sin tilde
            else Console.WriteLine();

        }
    }
}
