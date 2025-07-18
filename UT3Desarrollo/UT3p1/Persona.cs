///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra primera clases. Prueba a hacer el diagrama de la clase  </summary>

// Fíjate que siempre voy a poner el nombre del proyecto como namespace.
namespace UT3p1
{
    //Nombre de la clase. Fíjate que siempre empieza por mayúscula.
    // En este caso, la clase se llama Persona. El archivo .cs debe tener el mismo nombre que la clase.
    public class Persona
    {
        // Atributos
        public int dni;
        private DateTime fechaNacimiento;
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Constructor
        // El constructor es un método especial que se llama al crear un objeto de esta clase. 
        // No creamos ninguno en esta ocasión, pero lo podemos hacer si queremos inicializar atributos.

        // Métodos
        public void Saludar()
        {
            Console.WriteLine("¡Hola!");
        }

        public void fijaApellido(string apellido) // Esto sobra. Es como el getter
        {
            this.Apellido = apellido;
        }
    }
}