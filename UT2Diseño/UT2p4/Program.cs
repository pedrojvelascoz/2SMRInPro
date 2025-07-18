///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa toma sirve para explicar las estructuras de control iterativas  </summary>

//Declaración de variables
    int[] numbers = {1, 2, 3, 4, 5};
    int sum = 0;
    int i = 0;

// Bucle for. Conocemos un número de iteraciones de antemano
    for (i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    Console.WriteLine("La suma de todos los números es: " + sum);

// Bucle while. No conocemos el número de iteraciones de antemano
    sum = 0;
    i = 0;
    while (i < numbers.Length)
    {
        sum += numbers[i];
        i++;
    }
    Console.WriteLine("La suma de todos los números es: " + sum);

// Bucle do while. Se ejecuta al menos una vez
    sum = 0;
    i = 0;
    do
    {
        sum += numbers[i];
        i++;
    } while (i < numbers.Length);
    Console.WriteLine("La suma de todos los números es: " + sum); 

// Bucle foreach. Recorre todos los elementos de una colección
    sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    Console.WriteLine("La suma de todos los números es: " + sum);