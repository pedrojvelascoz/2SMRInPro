///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>

//Cuarta calculadora. Tenemos código repetido. Vamos a hacer funciones y procedimientos.
//Recuerda: funciones y proceidmientos son métodos. Función tiene return, proceidmiento es un void.

//Primera función. Imprimir el mensaje por pantalla. Es un poco diferente a la de clase, lo se.
// Imprimiré tanto el resultado como el error.
void ImprimirMensaje(string mensaje)
{
    Console.WriteLine(mensaje);
}

//Segunda función. Tengo dos veces lo de pedir número. Lo unifico en una función.
double PedirNumero()
{
    Console.WriteLine("Ingrese un número:");
    double numero = Convert.ToDouble(Console.ReadLine());
    return numero;
}

//Tercera función. Pedir operación.
//Ya que estoy, si el usuario me da algo no vállido, le hago repetir.
char PedirOperacion()
{
    char operacion = 'f'; //Valor cualquiera inicial. Erróneo;
    while (!((operacion == '+' || operacion == '-' || operacion == '*' || operacion == '/')))
    {
        Console.WriteLine("Ingrese la operación (+, -, *, /):");
        operacion = Convert.ToChar(Console.ReadLine());
    }
    return operacion;
}

bool usarCalculadora = true;
bool hayError = false;

Console.WriteLine("Calculadora 4. Versión con funciones y procedimientos.");

while (usarCalculadora)
{

    double num1 = PedirNumero(); //Llamo a la segunda función.
    double num2 = PedirNumero(); //Llamo a la segunda función.
    char operacion = PedirOperacion(); //Llamo a la tercera función.

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
            ImprimirMensaje("Operación no válida."); //Fijate. Ahora llamo a imprimirMensaje. Le paso el mensaje que quiero directamente.
            break;
    }
    if (!hayError)
    {
        string mensaje = "El resultado es: " + resultado;
        ImprimirMensaje(mensaje); //Aquí si le paso una variable a imprimir.
    }

    usarCalculadora = seguirCalculando(); //Llamo a la cuarta función.
}

// Cuarta funcion. La decisión del usuario de continuar o no.
// No hago control de errores aquí. En la tercera función, si.
bool seguirCalculando()
{
    Console.WriteLine("¿Desea realizar otra operación?");
    Console.WriteLine(" Si - true. No - false");
    bool continuar = Convert.ToBoolean(Console.ReadLine());
    return continuar;
}
