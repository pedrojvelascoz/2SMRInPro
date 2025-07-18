/// <author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra primera clases. Prueba a hacer el diagrama de la clase  </summary>

// Fíjate que siempre voy a poner el nombre del proyecto como namespace.
namespace UT3p1
{
    //Nombre de la clase. Fíjate que siempre empieza por mayúscula.
    // En este caso, la clase se llama Program. El archivo .cs debe tener el mismo nombre que la clase.
    //Program es el punto de entrada de la aplicación.
    class Program
    { //Esta persona existe en todo el programa.
        static void Main(string[] args)
        {
            Persona persUno = new Persona();
            Persona persDos = new Persona();
            persUno.Saludar();
            Console.WriteLine("Apellido1: " + persUno.Apellido);
            Console.WriteLine("Apellido2: " + persDos.Apellido);
            persUno.Apellido = "Velasco";
            persDos.fijaApellido("Zufia");
            Console.WriteLine("Apellido1: " + persUno.Apellido);
            Console.WriteLine("Apellido2: " + persDos.Apellido);


        }
    }
}

