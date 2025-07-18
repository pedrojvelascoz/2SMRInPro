///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es mi proyecto CheesyPizza de la UT2 </summary>

using System;
using System.Collections.Generic;

namespace CheesyPizza
{
    class Program
    {
        static List<List<string>> ordenes = new List<List<string>>();

        static void Main(string[] args)
        {
            EjecutarPrograma();
        }

        static void EjecutarPrograma()
        {
            bool salir = false;

            while (!salir)
            {
                MostrarMenu();
                int opcion = GetEntrada("Selecciona una opción: ");

                if (opcion == 1)
                {
                    CrearOrden();
                }
                else if (opcion == 2)
                {
                    MostrarOrdenes();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("¡Gracias por usar Cheesy Pizza!");
                    salir = true;
                }
                else
                {
                    MostrarMensajeError("Opción no válida.");
                }

                PausarYLimpiar();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== Cheesy Pizza ===");
            Console.WriteLine("1. Crear pedido");
            Console.WriteLine("2. Ver pedidos");
            Console.WriteLine("3. Salir");
        }

        static void CrearOrden()
        {
            Console.WriteLine("\n=== Crear pedido ===");

            string nombreCliente = PedirNombreCliente();
            string tamañoPizza = PedirTamañoPizza();
            List<string> ingredientes = SeleccionarToppings();

            GuardarOrden(nombreCliente, tamañoPizza, ingredientes);

            MostrarResumenOrden(nombreCliente, tamañoPizza, ingredientes);
        }

        static string PedirNombreCliente()
        {
            Console.Write("Nombre del cliente: ");
            return Console.ReadLine();
        }

        static string PedirTamañoPizza()
        {
            Console.WriteLine("\nSelecciona tamaño de pizza:");
            Console.WriteLine("1. Pequeña");
            Console.WriteLine("2. Mediana");
            Console.WriteLine("3. Grande");

            int opcion = GetEntrada("Opción: ");

            if (opcion == 1) return "Pequeña";
            else if (opcion == 2) return "Mediana";
            else if (opcion == 3) return "Grande";
            else return "Desconocida";
        }

        static List<string> SeleccionarToppings()
        {
            Console.WriteLine("\n=== Selecciona ingredientes ===");
            string[] disponibles = {
                "Queso extra",
                "Pepperoni",
                "Champiñones",
                "Jamón",
                "Aceitunas",
                "Cebolla",
                "Pimiento"
            };

            List<string> seleccionados = new List<string>();

            while (true)
            {
                MostrarToppingsDisponibles(disponibles);
                int opcion = GetEntrada("Opción: ");

                if (opcion == 0) break;

                if (opcion >= 1 && opcion <= disponibles.Length)
                {
                    string topping = disponibles[opcion - 1];
                    if (!seleccionados.Contains(topping))
                    {
                        seleccionados.Add(topping);
                        Console.WriteLine($"{topping} añadido.");
                    }
                    else
                    {
                        Console.WriteLine($"{topping} ya está seleccionado.");
                    }
                }
                else
                {
                    MostrarMensajeError("Opción inválida.");
                }
            }

            return seleccionados;
        }

        static void MostrarToppingsDisponibles(string[] toppings)
        {
            Console.WriteLine("\nIngredientes disponibles:");
            for (int i = 0; i < toppings.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {toppings[i]}");
            }
            Console.WriteLine("0. Terminar selección");
        }

        static void GuardarOrden(string nombre, string tamaño, List<string> toppings)
        {
            List<string> orden = new List<string> { nombre, tamaño };
            orden.AddRange(toppings);
            orden.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            ordenes.Add(orden);
        }

        static void MostrarResumenOrden(string nombre, string tamaño, List<string> toppings)
        {
            Console.WriteLine($"\nPedido creado para {nombre} - Tamaño: {tamaño}");
            Console.WriteLine("Ingredientes: " + string.Join(", ", toppings));
        }

        static void MostrarOrdenes()
        {
            Console.WriteLine("\n=== Pedidos realizados ===");

            if (ordenes.Count == 0)
            {
                Console.WriteLine("No hay pedidos registrados aún.");
                return;
            }

            foreach (var orden in ordenes)
            {
                string nombre = orden[0];
                string tamaño = orden[1];
                string fecha = orden[^1];
                List<string> toppings = orden.GetRange(2, orden.Count - 3);

                Console.WriteLine($"\nCliente: {nombre}");
                Console.WriteLine($"Tamaño: {tamaño}");
                Console.WriteLine($"Ingredientes: {string.Join(", ", toppings)}");
                Console.WriteLine($"Hora: {fecha}");
            }
        }

        static int GetEntrada(string mensaje)
        {
            int numero = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                try
                {
                    numero = Convert.ToInt32(entrada);
                    valido = true;
                }
                catch
                {
                    MostrarMensajeError("Entrada inválida. Intenta de nuevo:");
                }
            }

            return numero;
        }

        static void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine($"[Error] {mensaje}");
        }

        static void PausarYLimpiar()
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
