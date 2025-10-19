///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>

//Segunda calculadora. Hago una variable booleana hayError que empieza en falso. 
//Si entro en el default del switch, pongo hayError a true.
//Al final, solo muestro el resultado si hayError es falso. 

bool hayError = false;

Console.WriteLine("Calculadora 2. Versión con if de control de errores.");
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
        hayError = true;
        Console.WriteLine("Operación no válida.");
        break;
}
if (!hayError)
{
    Console.WriteLine("El resultado es: " + resultado);
}