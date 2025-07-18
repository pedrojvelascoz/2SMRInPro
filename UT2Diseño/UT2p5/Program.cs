///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa toma sirve para explicar las modularización.
/// Diferenciamos el paso de parámetros por valor o por referencia  </summary>

class Program
{

    static void Main()
    {
        int valor = 5;
        Incrementar(valor);
        Console.WriteLine(valor); // Muestra 5
    }

        static void Incrementar(int valor)
    {
        valor++; 
        Console.WriteLine(valor); // Muestra 6
    }

}