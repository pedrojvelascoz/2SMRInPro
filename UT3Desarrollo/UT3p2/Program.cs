///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra segunda clases. La he obtenido del diagrama de clase  </summary>
/// 
namespace UT3p2
{
    public class Producto
    {
        // Atributos
        public string Nombre { get; set; }
        public double Precio { get; set; }

        // Método constructor
        public Producto(string nombre, double precio)
        {
            Nombre = nombre; // Asigna el nombre proporcionado al campo Nombre
            Precio = precio; // Asigna el precio proporcionado al campo Precio
        }

        // Método
        public void MostrarInformacion()
        {
            Console.WriteLine($"Producto: {Nombre}, Precio: {Precio}"); // Imprime la información del producto
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto("Laptop", 795.95); // Crea una instancia de Producto con nombre y precio
            producto.MostrarInformacion();

        }
    }

}