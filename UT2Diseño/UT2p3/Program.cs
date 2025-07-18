///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa toma sirve para explicar las estructuras de control alternativas  </summary>

//Declaración de variables
string nombre = "Pedro";
string apellido;
double altura = 1.85;
int ? edad = 35;
string diaFav = "Viernes";

//Vamos a probar la primera sentencia: if simple.
if (nombre == "Pedro"){
    Console.WriteLine("Y, ¿cuál es tu apellido?");
    apellido = Console.ReadLine();
    //Ya que estoy, te voy a contar tres maneras de obtener el mismo resultado por pantalla.
    Console.WriteLine($"Hola {nombre} {apellido}, bienvenido al curso de SMR2.");
    Console.WriteLine("Hola " + nombre + " " + apellido + ", bienvenido al curso de SMR2.");
    Console.WriteLine("Hola {0} {1}, bienvenido al curso de SMR2.", nombre, apellido);
}

//Vamos a probar la segunda sentencia: if - else. Normal
if (edad >= 18){
    Console.WriteLine("Eres mayor de edad.");
}else{
    Console.WriteLine("Eres menor de edad.");
}

//Vamos a probar la segunda sentencia: if - else. Ternaria
Console.WriteLine(edad >= 18 ? "Mayor de edad." : "Menor de edad.");

//Vamos a probar la tercera sentencia: if - else if - else.

if (altura < 1.60){
    Console.WriteLine("Eres bajito.");
} else if (altura >= 1.60 && altura < 1.80){
    Console.WriteLine("Eres de estatura media.");
} else if (altura >= 1.80 && altura < 2.00){
    Console.WriteLine("Eres alto.");
} else {
    Console.WriteLine("Eres muy alto.");
}

//Vamos a probar la cuarta sentencia: switch - case.
switch (diaFav.ToLower()){
    case "lunes":
        Console.WriteLine("Serás el primer ser humano en pensrlo");
        break;
    case "martes":
        Console.WriteLine("Un martes? Ve al psicologo.");
        break;
    case "miércoles":
        Console.WriteLine("Ni de coña.");
        break;
    case "jueves":
        Console.WriteLine("No es el mejor, pero lo acepto.");
        break;
    case "viernes":
        Console.WriteLine("Tienes razón, el viernes es el mejor día de la semana.");
        break;
    case "sábado":
        Console.WriteLine("NPC.");
        break;
    case "domingo":
        Console.WriteLine("¿En serio?");
        break;
    default:
        Console.WriteLine("No has introducido un día válido.");
        break;
}