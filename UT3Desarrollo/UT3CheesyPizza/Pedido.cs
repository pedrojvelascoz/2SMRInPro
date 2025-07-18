using System;
using System.Collections.Generic;

namespace UT3CheesyPizza
{
    public class Pedido
    {
        public Cliente Cliente { get; }
        public string TamanoPizza { get; }
        public List<string> Ingredientes { get; }
        public DateTime FechaHora { get; }

        public Pedido(Cliente cliente, string tamanoPizza, List<string> ingredientes)
        {
            Cliente = cliente;
            TamanoPizza = tamanoPizza;
            Ingredientes = new List<string>(ingredientes);
            FechaHora = DateTime.Now;
        }

        // Constructor para cargar con fecha específica
        public Pedido(Cliente cliente, string tamanoPizza, List<string> ingredientes, DateTime fechaHora)
        {
            Cliente = cliente;
            TamanoPizza = tamanoPizza;
            Ingredientes = new List<string>(ingredientes);
            FechaHora = fechaHora;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"\nPedido creado para {Cliente.Nombre} - Tamaño: {TamanoPizza}");
            Console.WriteLine("Ingredientes: " + string.Join(", ", Ingredientes));
            Console.WriteLine($"Hora: {FechaHora:yyyy-MM-dd HH:mm:ss}");
        }
    }
}
