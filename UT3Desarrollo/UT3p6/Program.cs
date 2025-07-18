///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra sexta clase. Vamos a ver la recursividad </summary>

class Program
{
    static int Factorial(int n)
    {
        // Caso base
        // Por cierto, si tengo un if simple no hacen falta las llaves.
        if (n == 0 || n == 1)
            return 1;

        // Llamada recursiva
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = Factorial(numero);

        Console.WriteLine($"El factorial de {numero} es {resultado}");
    }
}
