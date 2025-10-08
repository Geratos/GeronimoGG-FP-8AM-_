namespace Parcial_3_arreglo
{
    internal class Program
    {

        static void Main()
            {
                
                // Declaración de datos base
                string[] departamentos = { "Marketing", "Contabilidad", "Recursos Humanos", "Distribución", "Ingeniería", "Investigación" };
                string[] conceptos = { "Salarios", "Suministros", "Mobiliario", "Equipamiento", "Otros" };

                // Matriz 6x5 de gastos
                double[,] gastos = new double[6, 5];

                // Ingreso de datos
                Console.WriteLine("INGRESO DE GASTOS");

                for (int i = 0; i < 6; i++) // recorre departamentos
                {
                    Console.WriteLine($"\nDepartamento: {departamentos[i]}");

                    for (int j = 0; j < 5; j++) // recorre conceptos
                    {
                        double valor;
                        bool valido = false;

                        do
                        {
                            Console.Write($"Ingrese gasto en {conceptos[j]}: ");
                            string entrada = Console.ReadLine();

                            if (double.TryParse(entrada, out valor) && valor >= 0)
                            {
                                gastos[i, j] = valor;
                                valido = true;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido. Ingrese un número positivo.");
                            }

                        } while (!valido);
                    }
                }

                // Mostrar matriz completa
                Console.WriteLine("\nMATRIZ DE GASTOS");
                Console.Write($"{"Departamento",-20}");

                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{conceptos[j],-15}");
                }
                Console.WriteLine();

                for (int i = 0; i < 6; i++)
                {
                    Console.Write($"{departamentos[i],-20}");
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write($"${gastos[i, j],-15:F1}");
                    }
                    Console.WriteLine();
                }

                // a. Total por departamento
                Console.WriteLine("\nTOTAL POR DEPARTAMENTO");
                for (int i = 0; i < 6; i++)
                {
                    double suma = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        suma += gastos[i, j];
                    }
                    Console.WriteLine($"{departamentos[i],-20}: ${suma:F1}");
                }

                // b. Total por concepto
                Console.WriteLine("\nTOTAL POR CONCEPTO");
                for (int j = 0; j < 5; j++)
                {
                    double suma = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        suma += gastos[i, j];
                    }
                    Console.WriteLine($"{conceptos[j],-15}: ${suma:F1}");
                }

                // c. Gasto total anual
                double totalAnual = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        totalAnual += gastos[i, j];
                    }
                }
                Console.WriteLine($"\nGASTO TOTAL ANUAL\nTotal: ${totalAnual:F1}");

                // d. Vector de gastos "Otros"
                Console.WriteLine("\nVECTOR DE GASTOS (OTROS)");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"{departamentos[i],-20}: ${gastos[i, 4]:F1}");
                }

                // e. Mayor gasto registrado
                double mayor = gastos[0, 0];
                int depMayor = 0;
                int concMayor = 0;

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (gastos[i, j] > mayor)
                        {
                            mayor = gastos[i, j];
                            depMayor = i;
                            concMayor = j;
                        }
                    }
                }

                Console.WriteLine("\nMAYOR GASTO REGISTRADO");
                Console.WriteLine($"Valor: ${mayor:F1}");
                Console.WriteLine($"Departamento: {departamentos[depMayor]}");
                Console.WriteLine($"Concepto: {conceptos[concMayor]}");
            }
        }

    }

