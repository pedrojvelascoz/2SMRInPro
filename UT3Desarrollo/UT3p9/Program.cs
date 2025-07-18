///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra novena clase. Vamos a depurar </summary> 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa que solo suma números positivos");

        List<int> numeros = new List<int> { 3, -1, 5, -2, 7, -4 };

        int resultado = SumarSoloPositivos(numeros);

        Console.WriteLine($"La suma de los números positivos es: {resultado}");
    }

    static int SumarSoloPositivos(List<int> lista)
    {
        int suma = 0;

        foreach (int numero in lista)
        {
            if (numero < 0)
            {
                suma += numero;
            }
        }

        return suma;
    }
}