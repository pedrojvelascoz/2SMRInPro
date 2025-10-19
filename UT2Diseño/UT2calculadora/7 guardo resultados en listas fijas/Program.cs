///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>

//Séptima calculadora. Voy a guardar los resultados en una estructura de datos fija (Array)
//Para ello, en vez de preguntar al usuario si quiere seguir calculando, voy a hacer 3 operaciones con un for.

bool usarCalculadora = true;
bool hayError = false;

Console.WriteLine("Calculadora 7. Arrays de tamaño fijo");

//Declaro la estructura de datos. Antes del bucle, evidentemente.
double[] resultados = new double[3];

for (int i = 0; i < 3; i++)
{

    double num1 = PedirNumero(); //Llamo a la segunda función.
    double num2 = PedirNumero(); //Llamo a la segunda función.
    char operacion = PedirOperacion(); //Llamo a la tercera función.

    double resultado = 0;

    CalculadoraPrincipal(num1, num2, operacion, hayError, ref resultado); //Lo del switch, lo meto aquí.

    resultados[i] = resultado; //Guardo el resultado en el array.

    if (!hayError)
    {
        string mensaje = "El resultado es: " + resultados[i]; //ESTO HA CAMBIADO
        ImprimirMensaje(mensaje); //Aquí si le paso una variable a imprimir.
    }

    //sarCalculadora = seguirCalculando(); 
    //No me hace falta. El iterador del for se actualiza solo
}

Console.WriteLine("Saco por pantalla todos los resultados");
for (int i = 0; i < resultados.Length; i++) //Esto del .Length se usa mucho.
{
    Console.WriteLine("Resultado de la operación " + (i + 1) + ": " + resultados[i]);
}


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

// Cuarta funcion. La decisión del usuario de continuar o no.
// No hago control de errores aquí. En la tercera función, si.
bool seguirCalculando()
{
    Console.WriteLine("¿Desea realizar otra operación?");
    Console.WriteLine(" Si - true. No - false");
    bool continuar = Convert.ToBoolean(Console.ReadLine());
    return continuar;
}

//Quinta función. La calculadora en sí. Aquí hago el switch. Valor por referencia.
double CalculadoraPrincipal(double numero1, double numero2, char operacion, bool hayError, ref double resultado)
{
    switch (operacion)
    {
        case '+':
            resultado = numero1 + numero2;
            break;
        case '-':
            resultado = numero1 - numero2;
            break;
        case '*':
            resultado = numero1 * numero2;
            break;
        case '/':
            resultado = numero1 / numero2;
            break;
        default:
            hayError = true;
            ImprimirMensaje("Operación no válida."); //Fijate. Ahora llamo a imprimirMensaje. Le paso el mensaje que quiero directamente
            break;
    }
    return resultado;
}