using System;
using System.Collections.Generic;

namespace UT3CheesyPizza
{
    public class Menu
    {
        private readonly string[] toppingsDisponibles = {
            "Queso extra",
            "Pepperoni",
            "Champiñones",
            "Jamón",
            "Aceitunas",
            "Cebolla",
            "Pimiento"
        };

        public void MostrarMenuPrincipal()
        {
            Console.WriteLine("=== Cheesy Pizza ===");
            Console.WriteLine("1. Crear pedido");
            Console.WriteLine("2. Ver pedidos");
            Console.WriteLine("3. Gestión de clientes");
            Console.WriteLine("4. Salir");
        }

        public string PedirNombreCliente()
        {
            Console.Write("Nombre del cliente: ");
            return Console.ReadLine();
        }

        public string PedirTamanoPizza()
        {
            Console.WriteLine("\nSelecciona tamaño de pizza:");
            Console.WriteLine("1. Pequeña");
            Console.WriteLine("2. Mediana");
            Console.WriteLine("3. Grande");

            int opcion = GetEntrada("Opción: ");

            return opcion switch
            {
                1 => "Pequeña",
                2 => "Mediana",
                3 => "Grande",
                _ => "Desconocida"
            };
        }

        public List<string> SeleccionarToppings()
        {
            List<string> seleccionados = new List<string>();

            while (true)
            {
                MostrarToppingsDisponibles();

                int opcion = GetEntrada("Opción: ");
                if (opcion == 0) break;

                if (opcion >= 1 && opcion <= toppingsDisponibles.Length)
                {
                    string topping = toppingsDisponibles[opcion - 1];
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

        private void MostrarToppingsDisponibles()
        {
            Console.WriteLine("\nIngredientes disponibles:");
            for (int i = 0; i < toppingsDisponibles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {toppingsDisponibles[i]}");
            }
            Console.WriteLine("0. Terminar selección");
        }

        public int GetEntrada(string mensaje)
        {
            int numero = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                    valido = true;
                else
                    MostrarMensajeError("Entrada inválida. Intenta de nuevo:");
            }

            return numero;
        }

        public void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine($"[Error] {mensaje}");
        }

        public void PausarYLimpiar()
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void MostrarMenuClientes()
        {
            Console.WriteLine("\n=== Gestión de Clientes ===");
            Console.WriteLine("1. Ver clientes");
            Console.WriteLine("2. Añadir cliente");
            Console.WriteLine("3. Modificar cliente");
            Console.WriteLine("4. Eliminar cliente");
            Console.WriteLine("5. Volver al menú principal");
        }


        public int PedirIndiceCliente(int max)
        {
            int opcion = GetEntrada($"Selecciona cliente (1-{max}): ");
            return opcion - 1; // ajustar a índice base 0
        }
    }
}
