///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra séptima clase. Vamos a ver las librerías </summary>

class Program
{
    static int Absoluto(int numero)
    {
        // Concreto lo de las llaves: si solo hay una instruccion dentro del if, no son necesarias.
        if (numero < 0)
            return -numero;
        else
            return numero;
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        int resultado = Absoluto(numero);
        int resultadoMath = Math.Abs(numero);
        Console.WriteLine($"El valor absoluto de {numero} usando mi función es {resultado}");
        Console.WriteLine($"El valor absoluto de {numero} usando la librería es {resultadoMath}");
    }
}
