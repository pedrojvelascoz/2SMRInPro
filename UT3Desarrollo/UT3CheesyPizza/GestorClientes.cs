using System;
using System.Collections.Generic;
using System.IO;

namespace UT3CheesyPizza
{
    public class GestorClientes
    {
        private readonly List<Cliente> clientes = new List<Cliente>();
        private const string ArchivoClientes = "clientes.txt";

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> ObtenerClientes()
        {
            return new List<Cliente>(clientes);
        }

        public Cliente ObtenerClientePorIndice(int index)
        {
            if (index >= 0 && index < clientes.Count)
                return clientes[index];
            return null;
        }

        public bool ActualizarCliente(int index, string nuevoNombre)
        {
            if (index >= 0 && index < clientes.Count)
            {
                clientes[index] = new Cliente(nuevoNombre);
                return true;
            }
            return false;
        }

        public bool EliminarCliente(int index)
        {
            if (index >= 0 && index < clientes.Count)
            {
                clientes.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void MostrarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
                return;
            }

            Console.WriteLine("\n=== Lista de clientes ===");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientes[i].Nombre}");
            }
        }

        public void GuardarEnArchivo()
        {
            using StreamWriter sw = new StreamWriter(ArchivoClientes);
            foreach (var cliente in clientes)
            {
                sw.WriteLine(cliente.Nombre);
            }
        }

        public void CargarDeArchivo()
        {
            clientes.Clear();
            if (!File.Exists(ArchivoClientes))
                return;

            foreach (var linea in File.ReadLines(ArchivoClientes))
            {
                if (!string.IsNullOrWhiteSpace(linea))
                    clientes.Add(new Cliente(linea.Trim()));
            }
        }
    }
}
