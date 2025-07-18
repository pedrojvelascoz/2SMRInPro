using System;
using System.Collections.Generic;
using System.IO;

namespace UT3CheesyPizza
{
    public class GestorPedidos
    {
        private readonly List<Pedido> pedidos = new List<Pedido>();
        private const string ArchivoPedidos = "pedidos.txt";

        public void AgregarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        public void MostrarPedidos()
        {
            Console.WriteLine("\n=== Pedidos realizados ===");

            if (pedidos.Count == 0)
            {
                Console.WriteLine("No hay pedidos registrados aún.");
                return;
            }

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"\nCliente: {pedido.Cliente.Nombre}");
                Console.WriteLine($"Tamaño: {pedido.TamanoPizza}");
                Console.WriteLine($"Ingredientes: {string.Join(", ", pedido.Ingredientes)}");
                Console.WriteLine($"Hora: {pedido.FechaHora:yyyy-MM-dd HH:mm:ss}");
            }
        }

        public void GuardarEnArchivo()
        {
            using StreamWriter sw = new StreamWriter(ArchivoPedidos);
            foreach (var pedido in pedidos)
            {
                // Formato: ClienteNombre|Tamaño|Ingrediente1,Ingrediente2,...|FechaHora
                string ingredientes = string.Join(",", pedido.Ingredientes);
                string linea = $"{pedido.Cliente.Nombre}|{pedido.TamanoPizza}|{ingredientes}|{pedido.FechaHora:O}";
                sw.WriteLine(linea);
            }
        }

        public void CargarDeArchivo(GestorClientes gestorClientes)
        {
            pedidos.Clear();
            if (!File.Exists(ArchivoPedidos))
                return;

            foreach (var linea in File.ReadLines(ArchivoPedidos))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split('|');
                if (partes.Length != 4) continue;

                string nombreCliente = partes[0];
                string tamano = partes[1];
                string[] ingredientesArray = partes[2].Split(',', StringSplitOptions.RemoveEmptyEntries);
                List<string> ingredientes = new List<string>(ingredientesArray);
                if (!DateTime.TryParse(partes[3], null, System.Globalization.DateTimeStyles.RoundtripKind, out DateTime fechaHora))
                    fechaHora = DateTime.Now;

                // Buscar cliente por nombre
                Cliente cliente = gestorClientes.ObtenerClientes().Find(c => c.Nombre == nombreCliente);
                if (cliente == null)
                {
                    cliente = new Cliente(nombreCliente);
                    gestorClientes.AgregarCliente(cliente);
                }

                Pedido pedido = new Pedido(cliente, tamano, ingredientes, fechaHora);
                pedidos.Add(pedido);
            }
        }
    }
}
