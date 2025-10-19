///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>

//Tercera calculadora. La calculadora solo se ejecuta una vez.
//Podría usar un for(int i=0; i<1; i++) pero no tiene sentido ya que solo se ejecuta un numero de veces concretas
//Vamos a preguntarle al usuario si quieres volver a usar la calculadora o no 

bool usarCalculadora = true;
bool hayError = false;

Console.WriteLine("Calculadora 3. Repetir hasta que el usuario quiera salir.");

while (usarCalculadora)
{

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

    Console.WriteLine("¿Desea realizar otra operación?");
    Console.WriteLine(" Si - true. No - false");
    usarCalculadora = Convert.ToBoolean(Console.ReadLine());
}


