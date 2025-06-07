using System;

namespace Ejercicio_1
{
    class Program
    {
        //Instanciamos la clase Servicio
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine(@"Seleccione una opción del menú:
                1. Procesar un solo número
                2. Procesar varios números
                3. Mostrar máximo y mínimo.
                4. Mostrar promedio.
                5. Mostrar cantidad de números ingresados.
                6. Reiniciar variables
                0. Salir.
            ");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        static void MostrarIniciarVariables()
        {
            servicio = new Servicio();
            Console.WriteLine("Variables reiniciadas.");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(numero);
            Console.WriteLine("Número registrado.");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();

            Console.WriteLine("Ingrese la cantidad de números a procesar");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                int numero = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarValor(numero);
            }
            Console.ReadKey();
        }

        static void MostrarPantallaMaximoMinimo()
        {
            Console.Clear();
            Console.WriteLine($"Máximo: {servicio.Maximo}");
            Console.WriteLine($"Mínimo: {servicio.Minimo}");
            Console.ReadKey();
        }

        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            double promedio = servicio.CalcularPromedio();
            Console.WriteLine($"El promedio es: {promedio}");
            Console.ReadKey();
        }

        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine($"Cantidad de números ingresados: {servicio.CantidadNumerosIngresados}");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            //MostrarIniciarVariables();

            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarIniciarVariables();
                        break;
                    default:
                        op = 0;
                        break;
                }

                op = MostrarPantallaSolicitarOpcionMenu();

            }
        }
    }
}
