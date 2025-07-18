///<author> pedrojvelascoz </author>
/// <context> CIMasanz - SMR2 - INPRO </context>
/// <summary> Este programa es nuestra octava clase. Vamos a ver los diccionarios </summary> 

// Si, puedo poner var para declarar una variable
var inventario = new Dictionary<string, double>();

//Relleno el diccionario con algunos productos y sus precios
inventario["Cereza"] = 1.2;
inventario["Platano"] = 0.5;
inventario["Melocoton"] = 0.8;
inventario.Add("Manzana", 0.6);

// Buscar el precio de un producto específico
string productoBuscar = "Platano";
if (inventario.ContainsKey(productoBuscar))
{
    double precio = inventario[productoBuscar];
    Console.WriteLine($"El precio del {productoBuscar} es {precio}");
}
else
{
    Console.WriteLine($"El producto {productoBuscar} no se encuentra en el inventario.");
}