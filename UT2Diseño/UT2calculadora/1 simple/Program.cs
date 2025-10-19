///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>

//Primera calculadora. Normal. Si hago una operación prohibida, sale el mensaje de error y resultado no se calcula.

Console.WriteLine("Calculadora 1. Versión simple");
Console.WriteLine("Ingrese el primer número:");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la operación (+, -, *, /):");
char operacion = Convert.ToChar(Console.ReadLine());

double resultado = 0;
switch (operacion)
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        resultado = num1 / num2;
        break;
    default:
        Console.WriteLine("Operación no válida.");
        break;
}
Console.WriteLine("El resultado es: " + resultado);