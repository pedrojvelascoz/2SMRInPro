///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra quinta clase. Vamos a ver constantes y estáticos </summary>
/// 

namespace UT3p5
{
    public class Esfera
    {
        // Una vez más. Atributos de la clase con accesores y mutadores
        public double Radio { get; set; }
        public double Diametro { get; set; }
        public double Volumen { get; set; }
        public const double PI = 3.14159265358979323846;
        public static int EsferasCreadas { get; set; } = 0;

        // No tengo ni constructor ni métodos. 
        // Si no tengo constructor, el compilador me crea uno por defecto. El vacío.
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Esfera esfera1 = new Esfera();
            esfera1.Radio = 5;
            esfera1.Diametro = 2 * esfera1.Radio;
            esfera1.Volumen = (4.0 / 3.0) * Esfera.PI * Math.Pow(esfera1.Radio, 3);
            Esfera.EsferasCreadas++;

            Esfera esfera2 = new Esfera();
            Esfera.EsferasCreadas++;

            Console.WriteLine($"Radio: {esfera1.Radio}, Diámetro: {esfera1.Diametro}, Volumen: {esfera1.Volumen}");
            Console.WriteLine($"Número de esferas creadas: {Esfera.EsferasCreadas}");
        }
    }
}