using System;

namespace UT3CheesyPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var gestorPedidos = new GestorPedidos();
            var gestorClientes = new GestorClientes();

            // Cargar datos guardados
            gestorClientes.CargarDeArchivo();
            gestorPedidos.CargarDeArchivo(gestorClientes);

            bool salir = false;

            while (!salir)
            {
                menu.MostrarMenuPrincipal();
                int opcion = menu.GetEntrada("Selecciona una opción: ");

                switch (opcion)
                {
                    case 1:
                        CrearPedido(menu, gestorPedidos, gestorClientes);
                        break;
                    case 2:
                        gestorPedidos.MostrarPedidos();
                        break;
                    case 3:
                        GestionClientes(menu, gestorClientes);
                        break;
                    case 4:
                        Console.WriteLine("¡Gracias por usar Cheesy Pizza!");
                        salir = true;
                        break;
                    default:
                        menu.MostrarMensajeError("Opción no válida.");
                        break;
                }

                if (!salir)
                    menu.PausarYLimpiar();
            }
            gestorClientes.GuardarEnArchivo();
            gestorPedidos.GuardarEnArchivo();
        }

        static void GestionClientes(Menu menu, GestorClientes gestorClientes)
        {
            bool volver = false;

            while (!volver)
            {
                menu.MostrarMenuClientes();
                int opcion = menu.GetEntrada("Selecciona una opción: ");

                switch (opcion)
                {
                    case 1:
                        gestorClientes.MostrarClientes();
                        break;

                    case 2:
                        Console.Write("Nombre nuevo cliente: ");
                        string nombreNuevo = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(nombreNuevo))
                        {
                            gestorClientes.AgregarCliente(new Cliente(nombreNuevo));
                            Console.WriteLine("Cliente agregado.");
                        }
                        else
                            menu.MostrarMensajeError("Nombre inválido.");
                        break;

                    case 3:
                        gestorClientes.MostrarClientes();
                        if (gestorClientes.ObtenerClientes().Count == 0) break;

                        int idxModificar = menu.PedirIndiceCliente(gestorClientes.ObtenerClientes().Count);
                        Console.Write("Nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();
                        if (gestorClientes.ActualizarCliente(idxModificar, nuevoNombre))
                            Console.WriteLine("Cliente modificado.");
                        else
                            menu.MostrarMensajeError("Índice inválido.");
                        break;

                    case 4:
                        gestorClientes.MostrarClientes();
                        if (gestorClientes.ObtenerClientes().Count == 0) break;

                        int idxEliminar = menu.PedirIndiceCliente(gestorClientes.ObtenerClientes().Count);
                        if (gestorClientes.EliminarCliente(idxEliminar))
                            Console.WriteLine("Cliente eliminado.");
                        else
                            menu.MostrarMensajeError("Índice inválido.");
                        break;

                    case 5:
                        volver = true;
                        break;

                    default:
                        menu.MostrarMensajeError("Opción no válida.");
                        break;
                }

                if (!volver)
                    menu.PausarYLimpiar();
            }
        }

        static void CrearPedido(Menu menu, GestorPedidos gestorPedidos, GestorClientes gestorClientes)
        {
            Console.WriteLine("\n=== Crear pedido ===");

            if (gestorClientes.ObtenerClientes().Count == 0)
            {
                Console.WriteLine("No hay clientes registrados. Debes crear uno primero.");
                Console.Write("Nombre nuevo cliente: ");
                string nombreNuevo = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nombreNuevo))
                {
                    gestorClientes.AgregarCliente(new Cliente(nombreNuevo));
                    Console.WriteLine("Cliente agregado.");
                }
                else
                {
                    menu.MostrarMensajeError("Nombre inválido, cancelando creación de pedido.");
                    return;
                }
            }

            // Mostrar clientes y elegir uno
            gestorClientes.MostrarClientes();
            int idxCliente = menu.PedirIndiceCliente(gestorClientes.ObtenerClientes().Count);
            Cliente clienteSeleccionado = gestorClientes.ObtenerClientePorIndice(idxCliente);

            if (clienteSeleccionado == null)
            {
                menu.MostrarMensajeError("Cliente no válido, cancelando pedido.");
                return;
            }

            string tamano = menu.PedirTamanoPizza();
            var ingredientes = menu.SeleccionarToppings();

            var pedido = new Pedido(clienteSeleccionado, tamano, ingredientes);
            gestorPedidos.AgregarPedido(pedido);
            pedido.MostrarResumen();
        }
    }
}