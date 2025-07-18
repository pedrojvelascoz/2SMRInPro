///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra tercera clase. Vamos a ver diferentes métodos y signatura </summary>
namespace UT3p3
{
    public class Reloj
    {
        // Atributos
        private string Nombre;// Propiedad para el nombre del producto
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }

        //CONSTRUCTORES. Voy a hacer tres (en este caso, podría tener muchos más)
        // Método constructor vacio
        public Reloj()
        {

        }
        //Constructor con un parámetro Nombre
        public Reloj(string nombre)
        {
            Nombre = nombre; // Asigna el nombre proporcionado al campo Nombre
        }
        // Constructor con parámetros
        public Reloj(int hora, int minuto, int segundo)
        {
            Hora = hora; // Asigna la hora proporcionada al campo Hora
            Minuto = minuto; // Asigna el minuto proporcionado al campo Minuto
            Segundo = segundo; // Asigna el segundo proporcionado al campo Segundo
        }

        //METODOS. Voy a hacer varios métodos para ver diferentes tipos de signaturas. Un void y una función.
        // Método para mostrar la hora con un procedimiento o void
        public void MostrarHora()
        {
            Console.WriteLine($"Hora: {Hora:D2}:{Minuto:D2}:{Segundo:D2}"); // Imprime la hora en formato HH:MM:SS
        }
        // Método para mostrar la hora con una funcion 
        public string MostrarHoraString()
        {
            return $"{Hora:D2}:{Minuto:D2}:{Segundo:D2}"; // Devuelve la hora en formato HH:MM:SS como cadena
        }
        // Otro método muy usado.
        //En otros lenguajes de programación, el método ToString() se utiliza para convertir un objeto en una representación de cadena.
        //El método toString ya existe por si mismo. Pongo OVERRIDE para que sepa que lo estoy sobreescribiendo a mi manera.
        public override string ToString()
        {
            return $"Reloj: {Nombre}, Hora: {Hora:D2}:{Minuto:D2}:{Segundo:D2}"; // Devuelve una representación de cadena del objeto Reloj      
        }

        //En otros lenguajes de programación, existen accesores y mutadores (getters y setters) para acceder a los atributos de una clase.
        // En C#, se utilizan propiedades para lograr lo mismo de una manera más concisa y legible.
        // public int Hora { get; set; } es nuestra declaración de atributo, el accesor (get) y el mutador (set).
        // Voy a hacerlos para que se vean

        // Mutador del atributo Hora mediante un procedimiento
        public void setHora(int hora)
        {
            Hora = hora; // Asigna el valor proporcionado al atributo Hora
        }
        // Accesor del atributo Hora mediante una función
        public int getHora()
        {
            return Hora; // Devuelve el valor de la propiedad Hora
        }

        //A la hora de programar un método, puede tener parámetros
        public void sumaHoras(int horasSumar)
        {
            Hora += horasSumar; // Suma las horas proporcionadas al atributo Hora
            if (Hora >= 24) // Si la hora supera 23, se ajusta al rango de 0 a 23
            {
                Hora -= 24; // Ajusta la hora restando 24
            }
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Creo un objeto Reloj.
            Reloj relojCocina = new Reloj(11, 20, 37); // Crea un objeto Reloj con el nombre "Cocina"
            // Muestro la hora, que efectivamente es 11:20:37
            relojCocina.MostrarHora(); // Muestra la hora del reloj en formato HH:MM:SS 

            //Mutador en C#
            relojCocina.Hora = 10;
            //Mutador en Java
            relojCocina.setHora(10);

            //Accesor en C#
            Console.WriteLine(relojCocina.Hora);
            //Accesor en Java
            Console.WriteLine(relojCocina.getHora());

            // Muestro la hora, pero ahora con el otro método creado.
            Console.WriteLine(relojCocina.ToString());

        }
    }

}

