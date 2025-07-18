///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra cuarta clase. Vamos a ver los constructores </summary>
namespace UT3p4
{
    public class Reloj
    {
        // ATRIBUTOS
        private string Nombre;// Propiedad para el nombre del producto
        public DateTime Manecillas { get; set; }

        //CONSTRUCTORES. 
        // Método constructor vacio
        public Reloj()
        {

        }
        //Constructor con un parámetro Nombre
        public Reloj(string nombre)
        {
            Nombre = nombre; // Asigna el nombre proporcionado al campo Nombre
        }
        // Constructor con un parámetro Manecillas
        public Reloj(DateTime manecillas)
        {
            Manecillas = manecillas; // Asigna las manecillas proporcionadas al campo Manecillas
        }

        public Reloj(string nombre, DateTime manecillas)
        {
            Nombre = nombre; // Asigna el nombre proporcionado al campo Nombre
            Manecillas = manecillas; // Asigna las manecillas proporcionadas al campo Manecillas
        }

        //METODOS. No voy a hacer ninguno.
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Reloj relojUno = new Reloj(); // Crea un objeto Reloj usando el constructor vacío
            Reloj relojDos = new Reloj("Cocina"); // Crea un objeto Reloj con el nombre "Cocina"
            Reloj relojTres = new Reloj(DateTime.Now); // Crea un objeto Reloj con las manecillas actuales
            Reloj relojCuatro = new Reloj("Cocina", DateTime.Now); // Crea un objeto Reloj con el nombre "Cocina"

        }
    }

}

